using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using LandPApi.Service;
using System.Drawing.Drawing2D;
using LandPApi.Dto;

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
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id, o => o.Products!);
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
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
            await _categoryService.UpdateAsync(category);
            return NoContent();
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostCategory(Category category)
        {
            await _categoryService.AddAsync(category);

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
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
