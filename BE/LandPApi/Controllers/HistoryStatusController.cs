using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;

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
        public async Task<IActionResult> GetHistoryStatuses()
        {
            return Ok(await _historyStatusService.GetAllAsync(o => o.Order!));
        }

        // GET: api/HistoryStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoryStatus(Guid id)
        {
            return Ok(await _historyStatusService.GetByIdAsync(id, o => o.Order!));
        }

        // PUT: api/HistoryStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoryStatus(Guid id, HistoryStatus historyStatus)
        {
            if (id != historyStatus.Id)
            {
                return BadRequest();
            }

            ;

            return Ok(await _historyStatusService.UpdateAsync(historyStatus));
        }

        // POST: api/HistoryStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostHistoryStatus(HistoryStatus historyStatus)
        {
            return CreatedAtAction("GetHistoryStatus", await _historyStatusService.AddAsync(historyStatus));
        }

        // DELETE: api/HistoryStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoryStatus(Guid id)
        {
            return Ok(await _historyStatusService.DeleteAsync(id));
        }
    }
}
