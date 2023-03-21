using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class ProductView
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Unit { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double PercentSale { get; set; } = 0;
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Guid BrandId { get; set; }
    }
}
