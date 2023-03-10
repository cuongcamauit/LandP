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
        public async Task<IActionResult> RegisterAsync(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ResgisterUserAsync(registerViewModel);

                if (result.Success) 
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
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
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
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

            return BadRequest(result);
        }

        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
                return NotFound();

            var result = await _userService.ForgetPasswordAsync(email);

            if (result.Success )
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm]ResetPasswordViewModel resetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ResetPasswordAsync(resetPasswordViewModel);
                if (result.Success) 
                    return Ok(result);
                
                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
        }
    }
}
