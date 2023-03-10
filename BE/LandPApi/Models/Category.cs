using LandPApi.Base;

namespace LandPApi.Models
{
    public class Category : IEntityBase
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
