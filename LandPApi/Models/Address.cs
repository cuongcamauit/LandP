namespace LandPApi.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Order>? Orders { get;set; }
    }
}
