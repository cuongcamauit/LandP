using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using Microsoft.AspNetCore.Authorization;
using LandPApi.View;
using LandPApi.Dto;
using System.Security.Claims;
using System.Security.Policy;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IConfiguration _configuration;
        public OrdersController(IOrderService orderService, IConfiguration configuration)
        {
            _orderService = orderService;
            _configuration = configuration;
        }   

        // GET: api/Orders
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetOrders()
        {
            List<OrderDto> result = await _orderService.GetAll(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new Response
            {
                Success = true,
                Message = "Get all order of current user",
                Data = result
            });
        }


        // GET: api/Orders
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetOrderById(Guid id)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            OrderDto result = await _orderService.GetById(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

            if (result == null)
            {
                return Ok(new Response
                {
                    Success = false,
                    StatusCode = 404,
                    Message = "Not found",
                });
            }
            return Ok(new Response
            {
                Success = true,
                StatusCode = 200,
                Message = "Get all order of current user",
                Data = result
            });
        }

        //// GET: api/Orders/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetOrder(Guid id)
        //{
        //    var order = await _orderService.GetByIdAsync(id, o => o.Customer!, o => o.Address!, o => o.OrderDetails!, o => o.HistoryStatuses!);

        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(order);
        //}

        //// PUT: api/Orders/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOrder(Guid id, Order order)
        //{
        //    if (id != order.Id)
        //    {
        //        return BadRequest();
        //    }
        //    await _orderService.UpdateAsync(order);

        //    return NoContent();
        //}

        //// POST: api/Orders
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> PostOrder(OrderView order)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            OrderDto? result = await _orderService.Add(User.FindFirstValue(ClaimTypes.NameIdentifier), 
                                                     order);
            if (result == null)
            {
                return Ok(new Response 
                { 
                    StatusCode = 400,
                    Message = "No item in cart!",
                    Success = false
                });
            }
            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }

        [HttpPut]
        [Authorize]
        public IActionResult PutOrder(Guid orderId, Status status, bool isPaid)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            _orderService.Update(User, orderId, status, isPaid);
            return Ok(new Response
            {
                Message = "Updated successful!",
                Success = true
            });
        }

        [HttpGet("Checkout/{orderId}")]
        public IActionResult PaypalCheckout(Guid orderId, string? opt = "PayPal")
        {
            if (ModelState.IsValid)
            {
                string link = "";
                switch (opt)
                {
                    case "PayPal":
                        link = _orderService.PaypalCheckout(orderId);
                        break;
                    case "VNPay":
                        link = _orderService.VNPayCheckOut(orderId);
                        break;
                    default:
                        break;
                }
                return Ok(new Response
                {
                    StatusCode = 202,
                    Data = link
                });
            }
            var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
            return Ok(new Response
            {
                Success = false,
                Message = "Some properties is wrong",
                Data = message,
                StatusCode = 422
            });
        }
        [HttpGet("VNPaySuccess")]
        //? vnp_Amount = 5628590100 & vnp_BankCode = NCB & vnp_BankTranNo = VNP14130324 & vnp_CardType = ATM & vnp_OrderInfo = Thanh + toan + don + hang % 3A+23df699f-de87-4ba3-9410-08dbbd9a3fbe&vnp_PayDate=20231002104910&vnp_ResponseCode=00&vnp_TmnCode=U5O11J3C&vnp_TransactionNo=14130324&vnp_TransactionStatus=00&vnp_TxnRef=23df699f-de87-4ba3-9410-08dbbd9a3fbe&vnp_SecureHash=66bc018b6e9be477acae12ba712288f0c83a6595e9c23dad8e490566cd465c51029eb39687366e430055459133e6e44c7774e30a64f0eb97550a39ba362b6b36
        public IActionResult VNPaySuccess(long vnp_Amount, string vnp_BankCode, string vnp_BankTranNo, string vnp_CardType, string vnp_OrderInfo, string vnp_PayDate, string vnp_ResponseCode, string vnp_TmnCode, int vnp_TransactionNo, string vnp_TransactionStatus, string vnp_TxnRef, string vnp_SecureHash)
        {
            if (_orderService.checkSum(vnp_Amount, vnp_BankCode, vnp_BankTranNo, vnp_CardType, vnp_OrderInfo, vnp_PayDate, vnp_ResponseCode, vnp_TmnCode, vnp_TransactionNo, vnp_TransactionStatus, vnp_TxnRef, vnp_SecureHash))
            {
                Guid orderId = Guid.Parse(vnp_TxnRef);
                _orderService.isPaid(orderId);
            }
            return Content("<script>window.close();</script>", "text/html");
        } 
        [HttpGet("PaypalSuccess")]
        public IActionResult CheckoutSuccess(string paymentid, string token)
        {
            Guid orderId = _orderService.confirm(paymentid);
            if (orderId != Guid.Empty)
            {
                // xu ly thanh true
                _orderService.isPaid(orderId);
            }

            return Content("<script>window.close();</script>", "text/html");
            //return Redirect($"{_configuration["UIUrl"]}/order/orderId");
        }

        [HttpGet("PaypalFail")]
        public IActionResult CheckoutFail()
        {
            return Content("<script>window.close();</script>", "text/html");
            //return Redirect($"{_configuration["UIUrl"]}/order/orderId");
        }

        //// DELETE: api/Orders/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrder(Guid id)
        //{
        //    await _orderService.DeleteAsync(id);

        //    return NoContent();
        //}
    }
}
