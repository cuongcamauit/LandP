using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class RegisterView
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MinLength(6)]
        public string? Password { get; set; }
        [Required]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
    }
}
