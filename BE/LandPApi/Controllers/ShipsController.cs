using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipsController : ControllerBase
    {
        private readonly IShipService _ship;

        
        public ShipsController(IShipService ship)
        {
            _ship = ship;
        }
        [HttpPost]
        public IActionResult Get(OrderView orderView)
        {
            return Ok(new Response
            {
                StatusCode = 200,
                Data = _ship.GetFee(orderView),
                Message = "Fee for order"
            });
        }
    }
}
