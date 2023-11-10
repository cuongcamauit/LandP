using LandPApi.Models;

namespace LandPApi.IService
{
    public interface ICacheService
    {
        List<Product> GetProduct();
        List<Slug> GetSlugs();
    }
}
