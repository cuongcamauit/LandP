namespace LandPApi.Dto
{
    public class OrderDetailDto
    {
        public ProductDto? Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double PercentSale { get; set; }
    }
}
