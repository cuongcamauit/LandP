using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class BrandView
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
    }
}
