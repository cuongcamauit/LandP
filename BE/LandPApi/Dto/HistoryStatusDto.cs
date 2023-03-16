using LandPApi.Models;
using System.Text.Json.Serialization;

namespace LandPApi.Dto
{
    public class HistoryStatusDto
    {
        public Guid Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid OrderId { get; set; }
    }
}
