using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IAttributeSpeccService
    {
        List<AttributeSpecDto> GetById(Guid productId);
        void Create(AttributeSpecView attributeSpecView);
    }
}
