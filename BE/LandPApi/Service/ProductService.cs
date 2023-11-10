using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Attribute = LandPApi.Models.Attribute;

namespace LandPApi.Service
{
    public class ProductService : GenericService<ProductView, ProductDto, Product>, IProductService
    {
        private readonly IDriveService _driveService;
        private readonly IRepository<Models.View> _repoView;
        private readonly IRepository<AttributeOption> _repoOption;
        private readonly IRepository<Attribute> _repoAttribute;
        private readonly UserManager<Customer> _userManager;
        private readonly IMemoryCache _cache;
        private readonly ISlugService _slugService;
        public static readonly string ProductCacheKey = "products";
        public static readonly string SlugCacheKey = "slugs";

        public ProductService(IRepository<Product> repository
                            , IRepository<Models.View> repoView
                            , IRepository<Attribute> repoAttribute
                            , IRepository<AttributeOption> repoOption
                            , IMapper mapper
                            , UserManager<Customer> userManager
                            , IDriveService driveService
                            , IMemoryCache cache
                            , ISlugService slugService) : base(repository, mapper)
        {
            _driveService = driveService;
            _repoView = repoView;
            _repoOption = repoOption;
            _repoAttribute = repoAttribute;
            _userManager = userManager;
            _cache = cache;
            _slugService = slugService;
        }
        public new ProductDto Create(ProductView view)
        {
            var entity = _mapper.Map<Product>(view);
            entity.FolderId = _driveService.AddFolder(view.Name!, "1gvWxcVd3JxyZ7v9FJhb1Pp5jJJyyGaKU");

            _repository.Create(entity);
            _repository.Save();

            return _mapper.Map<ProductDto>(entity);
        }
        //public object GetAllAsync(string? search, double? from, double? to, string? sortBy, Guid? categoryId = null, Guid? brandId = null, int page = 1, int pageSize = 5)
        //{
        //    var products = _repository.ReadAll();
        //    #region Filtering
        //    if (categoryId != null)
        //    {
        //        products = products.Where(o => o.CategoryId == categoryId);
        //    }
        //    if (brandId != null)
        //    {
        //        products = products.Where(o => o.BrandId == brandId);
        //    }
        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        products = products.Where(o => o.Name!.Contains(search));
        //    }
        //    if (from.HasValue)
        //    {
        //        products = products.Where(o => o.Price >= from);
        //    }
        //    if (to.HasValue)
        //    {
        //        products = products.Where(o => o.Price <= to);
        //    }
        //    #endregion

        //    #region Sorting
        //    //Default sort by Name 
        //    products = products.OrderBy(o => o.Name);

        //    if (!string.IsNullOrEmpty(sortBy))
        //    {
        //        switch (sortBy)
        //        {
        //            case "Name-": products = products.OrderByDescending(o => o.Name); break;
        //            case "Price": products = products.OrderBy(o => o.Price /*TODO */); break;
        //            case "Price-": products = products.OrderByDescending(o => o.Price  /*TODO */); break;
        //            case "View": products = products.OrderByDescending(o => o.Views!.Count); break;
        //            case "BestSale": products = products.OrderByDescending(o => o.OrderDetails!.Sum(o => o.Quantity)); break;
        //        }
        //    }
        //    #endregion

        //    #region Paginate
        //    products = products.Include(o => o.Reviews).Include(o => o.OrderDetails).Include(o => o.ProductPrices);

        //    var result = PaginatedList<Product>.Create(products, page, pageSize);

        //    return
        //        new
        //        {
        //            products = _mapper.Map<List<ProductDto>>(result),
        //            pagination = new
        //            {
        //                currentPage = result.PageIndex,
        //                totalPage = result.TotalPage,
        //                pageSize = pageSize,
        //                totalItem = result.TotalItem
        //            }
        //        };
        //    #endregion
        //}

        public object GetAllAsync(SearchInfor searchInfor)
        {
            var products = GetCache();
            var slugs = GetSlugCache();

            SlugDto? slug = null;
            var check = true;
            if ((searchInfor.Slug != "" && slugs.SingleOrDefault(o => o.Id == searchInfor.Slug) != null) ||
                (searchInfor.Query != "" && slugs.SingleOrDefault(o => o.Id == searchInfor.Query) != null))
            {
                check = false;
                slug = slugs.SingleOrDefault(o => o.Id == searchInfor.Slug || o.Id == searchInfor.Query)!;
                products = slug.Products!.ToList();
            }

            #region Searching
            if (searchInfor.Query != "" && check)
            {
                products = products!.Where(o => o.Name!.Contains(searchInfor.Query)).ToList();
            }
            #endregion
            #region Filtering
            if (searchInfor.Filter != null)
            {
                // attributes
                if (searchInfor.Filter.Attributes != null && searchInfor.Filter.Attributes.Count > 0)
                {
                    products = filtered(products, searchInfor.Filter.Attributes);
                }
                // brands
                if (searchInfor.Filter.Brands != null && searchInfor.Filter.Brands.Count > 0)
                {
                    products = products!.Where(o => searchInfor.Filter.Brands.Any(p => p == o.BrandId)).ToList();
                }
                // categories
                if (searchInfor.Filter.Categories != null && searchInfor.Filter.Categories.Count > 0)
                {
                    products = products!.Where(o => searchInfor.Filter.Categories.Any(p => p == o.CategoryId)).ToList();
                }
                // price
                if (searchInfor.Filter.PriceGte > 0)
                {
                    products = products!.Where(o => _mapper.Map<ProductDto>(o).Price >= searchInfor.Filter.PriceGte).ToList();
                }
                if (searchInfor.Filter.PriceLte > 0)
                {
                    products = products!.Where(o => _mapper.Map<ProductDto>(o).Price <= searchInfor.Filter.PriceLte).ToList();
                }
            }
            #endregion
            #region Sorting
            if (searchInfor.Sorting != null)
            {
                //SORT_BY_DISCOUNT_PERCENT, SORT_BY_PUBLISH_AT, SORT_BY_TOP_SALE_QUANTITy_7_DAY

                switch (searchInfor.Sorting.Sort)
                {
                    case "SORT_BY_PRICE":
                        products = products!.OrderBy(o => _mapper.Map<ProductDto>(o).Price).ToList();
                        break;
                    case "SORT_BY_DISCOUNT_PERCENT":
                        products = products!.OrderBy(o => _mapper.Map<ProductDto>(o).PercentSale).ToList();
                        break;
                    case "SORT_BY_TOP_SALE":
                        products = products!.OrderBy(o => _mapper.Map<ProductDto>(o).SoldQuantity).ToList();
                        break;
                    default:
                        break;
                }
                switch (searchInfor.Sorting.Order)
                {
                    case "ORDER_BY_DESCENDING":
                        products!.Reverse();
                        break;
                    default:
                        break;
                }
            }
            #endregion
            #region Paginate

            var result = PaginatedList<Product>.Create(products!, searchInfor.Pagination!.PageNumber, searchInfor.Pagination.ItemsPerPage);

            #endregion
            var filterlist = getFilter(result);
            var maxPrice = getMaxPrice(products);

            return new
            {
                products = _mapper.Map<List<ProductDto>>(result),
                maxprice = maxPrice,
                filterable = filterlist,
                slugName = slug == null ? "" : slug.Title,
                slug = slug == null ? "" : slug.Id,
                pagination = new
                {
                    currentPage = result.PageIndex,
                    totalPage = result.TotalPage,
                    pageSize = searchInfor.Pagination.ItemsPerPage,
                    totalItem = result.TotalItem
                },
            };
        }

        private object getMaxPrice(List<Product> products)
        {
            if (products.Count == 0)
                return 0;
            var maxprice = _mapper.Map<List<ProductDto>>(products).MaxBy(o => o.Price);
            return ((int)(maxprice!.Price + 1000000) / 1000000) * 1000000;
        }

        private List<Product> filtered(List<Product> products, List<Dto.Attribute> attributes)
        {
            var temp = new List<Product>();
            foreach (var item in products)
            {
                int d = 0;
                foreach (var item1 in item.AttributeSpecs!)
                {
                    if (item1.OptionID != null && attributes.FirstOrDefault(o => item1.AttributeId == o.Code && o.OptionsId!.Contains((int)item1.OptionID)) != null)
                    {
                        d++;
                    }
                }
                if (d == attributes.Count)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        private object getFilter(PaginatedList<Product> result)
        {
            IDictionary<object, HashSet<object>> filterables = new Dictionary<object, HashSet<object>>();
            foreach (var item in result)
            {
                if (item.AttributeSpecs != null && item.AttributeSpecs.Count > 0)
                {
                    foreach (var item1 in item.AttributeSpecs)
                    {
                        if (item1.OptionID != null)
                        {
                            var optionName = _repoOption.ReadByCondition(o => o.Id == item1.OptionID && o.AttributeId == item1.AttributeId).FirstOrDefault()!.Value;
                            var attributeName = _repoAttribute.ReadByCondition(o => o.Id == item1.AttributeId).FirstOrDefault()!.Name;
                            var key = new
                            {
                                attributeId = item1.AttributeId,
                                attributeName = attributeName
                            };

                            var value = new
                            {
                                optionId = item1.OptionID,
                                optionName = optionName
                            };
                            if (!filterables.ContainsKey(key))
                            {
                                filterables.Add(key, new HashSet<object> { value });
                            }
                            else
                            {
                                filterables[key].Add(value);
                            }
                        }
                    }
                }
            }

            List<object> list = new List<object>();
            foreach (var dic in filterables)
            {
                var attributeid = dic.Key.GetType().GetProperty("attributeId")!.GetValue(dic.Key, null);
                var attributename = dic.Key.GetType().GetProperty("attributeName")!.GetValue(dic.Key, null);
                var options = dic.Value.ToList();

                if (options.Count > 1)
                    list.Add(new
                    {
                        code = attributeid,
                        codeName = attributename,
                        options = options
                    });
            }
            return list;
        }
        public object GetForyou(string userId, double rate = 50)
        {
            var viewed = _repoView.ReadByCondition(o => o.CustomerId == userId).Include(o => o.Product);
            var sorted = viewed.OrderByDescending(o => o.Quantity).Include(o => o.Product!.Reviews).Include(o => o.Product!.OrderDetails).Select(o => o.Product).ToList();



            //var listProduct = new HashSet<ProductDto>();   
            //var categorys = new HashSet<Guid>();

            //var getProductViewed = _repoView.ReadByCondition(o => o.CustomerId == userId).Select(o => o.ProductId).ToList();
            //foreach (var item in getProductViewed)
            //{
            //    var category = _repository.ReadByCondition(o => o.Id == item).FirstOrDefault()!.CategoryId;
            //    categorys.Add(category);
            //}
            //var getUserId = _userManager.Users.Where(o => o.Id != userId).Select(o => o.Id).ToList();

            //foreach (var id in getUserId)
            //{
            //    var views = _repoView.ReadByCondition(o => o.CustomerId == id).Select(o => o.ProductId);
            //    var together = getProductViewed.Concat(views);

            //    if (((double)together.Count())/getProductViewed.Count()>=(rate/100.0))
            //    {
            //        var except = views.ToList().Except(getProductViewed);
            //        foreach(var item in except)
            //        {
            //            var product = _repository.ReadByCondition(o => o.Id == item).FirstOrDefault();
            //            if (categorys.Contains(product!.CategoryId))
            //            {
            //                listProduct.Add(_mapper.Map<ProductDto>(product!));
            //            }
            //        }
            //    }
            //}

            return _mapper.Map<List<ProductDto>>(sorted);
        }

        public ProductDto GetProduct(Guid id)
        {
            var products = GetCache();
            var product = products.Where(o => o.Id == id).FirstOrDefault();
            var productDto = _mapper.Map<ProductDto>(product);
            return _mapper.Map<ProductDto>(product);
        }
        private List<Product> GetCache()
        {
            var products = _repository.ReadAll()
                        .Include(o => o.Brand)
                        .Include(o => o.Category)
                        .Include(o => o.Views)
                        .Include(o => o.CartItems)
                        .Include(o => o.OrderDetails)
                        .Include(o => o.Reviews)
                        .Include(o => o.Documents)
                        .Include(o => o.ProductPrices)
                        .Include(o => o.AttributeSpecs)
                        .ToList();
            //if (!_cache.TryGetValue(ProductCacheKey, out List<Product>? products))
            //{
            //    products = _repository.ReadAll()
            //            .Include(o => o.Brand)
            //            .Include(o => o.Category)
            //            .Include(o => o.Views)
            //            .Include(o => o.CartItems)
            //            .Include(o => o.OrderDetails)
            //            .Include(o => o.Reviews)
            //            .Include(o => o.Documents)
            //            .Include(o => o.ProductPrices)
            //            .Include(o => o.AttributeSpecs)
            //            .ToList();
            //    _cache.Set(ProductCacheKey, products);
            //}

            return products!;
        }
        private List<SlugDto> GetSlugCache()
        {
            //if (!_cache.TryGetValue(ProductCacheKey, out List<SlugDto>? slugs))
            //{
            //    slugs = _slugService.GetAll();
            //    _cache.Set(SlugCacheKey, slugs);
            //}
            var slugs = _slugService.GetAll();
            return slugs!;
        }
    }
}
