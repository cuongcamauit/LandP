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
                    Message = "User not found",
                    StatusCode = 404
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
                    Success = true,
                };
            }
            var message = string.Join(" | ", result.Errors.Select(o => o.Description));

            return new Response
            {
                Success = false,
                Message = "Email did not confirm",
                StatusCode = 400,
                Data = message
            };
        }

        public async Task<Response> ForgetPasswordAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return new Response
                {
                    StatusCode = 404,
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
                    StatusCode = 404,
                };
            }

            var result = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);

            if (!result)
            {
                return new Response
                {
                    Message = "Invalid Password",
                    Success = false,
                    StatusCode = 400,
                };
            }
            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles.Contains("User") && !user.EmailConfirmed)
                return new Response
                {
                    Message = "Please comfirm email!",
                    Success = false,
                    StatusCode = 401
                };

            var claims = new List<Claim>()
            {
                new Claim("Email", loginViewModel.Email!),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };
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

        public async Task<Response> ResetPasswordAsync(ResetPasswordView resetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
            if (user == null)
                return new Response
                {
                    Success = false,
                    Message = "No user associated with email",
                    StatusCode = 404
                };
            if (resetPasswordViewModel.NewPassword != resetPasswordViewModel.ConfirmPassword)
                return new Response
                {
                    Success = false,
                    Message = "Password doesn't math with its confirmation",
                    StatusCode = 400
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

            var message = string.Join(" | ", result.Errors.Select(o => o.Description));

            return new Response
            {
                Message = "Something went wrong",
                Success = false,
                Data = message,
                StatusCode = 400
            };
        }

        public async Task<Response> ResgisterUserAsync(RegisterView model)
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
                    StatusCode = 403
                };
            }
            var identityUser = new Customer
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email,
                BirthDay = model.BirthDay,
                PhoneNumber = model.Phone,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
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
                    Message = "User created successfully! Please comfirm Email!",
                    Success = true,
                    StatusCode = 201
                };
            }

            var message = string.Join(" | ", result.Errors.Select(o => o.Description));
            return new Response
            {
                Message = "User did not create",
                Success = false,
                Data = message,
                StatusCode = 400
            };
        }

        public async Task<Response> UpdateProfile(string customerId, UpdateProfileView updateProfileView)
        {
            Customer user = await _userManager.FindByIdAsync(customerId);
            user.Name = updateProfileView.Name;
            user.BirthDay = updateProfileView.BirthDay;
            user.UpdateDate = DateTime.Now;
            user.PhoneNumber = updateProfileView.Phone;
            var resultUpdate = await _userManager.UpdateAsync(user);
            if (!resultUpdate.Succeeded)
            {
                var message = string.Join(" | ", resultUpdate.Errors.Select(o => o.Description));
                return new Response
                {
                    Message = "User did not update",
                    Success = false,
                    Data = message,
                    StatusCode = 400
                };
            }
            if (updateProfileView.NewPassword != null && updateProfileView.CurrentPassword != null)
            {
                var result = await _userManager.ChangePasswordAsync(user, updateProfileView.CurrentPassword, updateProfileView.NewPassword);
                if (!result.Succeeded)
                {
                    var message = string.Join(" | ", result.Errors.Select(o => o.Description));
                    return new Response
                    {
                        Message = "User did not update",
                        Success = false,
                        Data = message,
                        StatusCode = 400
                    };
                }
            }
            return new Response
            {
                Message = "User updated successfully!",
                Success = true,
                StatusCode = 204
            };
        }
    }
}
