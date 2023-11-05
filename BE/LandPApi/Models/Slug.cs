namespace LandPApi.Models
{
    public class Slug
    {
        // use to show in url and
        public String? Id { get; set; }
        // use to show title of group products
        public String? Title { get; set; }
        public String? Image { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
        public bool IsSilder { get; set; } = false;
        public ICollection<SlugProduct>? SlugProducts { get; set; }
        public String? MenuId { get; set; } = null;
        public Menu? Menu { get; set; } = null;
        public List<Product> GetProducts()
        {
            var products = this.SlugProducts!.Select(o => o.Product).ToList();
            return products!;
        }
    }
}
