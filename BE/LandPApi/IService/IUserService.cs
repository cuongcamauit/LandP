using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IUserService
    {
        Task<Response> ResgisterUserAsync(RegisterView model);
        Task<Response> LoginUserAsync(LoginViewModel loginViewModel);
        Task<Response> ConfirmEmailAsync(string userId, string token);
        Task<Response> ForgetPasswordAsync(string email);
        Task<Response> ResetPasswordAsync(ResetPasswordView resetPasswordViewModel);
        Task<Response> UpdateProfile(string customerId, UpdateProfileView updateProfileView);
        Task<Response> GetProfile(string customerId);
        Task<Response> GetUser();
        Task<Response> Disable(string userId);
        Task<Response> Enable(string userId);
        Task<Response> Statistics(DateTime fromDate, DateTime toDate);
    }
}
