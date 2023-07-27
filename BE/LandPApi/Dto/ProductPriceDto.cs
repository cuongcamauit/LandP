using LandPApi.Models;

namespace LandPApi.Dto
{
    public class ProductPriceDto
    {
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
