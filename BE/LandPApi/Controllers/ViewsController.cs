using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandPApi.Data;
using LandPApi.IService;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewsController : ControllerBase
    {
        private readonly IViewService _viewService;

        public ViewsController(IViewService viewService)
        {
            _viewService = viewService;
        }

        // GET: api/Views
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<View>>> GetViews()
        //{
        //  if (_context.Views == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Views.ToListAsync();
        //}

        // GET: api/Views/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<View>> GetView(string id)
        //{
        //  if (_context.Views == null)
        //  {
        //      return NotFound();
        //  }
        //    var view = await _context.Views.FindAsync(id);

        //    if (view == null)
        //    {
        //        return NotFound();
        //    }

        //    return view;
        //}

        // POST: api/Views
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostView(Guid productId)
        {
            _viewService.Create(User.FindFirstValue(ClaimTypes.NameIdentifier), productId);
            return NoContent();
        }
    }
}
