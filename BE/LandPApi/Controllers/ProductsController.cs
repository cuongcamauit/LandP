using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;

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
        public async Task<IActionResult> GetProducts(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int page_size = 5)
        {

            var result = await _productService.GetAllAsync(search, from, to, sortBy, categoryId, brandId, page, page_size);
            return Ok(result);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _productService.GetByIdAsync(id, o => o.Brand!, o => o.Category!, o => o.Reviews!);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //// PUT: api/Products/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(Guid id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            await _productService.UpdateAsync(product);

            return NoContent();
        }

        //// POST: api/Products
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostProduct(Product product)
        {
            await _productService.AddAsync(product);
            
            return Ok(product);
        }

        //// DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
           await _productService.DeleteAsync(id);
            return NoContent();
        }

        
    }
}
