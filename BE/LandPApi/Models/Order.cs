

using System.ComponentModel.DataAnnotations.Schema;

namespace LandPApi.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        //public bool isPaid { get; set; } = false;
        public DateTime? PaidAt { get; set; } = null;
        public double SubTotal { get; set; }
        public double ShippingFee { get; set; }
        public double ShippingFeeVoucher { get; set; } = 0;
        public double ShopVoucher { get; set; } = 0;
        public string? CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public Customer? Customer { get; set; }
        public Address? Address { get; set; }
        public ICollection<HistoryStatus>? HistoryStatuses { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public double Total()
        {
            return this.SubTotal + this.ShippingFee - this.ShippingFeeVoucher - this.ShopVoucher;
        }
    }
}
