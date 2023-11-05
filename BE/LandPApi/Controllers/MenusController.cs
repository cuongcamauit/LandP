using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenuService _service;

        public MenusController(IMenuService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var menus = _service.GetAll();
            return Ok(new Response
            {
                StatusCode = 200,
                Message = "Get menu",
                Data = menus,
            });
        }
        [HttpPost]
        public IActionResult Post(MenuView menuView)
        {
            _service.Create(menuView);
            return Ok(new Response
            {
                StatusCode = 204,
                Message = "Create Menu Successfull",
            });
        }
    }
}
