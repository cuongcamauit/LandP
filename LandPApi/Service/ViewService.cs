using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class ViewService : IViewService
    {
        private readonly ApplicationDbContext _context;

        public ViewService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(View view)
        {
            await _context.AddAsync(view);
            await _context.SaveChangesAsync();
        }
    }
}
