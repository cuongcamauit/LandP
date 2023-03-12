using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
