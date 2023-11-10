using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IProductService : IGenericService<ProductView, ProductDto, Product>
    {
        ProductDto GetProduct(Guid id);
        object GetAllAsync(SearchInfor searchInfor);
        object GetForyou(string userId, double rate = 50);
    }
}
