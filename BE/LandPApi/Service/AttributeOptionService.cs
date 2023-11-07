using AutoMapper;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class AttributeOptionService : IAttributeOptionService
    {
        private readonly IRepository<AttributeOption> _repository;
        private readonly IMapper _mapper;

        public AttributeOptionService(IRepository<AttributeOption> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(AttributeOptionView attributeOptionView)
        {
            var option = _mapper.Map<AttributeOption>(attributeOptionView);
            _repository.Create(option);
            _repository.Save();
        }

        public List<AttributeOptionView> GetAll()
        {
            var options = _repository.ReadAll()
                            .ToList();
            return _mapper.Map<List<AttributeOptionView>>(options);
        }

        public List<AttributeOptionView> GetById(int attributeId)
        {
            var options = _repository.ReadByCondition(o => o.AttributeId == attributeId)
                            .ToList();
            return _mapper.Map<List<AttributeOptionView>>(options);
        }
    }
}
