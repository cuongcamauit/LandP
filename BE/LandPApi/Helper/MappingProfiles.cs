using AutoMapper;
using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<BrandView, Brand>();

            CreateMap<Category, CategoryDto>().ReverseMap();    
            CreateMap<CategoryView, Category>();

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressView, Address>();

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductView, Product>();

            CreateMap<CartItem, CartItemView>();

            CreateMap<Order, OrderDto>();

            CreateMap<OrderDetail, OrderDetailDto>();

            CreateMap<HistoryStatus, HistoryStatusDto>();

            CreateMap<Review, ReviewDto>();

            CreateMap<Customer, CustomerDto>();
        }
    }   
}
