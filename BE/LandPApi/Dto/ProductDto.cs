namespace LandPApi.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Unit { get; set; }
        public int Quantity { get; set; }
        public double PercentSale { get; set; }
        public double AverageRating { get; set; }
        public int ReviewQuantity { get; set; }
        public double SoldQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
    }
}
