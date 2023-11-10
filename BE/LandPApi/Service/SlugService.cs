using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace LandPApi.Service
{
    public class SlugService : ISlugService
    {
        private readonly IRepository<Slug> _repository;
        private readonly IMapper _mapper;
        // private readonly IMemoryCache _cache;

        public SlugService(IRepository<Slug> repository, IMapper mapper,
            IMemoryCache cache)
        {
            _repository = repository;
            _mapper = mapper;
            // _cache = cache;
        }
        public void Add(SlugView slug)
        {
            var slugModel = _mapper.Map<Slug>(slug);
            _repository.Create(slugModel);
            _repository.Save();
            // UpdateCache(ProductService.SlugCacheKey);
        }

        public List<SlugDto> GetAll()
        {
            var listSlug = _repository.ReadByCondition(o => o.IsDeleted == false)
                        .Include(o => o.SlugProducts)!
                            .ThenInclude(o => o.Product)
                            .ThenInclude(o => o!.Brand)
                        .Include(o => o.SlugProducts)!
                            .ThenInclude(o => o.Product)
                            .ThenInclude(o => o!.Category)
                        .Include(o => o.SlugProducts)!
                            .ThenInclude(o => o.Product)
                            .ThenInclude(o => o!.Views)

                        .Include(o => o.SlugProducts)!
                            .ThenInclude(o => o.Product)
                            .ThenInclude(o => o!.CartItems)

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
                            .ThenInclude(o => o!.Documents)

                        .Include(o => o.SlugProducts)!
                            .ThenInclude(o => o.Product)
                            .ThenInclude(o => o!.AttributeSpecs);


            return _mapper.Map<List<SlugDto>>(listSlug);
        }

        public SlugDto GetById(String id)
        {
            var slug = _repository.ReadByCondition(o => o.IsDeleted == false && o.Id == id);
            return _mapper.Map<SlugDto>(slug);
        }

        public List<SlugDto> GetSliders()
        {
            var listSlug = _repository.ReadByCondition(o => o.IsDeleted == false && o.IsSilder == true)
            .Include(o => o.SlugProducts)!
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o!.Brand)
            .Include(o => o.SlugProducts)!
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o!.Category)
            .Include(o => o.SlugProducts)!
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o!.Views)

            .Include(o => o.SlugProducts)!
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o!.CartItems)

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
                .ThenInclude(o => o!.Documents)

            .Include(o => o.SlugProducts)!
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o!.AttributeSpecs);


            return _mapper.Map<List<SlugDto>>(listSlug);
        }

        //public void UpdateCache(string cacheName)
        //{
        //    var slugs = GetAll();
        //    _cache.Set(cacheName, slugs);
        //}
    }
}
