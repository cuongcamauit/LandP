using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IViewService
    {
        Task AddAsync(LandPApi.Models.View view);
    }
}
