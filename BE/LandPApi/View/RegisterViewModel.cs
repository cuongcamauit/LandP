using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class RegisterViewModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        // Mật khẩu phải nhiều hơn 8 ký tự, ít nhất 1 chữ thường 1 chữ in hoa, 1 chữ số, 1 ký tự đặc biệt

        public string? Password { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        // Mật khẩu phải nhiều hơn 8 ký tự, ít nhất 1 chữ thường 1 chữ in hoa, 1 chữ số, 1 ký tự đặc biệt

        public string? ConfirmPassword { get; set; }
    }
}
