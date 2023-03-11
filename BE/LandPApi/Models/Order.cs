
using LandPApi.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandPApi.Models
{
    public class Order : IEntityBase
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public bool isPaid { get; set; }
        public string? CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public Customer? Customer { get; set; }
        public Address? Address { get; set; }
        public ICollection<HistoryStatus>? HistoryStatuses { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
