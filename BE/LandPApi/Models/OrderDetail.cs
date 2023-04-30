namespace LandPApi.Models
{
    public class OrderDetail
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double PercentSale { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
        public double realPrice()
        {
            return Price - (Price*PercentSale/100);
        }
    }
}
