using LandPApi.Base;
using LandPApi.Dto;
using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IProductService : IBaseRepository<Product>
    {
        Task<Response> GetAllAsync(string? search, double? from, double? to, string? sortBy, int page = 1, Guid? categoryId = null, Guid? brandId = null);
    }
}
