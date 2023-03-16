
using AutoMapper;
using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repoOrder;
        private readonly IRepository<CartItem> _repoCart;
        private readonly IRepository<OrderDetail> _repoDetail;
        private readonly IRepository<HistoryStatus> _repoHis;
        private readonly IRepository<Address> _repoAdd;
        private readonly IRepository<Product> _repoPro;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Order> repoOrder, 
                            IRepository<CartItem> repoCart, 
                            IRepository<OrderDetail> repoDetail, 
                            IRepository<HistoryStatus> repoHis,
                            IRepository<Address> repoAdd,
                            IRepository<Product> repoPro,
                            IMapper mapper)
        {
            _repoOrder = repoOrder;
            _repoCart = repoCart;
            _repoDetail = repoDetail;
            _repoHis = repoHis;
            _repoAdd = repoAdd;
            _repoPro = repoPro;
            _mapper = mapper;
        }

        public async Task<OrderDto?> Add(string customerId, OrderView view)
        {
            var address = await _repoAdd.ReadByCondition(o => o.CustomerId == customerId
                                                        && o.Id == view.AddressId).FirstOrDefaultAsync();
            if (address == null)
            {
                return null;
            }
            var order = new Order
            {
                CustomerId = customerId,
                isPaid = view.isPaid,
                Status = Status.New,
                Date = DateTime.Now,
                AddressId = view.AddressId
            };

            _repoOrder.Create(order);

            var cartItem = _repoCart.ReadByCondition(o => o.CustomerId == customerId).ToList();
            foreach (var item in cartItem)
            {
                if (!view.productIds.Contains(item.ProductId) ||
                    item.Quantity > _repoPro.ReadByCondition(e => e.Id == item.ProductId).FirstOrDefault()!.Quantity)
                    cartItem.Remove(item);
            }
                
            if (cartItem.Count() != view.productIds.Count())
                return null;

            // everything is fine
            _repoHis.Create(new HistoryStatus
            {
                Status = Status.New,
                OrderId = order.Id
            });

            foreach (var item in view.productIds)
            {
                var entityCart = _repoCart.ReadByCondition(o => o.CustomerId == customerId && o.ProductId == item).FirstOrDefault()!;
                var entityPro = _repoPro.ReadByCondition(o => o.Id == item).FirstOrDefault()!;
                _repoDetail.Create(new OrderDetail
                {
                    OrderId = order.Id,
                    Price = entityPro.Price,
                    PercentSale = entityPro.PercentSale,
                    ProductId = item,
                    Quantity = entityCart.Quantity
                });

                entityPro.Quantity -= entityCart.Quantity;
                _repoPro.Update(entityPro);
                _repoCart.Delete(entityCart);
            }
            _repoPro.Save();
            _repoOrder.Save();
            _repoHis.Save();
            _repoDetail.Save();
            _repoCart.Save();
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<List<OrderDto>> GetAll(string customerId)
        {
            var result = await _repoOrder.ReadByCondition(o => o.CustomerId == customerId).ToListAsync();
            return _mapper.Map<List<OrderDto>>(result);
        }
    }
}
