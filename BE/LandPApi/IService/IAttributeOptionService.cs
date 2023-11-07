using LandPApi.View;

namespace LandPApi.IService
{
    public interface IAttributeOptionService
    {
        List<AttributeOptionView> GetAll();
        List<AttributeOptionView> GetById(int attributeId);
        void Create(AttributeOptionView attributeOptionView);
    }
}
