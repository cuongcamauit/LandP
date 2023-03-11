using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class OrderDetailService : IOrderDetail
    {
        private readonly ApplicationDbContext _context;

        public OrderDetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(OrderDetail orderDetail)
        {
            await _context.AddAsync(orderDetail);
            await _context.SaveChangesAsync();
        }
    }
}
