using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace LandPApi.Service
{
    public class CacheService : ICacheService
    {
        static String ProductKey = "Product";
        static String SlugKey = "Slug";
        private readonly IMemoryCache _cache;
        private readonly IRepository<Product> _repoPro;
        private readonly IRepository<Slug> _repoSlug;

        public CacheService(IMemoryCache cache, IRepository<Product> repoPro, IRepository<Slug> repoSlug)
        {
            _cache = cache;
            _repoPro = repoPro;
            _repoSlug = repoSlug;
        }

        public void AddProduct(Product entity)
        {
            var product = _repoPro.ReadByCondition(o => o.Id == entity.Id)
                    .Include(o => o.Reviews)
                    .Include(o => o.OrderDetails)
                    .Include(o => o.ProductPrices)
                    .Include(o => o.AttributeSpecs)
                    .FirstOrDefault();
            var products = GetProduct();
            products.Add(product!);
            _cache.Set(ProductKey, products);
        }

        public List<Product> GetProduct()
        {
            if (!_cache.TryGetValue(ProductKey, out List<Product>? products))
            {
                products = _repoPro.ReadByCondition(o => o.IsDeleted == false)
                                .Include(o => o.Reviews)
                                .Include(o => o.OrderDetails)
                                .Include(o => o.ProductPrices)
                                .Include(o => o.AttributeSpecs)
                                .ToList();
                _cache.Set(ProductKey, products);
            }

            return products!;
        }

        public List<Slug> GetSlugs()
        {
            if (!_cache.TryGetValue(SlugKey, out List<Slug>? slugs))
            {
                slugs = _repoSlug.ReadByCondition(o => o.IsDeleted == false)
                                .Include(o => o.SlugProducts)!
                                    .ThenInclude(o => o.Product)

                                .Include(o => o.SlugProducts)!
                                    .ThenInclude(o => o.Product)
                                    .ThenInclude(o => o!.OrderDetails)
                                .Include(o => o.SlugProducts)!
                                    .ThenInclude(o => o.Product)
                                    .ThenInclude(o => o!.Reviews)
                                .Include(o => o.SlugProducts)!
                                    .ThenInclude(o => o.Product)
                                    .ThenInclude(o => o!.ProductPrices)

                                .Include(o => o.SlugProducts)!
                                    .ThenInclude(o => o.Product)
                                    .ThenInclude(o => o!.AttributeSpecs)
                                 .ToList();
                _cache.Set(SlugKey, slugs);
            }
            return slugs!;
        }

        public void UpdateProduct(Product entityPro)
        {
            var products = GetProduct();
            var temp = products.FirstOrDefault(o => o.Id == entityPro.Id);
            temp!.Name = entityPro.Name;
            temp.IsDeleted = entityPro.IsDeleted;
            temp.Description = entityPro.Description;
            temp.Price = entityPro.Price;
            temp.Quantity = entityPro.Quantity;
            products.Remove(products.FirstOrDefault(o => o.Id == entityPro.Id)!);
            products.Add(temp);
            _cache.Set(ProductKey, products);
        }
    }
}
