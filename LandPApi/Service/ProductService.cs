using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class ProductService : BaseRepository<Product>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
