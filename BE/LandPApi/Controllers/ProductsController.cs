using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICacheService _cacheService;

        public ProductsController(IProductService productService, ICacheService cacheService)
        {
            _productService = productService;
            _cacheService = cacheService;
        }


        // GET: api/Products
        [HttpPost("search")]
        public IActionResult GetProducts(SearchInfor searchInfor)
        {
            var result = _productService.GetAllAsync(searchInfor);
            return Ok(new Response
            {
                Data = result,
                Message = "Get products successfully"
            });
        }

        // GET: api/Products/Foryou
        [HttpGet("Foryou")]
        [Authorize(Roles = "User")]
        public IActionResult GetForyou()
        {
            var result = _productService.GetForyou(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new Response
            {
                Success = true,
                Data = result,
                Message = "Product recommended for you!"
            });
        }


        // GET: api/Products/5
        [HttpGet("{id}")]
        public IActionResult GetProduct(Guid id)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return Ok(new Response
                {
                    StatusCode = 404,
                    Success = false,
                    Message = "Product doesn't exists"
                });
            }
            return Ok(new Response
            {
                Success = true,
                Data = product,
                Message = "Get a product"
            });
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult PutProduct(Guid id, ProductDto product)
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
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productService.Update(product);
            _cacheService.UpdateProduct(product.Id);


            return Ok(new Response
            {
                Message = "Updated successful!",
                Data = product,
                Success = true
            });
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostProduct(ProductView product)
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
            var result = _productService.Create(product);

            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _productService.Delete(id);
            _cacheService.UpdateProduct(id);

            return Ok(new Response
            {
                Message = "Deleted successful!"
            });
        }
    }
}
