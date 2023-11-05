using LandPApi.Models;

namespace LandPApi.Dto
{
    public class SlugDto
    {
        // use to show in url and
        public String? Id { get; set; }
        // use to show title of group products
        public String? Title { get; set; }
        public String? Image { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
