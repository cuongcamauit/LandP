using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class CategoryService : BaseRepository<Category>, ICategoryService
    {
        public CategoryService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
