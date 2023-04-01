using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.View;
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
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetCartItems()
        {
            var result = await _cartItemService.GetAllAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(
                new Response {
                    Success = true,
                    Message = "Get all current user's cart items",
                    Data = result 
            });
        }

        // GET: api/CartItems/5
        [HttpGet("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetCartItem(Guid id)
        {
            var cartItem = await _cartItemService.GetByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

            if (cartItem == null)
            {
                return Ok(new Response
                {
                    StatusCode = 404,
                    Success = false,
                    Message = "Cartitem not exists"
                });
            }

            return Ok(
                new Response
                {
                    Success = true,
                    Message = "Get an user's cart item",
                    Data = cartItem
                }) ;
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "User")]
        public IActionResult PutCartItem(Guid id, CartItemView view)
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
            if (id != view.ProductId)
                return Ok(new
                {
                    Success = false,
                    Message = "Id doesn't match with id's cartitem",
                    StatusCode = 400
                });
            var cartItem = new CartItem
            {
                CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Quantity = view.Quantity,
                ProductId = view.ProductId
            };
            _cartItemService.UpdateAsync(cartItem);

            return Ok(new Response
            {
                Message = "Updated successful!",
                Data = view,
                Success = true
            });
        }

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostCartItem(CartItemView cartItem)
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
            CartItemView result = _cartItemService.Add(User.FindFirstValue(ClaimTypes.NameIdentifier), cartItem);

            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Created cartitem successful!",
                Data = cartItem
            });
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteCartItem(Guid id)
        {
            await _cartItemService.DeleteAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), id);

            return Ok(new Response
            {
                Message = "Deleted successful!"
            });
        }


    }
}
