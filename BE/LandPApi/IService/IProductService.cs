using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;
using LandPApi.View;
using System.Security.Claims;

namespace LandPApi.IService
{
    public interface IProductService : IGenericService<ProductView, ProductDto, Product>
    {
        object GetAllAsync(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int pageSize = 5);
        object GetForyou(string userId);
    }
}
