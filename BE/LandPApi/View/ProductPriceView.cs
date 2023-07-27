using LandPApi.Models;

namespace LandPApi.View
{
    public class ProductPriceView
    {
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
