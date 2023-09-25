using LandPApi.Models;
using System.Text.Json.Serialization;

namespace LandPApi.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public AddressDto? Address { get; set; }
        //public bool isPaid { get; set; }
        public DateTime? PaidAt { get; set; }
        public double SubTotal { get; set; }
        public double ShippingFee { get; set; }
        public double ShippingFeeVoucher { get; set; } = 0;
        public double ShopVoucher { get; set; } = 0;
        public string? CustomerId { get; set; }
        public double Total { get; set; }
    }
}
