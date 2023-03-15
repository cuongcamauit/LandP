namespace LandPApi.View
{
    public class ProductView
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Unit { get; set; }
        public int Quantity { get; set; }
        public double PercentSale { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
    }
}
