using LandPApi.Models;

namespace LandPApi.IService
{
    public interface ICacheService
    {
        void AddProduct(Product entity);
        List<Product> GetProduct();
        List<Slug> GetSlugs();
        void UpdateProduct(Product entityPro);
    }
}
