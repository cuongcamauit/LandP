using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface ICategoryService : IGenericService<CategoryView, CategoryDto, Category>
    {
    }
}
