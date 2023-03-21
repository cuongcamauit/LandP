using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class ReviewView
    {
        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }
        public string? Comment { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Guid OrderId { get; set; }
    }
}
