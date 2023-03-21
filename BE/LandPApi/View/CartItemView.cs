using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class CartItemView
    {
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
