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


            CreateMap<AttributeView, Models.Attribute>();
            CreateMap<Models.Attribute, AttributeDto>();

            CreateMap<AttributeGroupView, AttributeGroup>();
            CreateMap<AttributeGroup, AttributeGroupDto>();

            CreateMap<AttributeOption, AttributeOptionView>().ReverseMap();

            CreateMap<AttributeSpecView, AttributeSpec>();
            CreateMap<AttributeSpec, AttributeSpecDto>();

            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.AverageRating, act => act.MapFrom(scr => (scr.Reviews!.Count == 0) ? 0 :
                                                                                 (scr.Reviews!.Sum(o => o.Rating) * 1.0 / scr.Reviews!.Count * 1.0)))
                .ForMember(dest => dest.ReviewQuantity, act => act.MapFrom(scr => scr.Reviews!.Count))
                .ForMember(dest => dest.SoldQuantity, act => act.MapFrom(scr => scr.OrderDetails!.Sum(o => o.Quantity)))
                .ForMember(dest => dest.Price, act => act.MapFrom(scr => scr.GetNowPrice(null)))
                .ForMember(dest => dest.BasePrice, act => act.MapFrom(scr => scr.Price))
                .ForMember(dest => dest.PercentSale, act => act.MapFrom(scr => (scr.Price - scr.GetNowPrice(null)) * 100 / scr.Price))
                .ForMember(dest => dest.ReviewQuantity, act => act.MapFrom(scr => scr.Reviews!.Count))
               ;
            CreateMap<ProductView, Product>();

            CreateMap<ProductPrice, ProductPriceDto>()
                .ReverseMap();
            CreateMap<ProductPriceView, ProductPrice>();

            CreateMap<CartItem, CartItemView>();
            CreateMap<CartItem, CartItemDto>();

            CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.Total, act => act.MapFrom(scr => scr.Total()));

            CreateMap<OrderDetail, OrderDetailDto>();

            CreateMap<HistoryStatus, HistoryStatusDto>();

            CreateMap<MenuView, Menu>();
            CreateMap<Menu, MenuDto>()
                .ForMember(dest => dest.SlugName, act => act.MapFrom(scr => scr.Slug.Title));

            CreateMap<SlugView, Slug>();
            CreateMap<Slug, SlugDto>()
                .ForMember(dest => dest.Products, act => act.MapFrom(scr => scr.GetProducts()));

            CreateMap<SlugProductView, SlugProduct>();

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(scr => scr.Customer!.Name));

            CreateMap<Customer, CustomerDto>();
        }
    }
}
