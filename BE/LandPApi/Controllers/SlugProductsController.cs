using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlugProductsController : ControllerBase
    {
        private readonly ISlugProductService _slugProductSerive;

        public SlugProductsController(ISlugProductService slugProductService)
        {
            _slugProductSerive = slugProductService;
        }
        [HttpPost]
        public IActionResult Add(SlugProductView slugProductView)
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
            _slugProductSerive.Add(slugProductView);
            return Ok(new Response
            {
                StatusCode = 204,
                Message = "Add Product to slug successful!"
            });
        }

        [HttpDelete]
        public IActionResult Delete(SlugProductView slugProductView)
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
            _slugProductSerive.Remove(slugProductView);
            return Ok(new Response
            {
                Message = "Remove product from slug successful"
            });
        }
    }
}
