using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class OrderService : BaseRepository<Order>, IOrderService
    {
        public OrderService(ApplicationDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Order order, List<Guid> productIds)
        {
            
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
    }
}
