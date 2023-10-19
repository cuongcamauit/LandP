using LandPApi.View;

namespace LandPApi.IService
{
    public interface ISlugProductService
    {
        void Add(SlugProductView slugProductView);
        void Remove(SlugProductView slugProductView);
    }
}
