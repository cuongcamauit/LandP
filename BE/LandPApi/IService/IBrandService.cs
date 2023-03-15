using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LandPApi.IService
{
    public interface IBrandService : IGenericService<BrandView, BrandDto, Brand>
    {
        
    }
}
