using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;
using LandPApi.View;
using System.Security.Claims;

namespace LandPApi.IService
{
    public interface IOrderService
    {
        Task<OrderDto?> Add(string customerId, OrderView view);
        Task<List<OrderDto>> GetAll(string customerId);
        void Update(ClaimsPrincipal user, Guid orderId, Status status, bool isPaid);
    }
}
