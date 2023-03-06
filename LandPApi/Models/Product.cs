namespace LandPApi.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Unit { get; set; }
        public int Quantity { get; set; }
        public double PercentSale { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public Brand? Brand { get; set; }
        public Category? Category { get; set; }
        public ICollection<View>? Views { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
