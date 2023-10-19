

namespace LandPApi.Models
{
    public class Product : BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? FolderId { get; set; }
        public string? Unit { get; set; } = "Unit";
        public int Quantity { get; set; }
        //public double //PercentSale { get; set; }
        //public double AverageRating { get; set; } = 0;
        //public int ReviewQuantity { get; set; } = 0;
        //public double SoldQuantity { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public Brand? Brand { get; set; }
        public Category? Category { get; set; }
        public ICollection<View>? Views { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Document>? Documents { get; set; }
        public ICollection<ProductPrice>? ProductPrices { get; set; }
        public ICollection<AttributeSpec>? AttributeSpecs { get; set; }
        public ICollection<SlugProduct>? SlugProducts { get; set; }
        public double GetNowPrice(DateTime? datenow = null)
        {
            if (datenow == null)
                datenow = DateTime.Now;
            var pricenow = this.ProductPrices!.FirstOrDefault(o => o.FromDate <= datenow && o.ToDate >= datenow);
            return pricenow == null ? this.Price : pricenow.Price;
        }
    }
}
