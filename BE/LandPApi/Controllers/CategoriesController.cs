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
            return Ok(await _categoryService.GetAllAsync(o => o.Products!));
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            return Ok(await _categoryService.GetByIdAsync(id, o => o.Products!));
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

            return Ok(await _categoryService.UpdateAsync(category));
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            return CreatedAtAction("GetCategory", await _categoryService.AddAsync(category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            return Ok(await _categoryService.DeleteAsync(id));
        }

    }
}
