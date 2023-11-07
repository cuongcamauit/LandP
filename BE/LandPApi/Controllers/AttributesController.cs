using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly IAttributeService _service;

        public AttributesController(IAttributeService attributeService)
        {
            _service = attributeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var attributes = _service.GetAll();
            return Ok(new Response
            {
                Data = attributes
            });
        }
        [HttpPost]
        public IActionResult Post(AttributeView attribute)
        {
            _service.Create(attribute);
            return Ok(new Response
            {
                StatusCode = 204,
                Message = "Create Attribute successful"
            });
        }
    }
}
