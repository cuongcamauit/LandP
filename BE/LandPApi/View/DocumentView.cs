using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class DocumentView
    {
        [Required]
        public string? Id { get; set; }
    }
}
