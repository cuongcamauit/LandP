using LandPApi.Models;

namespace LandPApi.Dto
{
    public class CartItemDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
    }
}
