using Microsoft.AspNetCore.Identity;

namespace LandPApi.Models
{
    public class Customer : IdentityUser
    {
        public string? Name { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<View>? Views { get; set; }
    }
}
