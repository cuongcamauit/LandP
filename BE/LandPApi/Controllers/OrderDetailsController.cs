using LandPApi.Dto;
using LandPApi.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        // GET: api/OrderDetails
        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult GetOrderDetails(Guid orderId)
        {
            object result = _orderDetailService.GetAll(orderId);
            return Ok(new Response
            {
                Success = true,
                Message = "Get all detail order",
                Data = result
            });
        }
    }
}
