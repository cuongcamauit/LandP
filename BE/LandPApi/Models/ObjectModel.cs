using System.ComponentModel.DataAnnotations;

namespace LandPApi.Models
{
    public class ObjectModel
    {
        [Key]
        public int Id { get; set; } 
        public string? demo { get; internal set; }
    }
}
