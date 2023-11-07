using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IAttributeOptionService _service;

        public OptionsController(IAttributeOptionService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get(int attributeId)
        {
            var options = _service.GetById(attributeId);
            return Ok(new Response
            {
                Message = "Get list option",
                Data = options,
            });
        }
        [HttpPost]
        public IActionResult Post(AttributeOptionView attributeOptionView)
        {
            _service.Create(attributeOptionView);
            return Ok(new Response
            {
                Message = "Create option successful"
            });
        }
    }
}
