

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
        public double Total { get; set; }
        public string? CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public Customer? Customer { get; set; }
        public Address? Address { get; set; }
        public ICollection<HistoryStatus>? HistoryStatuses { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
