﻿using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Drawing.Drawing2D;

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

        //// GET: api/HistoryStatus
        //[HttpGet]
        //public async Task<IActionResult> GetHistoryStatuses()
        //{
        //    var result = await _historyStatusService.GetAllAsync(o => o.Order!);
        //    return Ok(result);
        //}

        //// GET: api/HistoryStatus/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetHistoryStatus(Guid id)
        //{
        //    var result = await _historyStatusService.GetByIdAsync(id, o => o.Order!);
        //    return Ok(result);
        //}

        //// PUT: api/HistoryStatus/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHistoryStatus(Guid id, HistoryStatus historyStatus)
        //{
        //    if (id != historyStatus.Id)
        //    {
        //        return BadRequest();
        //    }

        //    ;
        //    await _historyStatusService.UpdateAsync(historyStatus);
        //    return NoContent();
        //}

        //// POST: api/HistoryStatus
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<IActionResult> PostHistoryStatus(HistoryStatus historyStatus)
        //{
        //    await _historyStatusService.AddAsync(historyStatus);
        //    return CreatedAtAction("GetHistoryStatus", new { id = historyStatus.Id }, historyStatus);
        //}

        //// DELETE: api/HistoryStatus/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteHistoryStatus(Guid id)
        //{
        //    await _historyStatusService.DeleteAsync(id);
        //    return NoContent();
        //}
    }
}
