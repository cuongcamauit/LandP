using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class SlugService : ISlugService
    {
        private readonly IRepository<Slug> _repository;
        private readonly IMapper _mapper;
        private readonly ICacheService _cacheService;

        public SlugService(IRepository<Slug> repository, IMapper mapper, ICacheService cacheService)
        {
            _repository = repository;
            _mapper = mapper;
            _cacheService = cacheService;
        }
        public void Add(SlugView slug)
        {
            var slugModel = _mapper.Map<Slug>(slug);
            _repository.Create(slugModel);
            _repository.Save();
        }

        public List<SlugDto> GetAll()
        {
            return _mapper.Map<List<SlugDto>>(_cacheService.GetSlugs());
        }

        public SlugDto GetById(String id)
        {
            var slug = _cacheService.GetSlugs().FirstOrDefault(o => o.Id == id);
            return _mapper.Map<SlugDto>(slug);
        }

        public List<SlugDto> GetSliders()
        {
            var sliders = _cacheService.GetSlugs().Where(o => o.IsSilder == true).ToList();
            return _mapper.Map<List<SlugDto>>(sliders);
        }
    }
}
