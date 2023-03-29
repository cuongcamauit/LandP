using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Net.WebSockets;
using LandPApi.Service;
using LandPApi.Dto;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;

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
                return Ok(new Response
                {
                    StatusCode = 404,
                    Success = false,
                    Message = "Brand not exists"
                });
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
        [Authorize(Roles = "Admin")]
        public IActionResult PutBrand(Guid id, BrandDto brand)
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
            if (id != brand.Id)
            {
                return BadRequest(new Response
                {
                    Success = false,
                    Message = "Id doesn't match"
                });
            }

            _brandService.Update(brand);

            return Ok(new Response
            {
                Message = "Updated successful!",
                Data = brand,
                Success = true
            });
        }

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostBrand(BrandView brand)
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
            BrandDto result = _brandService.Create(brand);

            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            await _brandService.Delete(id);

            return Ok(new Response
            {
                Message = "Deleted successful!"
            });
        }
    }
}
