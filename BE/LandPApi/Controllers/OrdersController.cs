using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Drawing.Drawing2D;
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

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
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
        [Authorize]
        public async Task<IActionResult> PostOrder(OrderView order)
        {

            OrderDto result = await _orderService.Add(User.FindFirstValue(ClaimTypes.NameIdentifier), 
                                                     order);
            return Ok(result);
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
