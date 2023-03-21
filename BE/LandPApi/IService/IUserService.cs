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

    }
}
