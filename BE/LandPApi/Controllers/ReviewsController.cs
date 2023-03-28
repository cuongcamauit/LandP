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
using LandPApi.Dto;
using LandPApi.View;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        // GET: api/Reviews
        // get all review of a product
        [HttpGet]
        public IActionResult GetReviews(Guid productId, int page = 1, int pageSize = 5)
        {
            var result = _reviewService.GetAll(productId, page, pageSize);
            return Ok(new Response
            {
                Data = result,
                Message = "Get all review of product"
            });
        }

        // GET: api/Reviews/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Review>> GetReview(string id)
        //{
        //    var review = await _context.Reviews.FindAsync(id);

        //    if (review == null)
        //    {
        //        return NotFound();
        //    }

        //    return review;
        //}

        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutReview(string id, Review review)
        //{
        //    if (id != review.CustomerId)
        //    {
        //        return BadRequest();
        //    }

        //    return NoContent();
        //}

        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostReview(ReviewView review)
        {
            var result = _reviewService.Create(User.FindFirstValue(ClaimTypes.NameIdentifier), review);

            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }

        // DELETE: api/Reviews/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteReview(string id)
        //{
        //    var review = await _context.Reviews.FindAsync(id);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Reviews.Remove(review);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ReviewExists(string id)
        //{
        //    return _context.Reviews.Any(e => e.CustomerId == id);
        //}
    }
}
