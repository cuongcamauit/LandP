using LandPApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class OrderView
    {
        [Required]
        public Guid AddressId { get; set; }
        [Required]
        public List<Guid>? productIds { get; set; }
    }
}
