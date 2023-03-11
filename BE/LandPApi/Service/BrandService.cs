using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class BrandService : BaseRepository<Brand>, IBrandService
    {
        public BrandService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
