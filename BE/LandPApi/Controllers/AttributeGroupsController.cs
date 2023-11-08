using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeGroupsController : ControllerBase
    {
        private readonly IAttributeGroupService _service;

        public AttributeGroupsController(IAttributeGroupService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Post(AttributeGroupView view)
        {
            _service.Create(view);
            return Ok(new Response
            {
                Message = "Add group attribute successful"
            });
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var attributegroup = _service.GetById(id);
            return Ok(new Response
            {
                Message = "Get attribute by id's category",
                Data = attributegroup
            });
        }
    }
}
