using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class ResetPasswordView
    {
        [Required]
        public string? Token { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MinLength(6)]
        public string? NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string? ConfirmPassword { get; set; }
    }
}
