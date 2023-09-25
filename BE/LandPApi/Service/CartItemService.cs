using AutoMapper;
using LandPApi.Data;
using LandPApi.Dto;
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

        public async Task<List<CartItemDto>> GetAllAsync(string customerId)
        {
            var cartItems = await _repository.ReadByCondition(o => o.CustomerId == customerId).Include(o => o.Product).Include(o => o.Product!.ProductPrices).ToListAsync();
            var cartItemDtos = new List<CartItemDto>();
            cartItems.ForEach((item) =>
            {
                cartItemDtos.Add(new CartItemDto()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Product = _mapper.Map<ProductDto>(item.Product)
                });
            });

            return cartItemDtos;
        }

        public async Task<CartItemView> GetByIdAsync(string customerId, Guid productId)
        {
            var cartItem = await _repository.ReadByCondition(o => (o.CustomerId == customerId && o.ProductId == productId)).FirstOrDefaultAsync();
            return _mapper.Map<CartItemView>(cartItem);
        }

        public void UpdateAsync(CartItem cartItem)
        {
            _repository.Update(cartItem);
            _repository.Save();
        }
    }
}
