using AutoMapper;
using Google.Apis.Logging;

using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using System.Drawing.Printing;
using System.Linq;

namespace LandPApi.Service
{
    public class ProductService : GenericService<ProductView, ProductDto, Product>, IProductService
    {
        public ProductService(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public object GetAllAsync(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int page_size = 5)
        {
            var products = _repository.ReadAll();
            #region Filtering
            if (categoryId != null)
            {
                products = products.Where(o => o.CategoryId == categoryId);
            }
            if (brandId != null)
            {
                products = products.Where(o => o.BrandId == brandId);
            }
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

            #region Sorting
            //Default sort by Name 
            products = products.OrderBy(o => o.Name);

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "Name-": products = products.OrderByDescending(o => o.Name); break;
                    case "Price": products = products.OrderBy(o => o.Price); break;
                    case "Price-": products = products.OrderByDescending(o => o.Price); break;
                    case "View": products = products.OrderByDescending(o => o.Views!.Count); break;
                    case "Sale": products = products.OrderByDescending(o => o.OrderDetails!.Sum(o => o.Quantity)); break;
                }
            }
            #endregion

            #region Paginate
            var result = PaginatedList<Product>.Create(products, page, page_size);

            return new
            {
                Success = true,
                Data =
                new {
                    products = result,
                    pagination = new
                    {
                        current_page = result.PageIndex,
                        total_page = result.TotalPage,
                        page_size
                    }
                }
            };
            #endregion
        }
    }
}
