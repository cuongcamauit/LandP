using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlugsController : ControllerBase
    {
        private readonly ISlugService _slugService;
        private readonly IMapper _mapper;

        public SlugsController(ISlugService slugService, IMapper mapper)
        {
            _slugService = slugService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var listSlugDto = _slugService.GetAll();
            return Ok(new Response
            {
                Success = true,
                StatusCode = 200,
                Data = listSlugDto.Select(o => new
                {
                    id = o.Id,
                    title = o.Title,
                    products = _mapper.Map<List<ProductDto>>(o.Products)
                })
            });
        }
        [HttpPost]
        public IActionResult Add(SlugView slugView)
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
            _slugService.Add(slugView);
            return Ok(new Response
            {
                Success = true,
                StatusCode = 204,
                Message = "Create slug successful!"
            });
        }
    }
}
