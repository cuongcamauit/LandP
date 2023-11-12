using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LandPApi.View
{
    public class UpdateProfileView
    {
        [Required]
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        public string? ConfirmNewPassword { get; set; }
    }
}
