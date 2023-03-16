using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandPApi.Data;
using LandPApi.Models;
using LandPApi.IService;
using System.Security.Claims;
using LandPApi.Dto;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        public async Task<IActionResult> GetOrderDetails(Guid orderId)
        {
            List<OrderDetailDto> result = _orderDetailService.GetAll(orderId);
            return Ok(new Response
            {
                Success = true,
                Message = "Get all detail order",
                Data = result
            });
        }
    }
}
