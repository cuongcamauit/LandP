using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeSpecsController : ControllerBase
    {
        private readonly IAttributeSpeccService _service;

        public AttributeSpecsController(IAttributeSpeccService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var specs = _service.GetById(id);
            return Ok(new Response
            {
                Data = specs
            });
        }
        [HttpPost]
        public IActionResult Post(AttributeSpecView attributeSpecView)
        {
            _service.Create(attributeSpecView);
            return Ok(new Response
            {

            });
        }
    }
}
