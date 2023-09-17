namespace LandPApi.Models
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public double Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
