using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Net.WebSockets;
using LandPApi.Service;
using LandPApi.Dto;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET: api/Brands
        [HttpGet]
        public async Task<IActionResult> GetBrands()
        {
            var result = await _brandService.GetAllAsync(o => o.Products!);
            return Ok(new Response
            {
                Success = true,
                Message = "Get all brands",
                Data = result,
            });
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(Guid id)
        {
            var brand = await _brandService.GetByIdAsync(id, o => o.Products!);
            if (brand == null)
            {
                return NotFound();
            }

            return Ok(new Response
            {
                Success = true,
                Message = "Got a brand successfully",
                Data = brand
            });
        }

        // PUT: api/Brands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(Guid id, Brand brand)
        {
            if (id != brand.Id)
            {
                return BadRequest(new Response
                {
                    Success = false,
                    Message = "Id doesn't match"
                });
            }

            await _brandService.UpdateAsync(brand);

            return NoContent();
        }

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostBrand(Brand brand)
        {
            await _brandService.AddAsync(brand);
           
            return CreatedAtAction("GetBrand", new { id = brand.Id }, brand);
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            await _brandService.DeleteAsync(id);
            return NoContent();
        }
    }
}
