using LandPApi.Base;
using LandPApi.Models;
using System.Linq.Expressions;

namespace LandPApi.IService
{
    public interface ICartItemService
    {
        Task<ICollection<CartItem>> GetAllAsync(string customerId);
        Task AddAsync(CartItem cartItem);
        Task UpdateAsync(CartItem cartItem);
        Task DeleteAsync(string customerId, Guid productId);
    }
}
