using AutoMapper;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class CartItemService : ICartItemService
    {
        private readonly IRepository<CartItem> _repository;
        private readonly IMapper _mapper;

        public CartItemService(IRepository<CartItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddAsync(CartItem cartItem)
        {
            _repository.Create(cartItem);
            _repository.Save();
        }

        public CartItemView Add(string customerId, CartItemView cartItem)
        {
            var cart = 
                new CartItem { 
                    CustomerId = customerId, 
                    ProductId = cartItem.ProductId, 
                    Quantity = cartItem.Quantity 
                };
            _repository.Create(cart);
            _repository.Save();
            return cartItem;
        }

        public async Task DeleteAsync(string customerId, Guid productId)
        {
            var cartItem = await _repository.ReadByCondition(o => o.CustomerId == customerId && o.ProductId == productId)
                .FirstOrDefaultAsync(o => o.CustomerId == customerId && o.ProductId == productId);
            if (cartItem == null)
            {
                throw new Exception("Not found!");
            }
            _repository.Delete(cartItem);
            _repository.Save();

        }

        public async Task<List<CartItemView>> GetAllAsync(string customerId)
        {
            var cartItems = await _repository.ReadByCondition(o => o.CustomerId == customerId).ToListAsync();
            return _mapper.Map<List<CartItemView>>(cartItems);
        }

        public async Task<CartItemView> GetByIdAsync(string customerId, Guid productId)
        {
            var cartItem = await _repository.ReadByCondition(o => (o.CustomerId == customerId && o.ProductId == productId)).FirstOrDefaultAsync();
            return _mapper.Map<CartItemView>(cartItem);
        }

        public async Task UpdateAsync(CartItem cartItem)
        {
            _repository.Update(cartItem);
            _repository.Save();
        }
    }
}
