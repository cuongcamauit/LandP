using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Drawing.Drawing2D;
using LandPApi.Dto;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryStatusController : ControllerBase
    {
        private readonly IHistoryStatusService _historyStatusService;

        public HistoryStatusController(IHistoryStatusService historyStatusService)
        {
            _historyStatusService = historyStatusService;
        }

        // GET: api/HistoryStatus
        [HttpGet]
        public async Task<IActionResult> GetHistoryStatuses(Guid orderId)
        {
            List<HistoryStatusDto> result = _historyStatusService.GetAll(orderId);
            return Ok(new Response
            {
                Success = true,
                Message = "Get all history status",
                Data = result
            });
        }
    }
}
