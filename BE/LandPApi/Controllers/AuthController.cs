using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://api.currencyapi/");
            //    //GET Method
            //    HttpResponseMessage response = await client.GetAsync("v3/latest?apikey=seaoyCIdGMxekEbdE5Mgl8jCGbOwqgtoZxInJBxP&currencies=VND");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        object t = response.Content;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Internal server Error");
            //    }
            //}



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
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
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
        [HttpPut("Profile")]
        [Authorize]
        public async Task<IActionResult> UpdateProfile(UpdateProfileView updateProfileView)
        {
            var customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _userService.UpdateProfile(customerId, updateProfileView);
            return Ok(result);
        }

        [HttpGet("Profile")]
        [Authorize]
        public async Task<IActionResult> GetProfile()
        {
            var customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Response result = await _userService.GetProfile(customerId);
            return Ok(result);
        }


        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordView resetPasswordViewModel)
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

        // admin
        [HttpGet("Admin/Users")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUser()
        {
            var response = await _userService.GetUser();
            return Ok(response);
        }

        [HttpPut("Admin/Disable/{userId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DisableUser(String userId)
        {
            var response = await _userService.Disable(userId);
            return Ok(response);
        }

        [HttpPut("Admin/Enable/{userId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EnableUser(String userId)
        {
            var response = await _userService.Enable(userId);
            return Ok(response);
        }

        [HttpGet("Admin/Statistics")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Statistics(DateTime fromDate, DateTime toDate)
        {
            var response = await _userService.Statistics(fromDate, toDate);
            return Ok(response);
        }
    }
}
