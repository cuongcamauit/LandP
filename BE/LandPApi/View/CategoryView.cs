using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class CategoryView
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
