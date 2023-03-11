using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IUserService
    {
        Task<Response> ResgisterUserAsync(RegisterViewModel model);
        Task<Response> LoginUserAsync(LoginViewModel loginViewModel);
        Task<Response> LoginWithOtpAsync();
        Task<Response> ConfirmEmailAsync(string userId, string token);
        Task<Response> ForgetPasswordAsync(string email);
        Task<Response> ResetPasswordAsync(ResetPasswordViewModel resetPasswordViewModel);

    }
}
