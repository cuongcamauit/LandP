using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;
        private readonly ICacheService _cacheService;

        public CartItemsController(ICartItemService cartItemService, ICacheService cacheService)
        {
            _cartItemService = cartItemService;
            _cacheService = cacheService;
        }

        // GET: api/CartItems
        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetCartItems()
        {
            var result = await _cartItemService.GetAllAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(
                new Response
                {
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
                });
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "User")]
        public IActionResult PutCartItem(Guid id, CartItemView view)
        {
            if (!ModelState.IsValid || view.Quantity < 0)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = view.Quantity < 0 ? "Quantity can't less than 0" : message,
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
        public async Task<IActionResult> PostCartItem(CartItemView cartItem)
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
            var product = _cacheService.GetProduct().FirstOrDefault(o => o.Id == cartItem.ProductId);
            var quantity = product != null ? product.Quantity : 0;
            var check = await _cartItemService.GetByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), cartItem.ProductId);
            if ((check != null && quantity < check.Quantity + cartItem.Quantity) ||
                (check == null && quantity < cartItem.Quantity))
            {
                return Ok(new Response
                {
                    StatusCode = 422,
                    Message = "Quantity exeed"
                });
            }
            if (check != null)
            {
                var newCartItem = new CartItem
                {
                    CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    Quantity = check.Quantity + cartItem.Quantity,
                    ProductId = cartItem.ProductId
                };
                _cartItemService.UpdateAsync(newCartItem);
                return Ok(new Response
                {
                    StatusCode = 204,
                    Message = "Update quantity to cart successful!"
                });
            }


            CartItemView result = _cartItemService.Add(User.FindFirstValue(ClaimTypes.NameIdentifier), cartItem);

            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Add new product to cart successful!",
                Data = result
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
                Message = "Deleted successful!",
                Data = id
            });
        }
    }
}
