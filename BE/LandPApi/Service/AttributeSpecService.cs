using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class AttributeSpecService : IAttributeSpeccService
    {
        private readonly IRepository<AttributeSpec> _repository;
        private readonly IMapper _mapper;
        private readonly IRepository<AttributeOption> _repo;

        public AttributeSpecService(IRepository<AttributeSpec> repository, IMapper mapper,
                                    IRepository<AttributeOption> repository1)
        {
            _repository = repository;
            _mapper = mapper;
            _repo = repository1;
        }
        public void Create(AttributeSpecView attributeSpecView)
        {
            var spec = _mapper.Map<AttributeSpec>(attributeSpecView);
            _repository.Create(spec);
            //var t = _repo.ReadByCondition(o => o.AttributeId == attributeSpecView.AttributeId
            //                                && o.Id == attributeSpecView.OptionID);
            _repository.Save();
        }

        public List<AttributeSpecDto> GetById(Guid productId)
        {
            var specs = _repository.ReadByCondition(o => o.ProductId == productId)
                        .Include(o => o.Option)
                        .ToList();
            return _mapper.Map<List<AttributeSpecDto>>(specs);
        }
    }
}
