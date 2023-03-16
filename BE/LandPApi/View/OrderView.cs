using LandPApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class OrderView
    {
        public Guid AddressId { get; set; }
        public bool isPaid { get; set; }
        public List<Guid> productIds { get; set; }
    }
}
