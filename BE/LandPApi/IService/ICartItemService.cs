using LandPApi.Base;
using LandPApi.Models;
using System.Linq.Expressions;

namespace LandPApi.IService
{
    public interface ICartItemService
    {
        IEnumerable<CartItem> GetAllAsync(string customerId, Guid productId);
        Task AddAsync(CartItem cartItem);
        Task UpdateAsync(CartItem cartItem);
        Task DeleteAsync(string customerId, Guid productId);
    }
}
