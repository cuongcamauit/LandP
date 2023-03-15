
using System.ComponentModel.DataAnnotations;

namespace LandPApi.Models
{
    public class Brand : BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
