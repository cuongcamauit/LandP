using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly ICacheService _cacheService;

        public ProductService(IRepository<Product> repository
                            , IRepository<Models.View> repoView
                            , IRepository<Attribute> repoAttribute
                            , IRepository<AttributeOption> repoOption
                            , IMapper mapper
                            , UserManager<Customer> userManager
                            , IDriveService driveService
                            , ICacheService cacheService) : base(repository, mapper)
        {
            _driveService = driveService;
            _repoView = repoView;
            _repoOption = repoOption;
            _repoAttribute = repoAttribute;
            _userManager = userManager;
            _cacheService = cacheService;
        }
        public new ProductDto Create(ProductView view)
        {
            var entity = _mapper.Map<Product>(view);
            entity.FolderId = _driveService.AddFolder(view.Name!, "1gvWxcVd3JxyZ7v9FJhb1Pp5jJJyyGaKU");

            _repository.Create(entity);
            _repository.Save();
            _cacheService.AddProduct(entity);

            return _mapper.Map<ProductDto>(entity);
        }
        public object GetAllAsync(SearchInfor searchInfor)
        {
            searchInfor.Query = searchInfor.Query.ToLower();
            var products = _cacheService.GetProduct();
            var slugs = _cacheService.GetSlugs();

            Slug? slug = slugs.SingleOrDefault(o => o.Id == searchInfor.Slug || o.Id == searchInfor.Query);

            var check = true;
            if (slug != null)
            {
                check = false;
                slug = slugs.SingleOrDefault(o => o.Id == searchInfor.Slug || o.Id == searchInfor.Query)!;
                products = _mapper.Map<SlugDto>(slug).Products!.ToList();
            }

            #region Searching
            if (searchInfor.Query != "" && check)
            {
                products = products!.Where(o => o.Name!.ToLower().Contains(searchInfor.Query)).ToList();
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
            var filterlist = getFilter(products);
            var maxPrice = getMaxPrice(products);
            #region Paginate

            var result = PaginatedList<Product>.Create(products!, searchInfor.Pagination!.PageNumber, searchInfor.Pagination.ItemsPerPage);

            #endregion


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
        private object getFilter(List<Product> result)
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
            var product = _cacheService.GetProduct().FirstOrDefault(o => o.Id == id);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
