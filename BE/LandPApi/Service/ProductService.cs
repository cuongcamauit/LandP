using LandPApi.Base;
using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class ProductService : BaseRepository<Product>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }

        /*public async Task<Response> GetAll(string sortBy = "Name", int page = 1, Guid? categoryId, string? search, double? from, double? to,)
        {
            var products = _context.Products.AsQueryable();
            #region Filtering
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(o => o.Name!.Contains(search));
            }
            if (from.HasValue)
            {
                products = products.Where(o => o.Price >= from);
            }
            if (to.HasValue)
            {
                products = products.Where(o => o.Price <= to);
            }
            #endregion
        }*/
    }
}
