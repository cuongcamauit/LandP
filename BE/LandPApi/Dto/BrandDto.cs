using System.ComponentModel.DataAnnotations;

namespace LandPApi.Dto
{
    public class BrandDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
    }
}
