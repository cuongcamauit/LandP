using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandPApi.Data;
using LandPApi.Models;
using LandPApi.IService;

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
        public async Task<IActionResult> GetOrders()
        {
            return Ok(await _orderService.GetAllAsync(o => o.Customer!, o => o.Address!, o => o.OrderDetails!, o => o.HistoryStatuses!)) ;
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var order = await _orderService.GetByIdAsync(id, o => o.Customer!, o => o.Address!, o => o.OrderDetails!, o => o.HistoryStatuses!);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(Guid id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }
            await _orderService.UpdateAsync(order);
          
            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostOrder(Order order)
        {
            await _orderService.AddAsync(order);

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            await _orderService.DeleteAsync(id);

            return NoContent();
        }
    }
}
