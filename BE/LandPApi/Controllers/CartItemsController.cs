using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        // GET: api/CartItems
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetCartItems()
        {
            var result = await _cartItemService.GetAllAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(
                new Response {
                    Success = true,
                    Message = "Get all current user's cart item",
                    Data = result 
            });
        }

        // GET: api/CartItems/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CartItem>> GetCartItem(string id)
        //{
        //    var cartItem = await _context.CartItems.FindAsync(id);

        //    if (cartItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return cartItem;
        //}

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutCartItem(Guid id, int soluong)
        {
            var cartItem = new CartItem
            {
                CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Quantity = soluong,
                ProductId = id
            };
            await _cartItemService.UpdateAsync(cartItem);
            return NoContent();
        }

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CartItem>> PostCartItem(CartItem cartItem)
        {
            await _cartItemService.AddAsync(cartItem);

            return CreatedAtAction("GetCartItem", new { id = cartItem.CustomerId }, cartItem);
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCartItem(Guid id)
        {
            await _cartItemService.DeleteAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

            return NoContent();
        }


    }
}
