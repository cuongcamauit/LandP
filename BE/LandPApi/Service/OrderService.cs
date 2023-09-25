using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.Utils;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;
using PayPal.Api;
using System.Configuration;
using System.Security.Claims;
using System.Web.Http.Results;

namespace LandPApi.Service
{
    public class OrderService : IOrderService
    {
        private readonly IConfiguration _configuration;
        private readonly IRepository<Models.Order> _repoOrder;
        private readonly IRepository<CartItem> _repoCart;
        private readonly IRepository<OrderDetail> _repoDetail;
        private readonly IRepository<HistoryStatus> _repoHis;
        private readonly IRepository<Models.Address> _repoAdd;
        private readonly IRepository<Product> _repoPro;
        private readonly IMapper _mapper;
        private readonly double exchangeRate = 23000;

        public OrderService(IRepository<Models.Order> repoOrder, 
                            IRepository<CartItem> repoCart, 
                            IRepository<OrderDetail> repoDetail, 
                            IRepository<HistoryStatus> repoHis,
                            IRepository<Models.Address> repoAdd,
                            IRepository<Product> repoPro,
                            IMapper mapper,
                            IConfiguration configuration)
        {
            _configuration = configuration;
            _repoOrder = repoOrder;
            _repoCart = repoCart;
            _repoDetail = repoDetail;
            _repoHis = repoHis;
            _repoAdd = repoAdd;
            _repoPro = repoPro;
            _mapper = mapper;
        }

        public async Task<double> GetTotal(string customerId, OrderView view)
        {
            double total = 0;
            // everything is fine

            foreach (var item in view.productIds!)
            {
                var entityPro = await _repoPro.ReadByCondition(o => o.Id == item).Include(o => o.ProductPrices).FirstOrDefaultAsync()!;
                var entityCart = await _repoCart.ReadByCondition(o => o.CustomerId == customerId && o.ProductId == item).FirstOrDefaultAsync()!;

                if (entityPro != null && entityCart != null)
                    total += entityPro!.GetNowPrice() * entityCart!.Quantity;
            }
            return total;
        }
    

        public async Task<OrderDto?> Add(string customerId, OrderView view)
        {
            double total = 0;
            var address = await _repoAdd.ReadByCondition(o => o.CustomerId == customerId
                                                        && o.Id == view.AddressId).FirstOrDefaultAsync();
            if (address == null)
            {
                return null;
            }
            var order = new Models.Order
            {
                CustomerId = customerId,
                Status = Status.New,
                Date = DateTime.Now,
                AddressId = view.AddressId
            };

            _repoOrder.Create(order);

            int d = 0;
            var cartItem = _repoCart.ReadByCondition(o => o.CustomerId == customerId).ToList();
            foreach (var item in cartItem)
            {
                if (!view.productIds!.Contains(item.ProductId) ||
                    item.Quantity > (await _repoPro.ReadByCondition(e => e.Id == item.ProductId).FirstOrDefaultAsync())!.Quantity)
                    d++;
            }
                
            if (cartItem.Count()-d != view.productIds!.Count())
                return null;

            // everything is fine
            _repoHis.Create(new HistoryStatus
            {
                Status = Status.New,
                OrderId = order.Id
            });

            foreach (var item in view.productIds!)
            {
                var entityCart = await _repoCart.ReadByCondition(o => o.CustomerId == customerId && o.ProductId == item).FirstOrDefaultAsync()!;
                var entityPro = await _repoPro.ReadByCondition(o => o.Id == item).Include(o => o.ProductPrices).FirstOrDefaultAsync()!;
                _repoDetail.Create(new OrderDetail
                {
                    OrderId = order.Id,
                    Price = entityPro!.GetNowPrice(),
                    ProductId = item,
                    Quantity = entityCart!.Quantity
                });
                total += entityPro.GetNowPrice() * entityCart.Quantity; 

                entityPro.Quantity -= entityCart.Quantity;
                _repoPro.Update(entityPro);
                _repoCart.Delete(entityCart);
            }
            
            var postData = new PostData
            {
                insurance_value = Convert.ToInt32(total),
                to_district_id = address.DistrictId,
                to_ward_code = address.WardCode
            };

            var shipFee = await GHN.FeeShip(postData);
            order.SubTotal = total;
            order.ShippingFee = shipFee;
            _repoOrder.Save();
            _repoPro.Save();
            _repoHis.Save();
            _repoDetail.Save();
            _repoCart.Save();
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<List<OrderDto>> GetAll(string customerId)
        {
            var result = await _repoOrder.ReadByCondition(o => o.CustomerId == customerId).Include(o => o.Address).ToListAsync();
            return _mapper.Map<List<OrderDto>>(result);
        }

        public void Update(ClaimsPrincipal user, Guid orderId, Status status, bool isPaid)
        {
            var order = _repoOrder.ReadByCondition(o => o.Id == orderId);
            
            if (order == null)
            {
                return;
            }
            var statusOrder = order.Select(o => o.Status).FirstOrDefault();

            var claims = ((ClaimsIdentity)user.Identity!).Claims;
            var roles = claims.Where(o => o.Type == ClaimTypes.Role).Select(o => o.Value);
            var idUser = claims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)!.Value;

            if (roles.Contains("User") && order.Where(o => o.CustomerId == idUser) != null)
            {
                if (statusOrder == Status.New && status == Status.Canceled)
                {
                    var historyStatus = new HistoryStatus
                    {
                        Status = Status.Canceled,
                        OrderId = orderId,
                    };
                    var updateOrder = order.FirstOrDefault();
                    updateOrder!.Status = Status.Canceled;
                    //returnProduct(orderId);
                    _repoOrder.Update(updateOrder);
                }
            }

            if (roles.Contains("Admin") && statusOrder != Status.Canceled)
            {
                
                var historyStatus = new HistoryStatus
                {
                    Status = status,
                    OrderId = orderId,
                };
                var updateOrder = order.FirstOrDefault();
                if (statusOrder != status && status == Status.Canceled)
                    returnProduct(orderId);
                //if (statusOrder != status && status == Status.Delivered)
                //    updateSoldQuantity(orderId);
                //updateOrder!.isPaid = isPaid;
                if (isPaid)
                    updateOrder!.PaidAt = DateTime.Now;
                updateOrder!.Status = status;
                _repoOrder.Update(updateOrder);
            }
            _repoPro.Save();
            _repoHis.Save();
            _repoOrder.Save();
        }

        private void updateSoldQuantity(Guid orderId)
        {
            var orderDetail = _repoDetail.ReadByCondition(o => o.OrderId == orderId);
            foreach (var order in orderDetail)
            {
                var product = _repoPro.ReadByCondition(o => o.Id == order.ProductId).FirstOrDefault();
                //product!.SoldQuantity += order.Quantity;
                if (product != null)
                    _repoPro.Update(product);
            }
        }

        public void returnProduct(Guid orderId)
        {
            var orderDetail = _repoDetail.ReadByCondition(o => o.OrderId == orderId).ToList();
            foreach (var order in orderDetail)
            {
                var product = _repoPro.ReadByCondition(o => o.Id == order.ProductId).FirstOrDefault();
                product!.Quantity += order.Quantity;
                _repoPro.Update(product);
            }
        }

        public string PaypalCheckout(Guid orderId)
        {
            //var order = _repoOrder.ReadByCondition(o => o.Id == orderId).SingleOrDefault();
            //if (order != null)
            //{
            //    order.isPaid = true;
            //}
            //_repoOrder.Update(order!);
            //_repoOrder.Save();
            var order = _repoOrder.ReadByCondition(o => o.Id == orderId).FirstOrDefault();

            var apiContext = PaymentUtils.GetApiContext(_configuration);



            var listDetail = _repoDetail.ReadByCondition(o => o.OrderId == orderId).Include(o => o.Product);
            //var total =  Math.Round(listDetail.Sum(o => (o.Price * o.Quantity) / exchangeRate), 2);
            var total = order!.Total();

            var itemList = new ItemList()
            {
                items = new List<Item>()
            };
            foreach (var item in listDetail)
            {
                itemList.items.Add(new Item()
                {
                    name = item.Product!.Name,
                    currency = "USD",
                    price = Math.Round((item.Price) / exchangeRate, 2).ToString(),
                    quantity = item.Quantity.ToString(),
                    sku = "sku",
                    tax = "0"
                });
            }


            // Create a new payment object
            var paypalOrderId = DateTime.Now.Ticks;
            var payment = new Payment
            {
                intent = "sale",
                payer = new Payer
                {
                    payment_method = "paypal"
                },
                transactions = new List<Transaction>
                    {
                        new Transaction
                        {

                            amount = new Amount
                            {
                                currency = "USD",
                                total = total.ToString(),
                                details = new Details
                                {
                                    tax = "0",
                                    shipping = order.ShippingFee.ToString(),
                                    subtotal = order.SubTotal.ToString()
                                }
                            },
                            item_list = itemList,
                            description = $"Invoice #{paypalOrderId}",
                            invoice_number = paypalOrderId.ToString()
                        },

                    },
                redirect_urls = new RedirectUrls
                {
                    return_url = _configuration["AppUrl"] + @"/api/Orders/CheckoutSuccess?orderId=" + orderId,
                    cancel_url = _configuration["AppUrl"] + @"/api/Orders/CheckoutFail"
                }
            };

            // Send the payment to PayPal
            var createdPayment = payment.Create(apiContext);

            //// Save a reference to the paypal payment
            //paymentEntity.PaymentServiceReference = createdPayment.id;
            //_paymentRepository.Add(paymentEntity);
            //_paymentRepository.SaveAll();

            // Find the Approval URL to send our user to
            var approvalUrl =
                createdPayment.links.FirstOrDefault(
                    x => x.rel.Equals("approval_url", StringComparison.OrdinalIgnoreCase));

            // Send the user to PayPal to approve the payment
            return approvalUrl!.href;
        }

        public async Task<OrderDto> GetById(string customerId, Guid id)
        {
            var result = await _repoOrder.ReadByCondition(o => o.CustomerId == customerId && o.Id == id).Include(o => o.Address).SingleOrDefaultAsync();
            return _mapper.Map<OrderDto>(result);
        }

        public void isPaid(Guid orderId)
        {
            var order = _repoOrder.ReadByCondition(o => o.Id == orderId).SingleOrDefault();
            if (order == null)
                return;
            //order!.isPaid = true;
            order!.PaidAt = DateTime.Now;
            _repoOrder.Update(order);
            _repoOrder.Save();
        }
    }
}
