using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IAttributeGroupService
    {
        void Create(AttributeGroupView attributeGroupView);
        List<AttributeGroupDto> GetById(Guid categoryId);
    }
}
