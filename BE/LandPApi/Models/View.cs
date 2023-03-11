namespace LandPApi.Models
{
    public class View
    {
        public string? CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
    }
}
