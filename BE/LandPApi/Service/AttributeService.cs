using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class AttributeService : IAttributeService
    {
        private readonly IRepository<Models.Attribute> _repository;
        private readonly IMapper _mapper;

        public AttributeService(IRepository<Models.Attribute> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(AttributeView attribute)
        {
            var attributemodel = _mapper.Map<Models.Attribute>(attribute);
            _repository.Create(attributemodel);
            _repository.Save();
        }

        public List<AttributeDto> GetAll()
        {
            var attributes = _repository.ReadAll().ToList();
            return _mapper.Map<List<AttributeDto>>(attributes);
        }
    }
}
