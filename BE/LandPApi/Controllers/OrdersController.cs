using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using Microsoft.AspNetCore.Authorization;
using LandPApi.View;
using LandPApi.Dto;
using System.Security.Claims;

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

        [HttpPost("PaypalCheckout/{orderId}")]
        [Authorize]
        public IActionResult PaypalCheckout(Guid orderId)
        {
            if (ModelState.IsValid)
            {
                var url = _orderService.PaypalCheckout(orderId);
                if (url != null)
                    return Redirect(url);
            }
            return Ok();
        }

        [HttpGet("CheckoutSuccess")]
        public IActionResult CheckoutSuccess()
        {
            return Redirect($"{_configuration["AppUrl"]}/checkoutsuccess.html");
        }

        [HttpGet("CheckoutFail")]
        public IActionResult CheckoutFail()
        {
            return Redirect($"{_configuration["AppUrl"]}/checkoutfail.html");
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
