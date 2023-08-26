

namespace LandPApi.Models
{
    public class Address : BaseModel
    { 
        public Guid Id { get; set; }
        public string? Province { get; set; }
        public int ProvinceId { get; set; }
        public string? District { get; set; }
        public int DistrictId { get; set; } 
        public string? Ward { get; set; }
        public int WardId { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Order>? Orders { get;set; }
    }
}
