using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaculateOrdersController : ControllerBase
    {
        private readonly ICaculateOrderService _ship;

        
        public CaculateOrdersController(ICaculateOrderService ship)
        {
            _ship = ship;
        }
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetAsync(OrderView orderView)
        {
            return Ok(new Response
            {
                StatusCode = 200,
                Data = await _ship.GetFeeAsync(User.FindFirstValue(ClaimTypes.NameIdentifier), orderView),
                Message = "Fee for order"
            });
        }
    }
}
