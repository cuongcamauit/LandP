using LandPApi.Base;

namespace LandPApi.Models
{
    public enum Status
    {
        New,
        Processing,
        Shipping,
        Delivered,
        Canceled
    }
    public class HistoryStatus : IEntityBase
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
