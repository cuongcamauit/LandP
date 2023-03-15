using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Net.WebSockets;
using LandPApi.Service;
using LandPApi.Dto;
using LandPApi.View;

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
            var result = await _brandService.GetAll();
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
            var brand = await _brandService.GetById(id);
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
        public IActionResult PutBrand(Guid id, BrandDto brand)
        {
            if (id != brand.Id)
            {
                return BadRequest(new Response
                {
                    Success = false,
                    Message = "Id doesn't match"
                });
            }

            _brandService.Update(brand);

            return NoContent();
        }

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostBrand(BrandView brand)
        {
            BrandDto result = _brandService.Create(brand);

            return CreatedAtAction("GetBrands", new { id = result.Id }, result);
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            await _brandService.Delete(id);
            return NoContent();
        }
    }
}
