using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using LandPApi.Dto;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Security.Claims;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult GetProducts(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int pageSize = 5)
        {

            var result = _productService.GetAllAsync(search, from, to, sortBy, categoryId, brandId, page, pageSize);
            return Ok(new Response
            {
                Success = true,
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
                Data = result
            });
        }


        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult PutProduct(Guid id, ProductDto product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productService.Update(product);

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostProduct(ProductView product)
        {
            var result = _productService.Create(product);

            return CreatedAtAction("GetProducts", new { id = result.Id }, result);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _productService.Delete(id);
            return NoContent();
        }
    }
}
