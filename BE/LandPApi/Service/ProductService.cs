using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class ProductService : GenericService<ProductView, ProductDto, Product>, IProductService
    {
        private readonly IDriveService _driveService;
        private readonly IRepository<Models.View> _repoView;
        private readonly UserManager<Customer> _userManager;

        public ProductService(IRepository<Product> repository
                            , IRepository<Models.View> repoView 
                            , IMapper mapper
                            , UserManager<Customer> userManager
                            , IDriveService driveService) : base(repository, mapper)
        {
            _driveService = driveService;
            _repoView = repoView;
            _userManager = userManager;
        }
        public new ProductDto Create(ProductView view)
        {
            var entity = _mapper.Map<Product>(view);
            entity.FolderId = _driveService.AddFolder(view.Name!, "1gvWxcVd3JxyZ7v9FJhb1Pp5jJJyyGaKU");

            _repository.Create(entity);
            _repository.Save();

            return _mapper.Map<ProductDto>(entity);
        }
        public object GetAllAsync(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int pageSize = 5)
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
            var result = PaginatedList<Product>.Create(products, page, pageSize);

            return new
            {
                Success = true,
                Data =
                new {
                    products = _mapper.Map<List<ProductDto>>(result),
                    pagination = new
                    {
                        currentPage = result.PageIndex,
                        totalPage = result.TotalPage,
                        pageSize = pageSize,
                        totalItem = result.TotalItem
                    }
                }
            };
            #endregion
        }

        public object GetForyou(string userId, double rate = 50)
        {
            var listProduct = new HashSet<ProductDto>();   
            var categorys = new HashSet<Guid>();

            var getProductViewed = _repoView.ReadByCondition(o => o.CustomerId == userId).Select(o => o.ProductId).ToList();
            foreach (var item in getProductViewed)
            {
                var category = _repository.ReadByCondition(o => o.Id == item).FirstOrDefault()!.CategoryId;
                categorys.Add(category);

            }
            var getUserId = _userManager.Users.Where(o => o.Id != userId).Select(o => o.Id).ToList();

            foreach (var id in getUserId)
            {
                var views = _repoView.ReadByCondition(o => o.CustomerId == id).Select(o => o.ProductId);
                var together = getProductViewed.Concat(views);

                if (((double)together.Count())/getProductViewed.Count()>=(rate/100.0))
                {
                    var except = views.ToList().Except(getProductViewed);
                    foreach(var item in except)
                    {
                        var product = _repository.ReadByCondition(o => o.Id == item).FirstOrDefault();
                        if (categorys.Contains(product!.CategoryId))
                        {
                            listProduct.Add(_mapper.Map<ProductDto>(product!));
                        }
                    }
                }
            }

            return listProduct.ToList();
        }
    }
}
