using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using LandPApi.Service;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _categoryService.GetAllAsync(o => o.Products!);
            return Ok(result);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id, o => o.Products!);
            return Ok(result);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(Guid id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }
            var result = await _categoryService.UpdateAsync(category);
            return Ok(result);
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostCategory(Category category)
        {
            var result = await _categoryService.AddAsync(category);

            return Ok(result);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }

    }
}
