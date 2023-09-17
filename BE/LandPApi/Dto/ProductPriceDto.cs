using LandPApi.Models;

namespace LandPApi.Dto
{
    public class ProductPriceDto
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
