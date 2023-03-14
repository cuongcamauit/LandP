using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LandPApi.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<Customer> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IMailService _mailService;

        public UserService(UserManager<Customer> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IMailService mailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mailService = mailService;
        }
        public async Task<Response> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "User not found"
                };
            }

            var decodedToken = WebEncoders.Base64UrlDecode(token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManager.ConfirmEmailAsync(user, normalToken);

            if (result.Succeeded)
            {
                return new Response
                {
                    Message = "Email confirmed successfully!",
                    Success = true
                };
            }

            return new Response
            {
                Success = false,
                Message = "Email did not confirm",

                Data = result.Errors.Select(e => e.Description)
            };
        }

        public async Task<Response> ForgetPasswordAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return new Response
                {
                    Success = false,
                    Message = "No user associated with email"
                };

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var encodeToken = Encoding.UTF8.GetBytes(token);
            var validToken = WebEncoders.Base64UrlEncode(encodeToken);

            string url = $"{_configuration["AppUrl"]}/ResetPassword?email={email}&token={validToken}";
            await _mailService.SendEmailAsync(email, "Reset Password", "<h1>Follow the instruction to reset your password</h1>" + $"<p>To reset your password <a href={url}>Click here</a></p> ");

            return new Response
            {
                Success = true,
                Message = "Reset password url has been sent to the email successfully"
            };
        }

        public async Task<Response> LoginUserAsync(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (user == null)
            {
                return new Response
                {
                    Message = "There are no user with that Email address",
                    Success = false,
                };
            }

            var result = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);

            if (!result)
            {
                return new Response
                {
                    Message = "Invalid Password",
                    Success = false
                };
            }

            var claims = new List<Claim>()
            {
                new Claim("Email", loginViewModel.Email!),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]!));

            var token = new JwtSecurityToken(
                    issuer: _configuration["AuthSettings:Issuer"],
                    audience: _configuration["AuthSettings:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            return new Response
            {
                Message = "User logged in successfully",
                Success = true,
                Data = new
                {
                    user = user,
                    role = userRoles,
                    token = tokenAsString,
                    expire = token.ValidTo
                }
            };
        }

        public Task<Response> LoginWithOtpAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Response> ResetPasswordAsync(ResetPasswordViewModel resetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
            if (user == null)
                return new Response
                {
                    Success = false,
                    Message = "No user associated with email"
                };
            if (resetPasswordViewModel.NewPassword != resetPasswordViewModel.ConfirmPassword)
                return new Response
                {
                    Success = false,
                    Message = "Password doesn't math with its confirmation"
                };

            var decodedToken = WebEncoders.Base64UrlDecode(resetPasswordViewModel.Token!);
            string normalToken = Encoding.UTF8.GetString(decodedToken);
            var result = await _userManager.ResetPasswordAsync(user, normalToken, resetPasswordViewModel.NewPassword);

            if (result.Succeeded)
                return new Response
                {
                    Message = "Password has been successfully!",
                    Success = true
                };
            return new Response
            {
                Message = "Something went wrong",
                Success = false,
                Data = result.Errors.Select(e => e.Description)
            };
        }

        public async Task<Response> ResgisterUserAsync(RegisterViewModel model)
        {
            if (model == null)
            {
                throw new NullReferenceException("Register Model is null");
            }
            if (model.Password != model.ConfirmPassword)
            {
                return new Response
                {
                    Message = "Confirm password doesn't match password",
                    Success = false,
                };
            }
            var identityUser = new Customer
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email,
                BirthDay = model.BirthDay,
                PhoneNumber = model.Phone
            };

            var result = await _userManager.CreateAsync(identityUser, model.Password);

            if (result.Succeeded)
            {

                // assign role
                if (await _roleManager.RoleExistsAsync("User"))
                    await _userManager.AddToRoleAsync(identityUser, "User");
                // TODO: Send a confirmation email
                var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(identityUser);

                var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);

                var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

                string url = $"{_configuration["AppUrl"]}/api/auth/confirmemail?userid={identityUser.Id}&token={validEmailToken}";

                await _mailService.SendEmailAsync(identityUser.Email!, "Confirm your email", "<h1>Welcome to Auth</h1>" + $"<p>Please confirm your email by <a href='{url}'>Clicking here</a></p>");
                return new Response
                {
                    Message = "User created successfully!",
                    Success = true,
                };
            }

            return new Response
            {
                Message = "User did not create",
                Success = false,
            };

        }

    }
}
