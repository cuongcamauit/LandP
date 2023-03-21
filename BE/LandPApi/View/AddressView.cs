using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class AddressView
    {
        [Required]
        public string? Province { get; set; }
        [Required]
        public string? District { get; set; }
        [Required]
        public string? Ward { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
    }
}
