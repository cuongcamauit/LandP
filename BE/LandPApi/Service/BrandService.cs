using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class BrandService : GenericService<BrandView, BrandDto, Brand>, IBrandService
    {
        public BrandService(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
