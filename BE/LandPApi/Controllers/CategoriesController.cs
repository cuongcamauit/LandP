using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using LandPApi.Service;
using System.Drawing.Drawing2D;
using LandPApi.Dto;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using System.Data;

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
            List<CategoryDto> result = await _categoryService.GetAll();
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
            CategoryDto result = await _categoryService.GetById(id);
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult PutCategory(Guid id, CategoryDto category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }
            _categoryService.Update(category);
            return NoContent();
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostCategory(CategoryView category)
        {
            CategoryDto dto = _categoryService.Create(category);

            return CreatedAtAction("GetCategory", new { id = dto.Id }, dto);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await _categoryService.Delete(id);
            return NoContent();
        }

    }
}
