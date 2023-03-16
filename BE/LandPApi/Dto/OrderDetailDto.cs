namespace LandPApi.Dto
{
    public class OrderDetailDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double PercentSale { get; set; }
    }
}
