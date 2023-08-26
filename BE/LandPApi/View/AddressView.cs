using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class AddressView
    {
        [Required]
        public string? Province { get; set; }
        public int ProvinceId { get; set; }
        [Required]
        public string? District { get; set; }
        public int DistrictId { get; set; }
        [Required]
        public string? Ward { get; set; }
        public int WardId { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
    }
}
