namespace LandPApi.Models
{
    public class CartItem
    {
        public string? CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }   
        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
    }
}
