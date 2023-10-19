using AutoMapper;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class SlugProductService : ISlugProductService
    {
        private readonly IRepository<SlugProduct> _repository;
        private readonly IMapper _mapper;
        private readonly ISlugService _slugService;

        public SlugProductService(IRepository<SlugProduct> repository, IMapper mapper
            , ISlugService slugService)
        {
            _repository = repository;
            _mapper = mapper;
            _slugService = slugService;
        }
        public void Add(SlugProductView slugProductView)
        {
            var slugProduct = _mapper.Map<SlugProduct>(slugProductView);
            _repository.Create(slugProduct);
            _repository.Save();
            _slugService.UpdateCache(ProductService.SlugCacheKey);
        }

        public void Remove(SlugProductView slugProductView)
        {
            var slugProduct = _mapper.Map<SlugProduct>(slugProductView);
            _repository.Delete(slugProduct);
            _repository.Save();
            _slugService.UpdateCache(ProductService.SlugCacheKey);
        }
    }
}
