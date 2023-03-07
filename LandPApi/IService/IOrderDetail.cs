using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IOrderDetail 
    {
        Task AddAsync(OrderDetail orderDetail);
    }
}
