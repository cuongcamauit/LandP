using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class AttributeGroupService : IAttributeGroupService
    {
        private readonly IRepository<AttributeGroup> _repository;
        private readonly IMapper _mapper;

        public AttributeGroupService(IRepository<AttributeGroup> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public void Create(AttributeGroupView attributeGroupView)
        {
            var attributeGroup = _mapper.Map<AttributeGroup>(attributeGroupView);
            _repository.Create(attributeGroup);
            _repository.Save();
        }

        public List<AttributeGroupDto> GetById(Guid categoryId)
        {
            var attributes = _repository.ReadByCondition(o => o.CategoryId == categoryId).Include(o => o.Attribute).Include(o => o.Category);
            return _mapper.Map<List<AttributeGroupDto>>(attributes);
        }
    }
}
