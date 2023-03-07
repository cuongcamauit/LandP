using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class OrderService : BaseRepository<Order>, IOrderService
    {
        public OrderService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
