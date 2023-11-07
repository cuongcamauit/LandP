using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IAttributeService
    {
        List<AttributeDto> GetAll();
        void Create(AttributeView attribute);
    }
}
