using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IProductPriceService
    {
        List<ProductPriceDto> GetProductPriceList(Guid id);
        ProductPriceDto Create(ProductPriceView productPriceView);
        bool CheckPriceExist(ProductPriceView productPriceView);
        void Delete(int id);
    }
}
