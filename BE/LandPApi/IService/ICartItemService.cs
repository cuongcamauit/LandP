
using LandPApi.Models;
using LandPApi.View;
using System.Linq.Expressions;

namespace LandPApi.IService
{
    public interface ICartItemService
    {
        Task<List<CartItemView>> GetAllAsync(string customerId);
        Task<CartItemView> GetByIdAsync(string customerId, Guid productId);
        CartItemView Add(string customerId, CartItemView cartItem);
        void UpdateAsync(CartItem cartItem);
        Task DeleteAsync(string customerId, Guid productId);
    }
}
