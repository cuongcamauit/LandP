using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public AuthController(IUserService userService, IMailService mailService, IConfiguration configuration)
        {
            _userService = userService;
            _mailService = mailService;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(RegisterView registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ResgisterUserAsync(registerViewModel);
                
                return Ok(result);
            }

            var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
            return Ok(new Response
            {
                Success = false,
                Message = "Some properties is wrong",
                Data = message,
                StatusCode = 422
            });
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(loginViewModel);
                if (result.Success)
                {
                    await _mailService.SendEmailAsync(loginViewModel.Email!, "New login", "<h1>Hey! new login to your account</h1><p>New login to your account at " + DateTime.Now + "</p>");
                }

                return Ok(result);
            }

            var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
            return Ok(new Response
            {
                Success = false,
                Message = "Some properties is wrong",
                Data = message,
                StatusCode = 422
            });
        }

        // api/auth/confirmemail?userid&token
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if ( string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return NotFound();
            var result = await _userService.ConfirmEmailAsync(userId, token);

            if (result.Success)
            {
                return Redirect($"{_configuration["AppUrl"]}/confirmEmail.html");
            }

            return Ok(result);
        }

        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
                return NotFound();

            var result = await _userService.ForgetPasswordAsync(email);
        
            return Ok(result);
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm]ResetPasswordView resetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ResetPasswordAsync(resetPasswordViewModel);
                if (result.Success)
                    return Redirect($"{_configuration["AppUrl"]}/resetPassword.html");

                return BadRequest(result);
            }

            var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
            return Ok(new Response
            {
                Success = false,
                Message = "Some properties is wrong",
                Data = message,
                StatusCode = 422
            });
        }
    }
}
