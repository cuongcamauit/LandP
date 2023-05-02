using AutoMapper;
using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;
using System.Security.Cryptography;

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

            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.AverageRating, act => act.MapFrom(scr => (scr.Reviews!.Count==0)?0:
                                                                                 (scr.Reviews!.Sum(o => o.Rating) / scr.Reviews!.Count)))
                .ForMember(dest => dest.ReviewQuantity, act => act.MapFrom(scr => scr.Reviews!.Count))
                .ForMember(dest => dest.SoldQuantity, act => act.MapFrom(scr => scr.OrderDetails!.Sum(o => o.Quantity)))
                .ReverseMap();
            CreateMap<ProductView, Product>();

            CreateMap<CartItem, CartItemView>();
            CreateMap<CartItem, CartItemDto>();

            CreateMap<Order, OrderDto>();

            CreateMap<OrderDetail, OrderDetailDto>();

            CreateMap<HistoryStatus, HistoryStatusDto>();

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(scr => scr.Customer!.Name));

            CreateMap<Customer, CustomerDto>();
        }
    }   
}
