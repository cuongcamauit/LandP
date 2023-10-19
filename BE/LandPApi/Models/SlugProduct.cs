namespace LandPApi.Models
{
    public class SlugProduct
    {
        public String? SlugId { get; set; }
        public Guid ProductId { get; set; }
        public Slug? Slug { get; set; }
        public Product? Product { get; set; }
    }
}
