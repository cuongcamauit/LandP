using LandPApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class OrderView
    {
        [Required]
        public Guid AddressId { get; set; }
        public bool isPaid { get; set; } = false;
        [Required]
        public List<Guid>? productIds { get; set; }
    }
}
