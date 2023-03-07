using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class CartItemService : ICartItemService
    {
        private readonly ApplicationDbContext _context;

        public CartItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(CartItem cartItem)
        {
            await _context.CartItems.AddAsync(cartItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string customerId, Guid productId)
        {
            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(o => o.CustomerId == customerId && o.ProductId == productId);
            if (cartItem == null)
            {
                throw new Exception("Not found!");
            }
            _context.Remove(cartItem);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartItem>> GetAllAsync(string customerId, Guid productId)
        {
            return _context.CartItems
                .Where(o => o.CustomerId == customerId && o.ProductId == productId);
        }

        public async Task UpdateAsync(CartItem cartItem)
        {
            _context.CartItems.Update(cartItem);
            await _context.SaveChangesAsync();
        }
    }
}
