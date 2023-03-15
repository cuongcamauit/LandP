using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IProductService : IGenericService<ProductView, ProductDto, Product>
    {
        object GetAllAsync(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int page_size = 5);
    }
}
