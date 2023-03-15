using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Drawing.Drawing2D;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly UserManager<Customer> _userManager;

        public OrdersController(IOrderService orderService, UserManager<Customer> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
        }

        // GET: api/Orders
        //[HttpGet]
        //public async Task<IActionResult> GetOrders()
        //{
        //    var result = await _orderService.GetAllAsync(o => o.Customer!, o => o.Address!, o => o.OrderDetails!, o => o.HistoryStatuses!);
        //    return Ok(result) ;
        //}

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
        //[HttpPost]
        //public async Task<IActionResult> PostOrder(Order order)
        //{
        //    //var user = await _userManager.GetUserAsync(User);
            
        //    await _orderService.AddAsync(order);

        //    return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        //}

        //// DELETE: api/Orders/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrder(Guid id)
        //{
        //    await _orderService.DeleteAsync(id);

        //    return NoContent();
        //}
    }
}
