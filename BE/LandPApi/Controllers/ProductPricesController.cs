using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Service;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPricesController : ControllerBase
    {
        private readonly IProductPriceService _productPriceService;

        public ProductPricesController(IProductPriceService productPriceService)
        {
            _productPriceService = productPriceService;
        }
        // GET: api/ProductPrices/5
        [HttpGet("{id}")]
        public IActionResult GetProductPrices(Guid id)
        {
            var product = _productPriceService.GetProductPriceList(id);
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
                Message = "Get prices"
            });
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostPrice(ProductPriceView productPriceView)
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
            if (_productPriceService.CheckPriceExist(productPriceView))
                return Ok(new Response
                {
                    StatusCode = 409,
                    Message = "Conflict price",
                    Success = false
                });
            ProductPriceDto result = _productPriceService.Create(productPriceView);

            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id) 
        {
            _productPriceService.Delete(id);
            return NoContent();
        }
    }
}
