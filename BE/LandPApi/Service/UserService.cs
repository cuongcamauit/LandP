﻿using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;
        private readonly IRepository<Order> _repoOrder;
        private readonly IRepository<OrderDetail> _repoDetail;

        public UserService(UserManager<Customer> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            IMailService mailService,
            IMapper mapper,
            IRepository<Order> repoOrder,
            IRepository<OrderDetail> repoDetail)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mailService = mailService;
            _mapper = mapper;
            _repoOrder = repoOrder;
            _repoDetail = repoDetail;
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

        public async Task<Response> GetProfile(string customerId)
        {
            Customer customer = await _userManager.FindByIdAsync(customerId);
            if (customer != null)
            {
                return new Response
                {
                    StatusCode = 200,
                    Message = "Get profile user successful!",
                    Data = _mapper.Map<CustomerDto>(customer)
                };
            }
            return new Response
            {
                Success = false,
                StatusCode = 404,
                Message = "Not found user!"
            };
        }

        public async Task<Response> LoginUserAsync(LoginViewModel loginViewModel)
        {
            var userlist = _userManager.Users;
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
            if (user.LockoutEnabled)
            {
                return new Response
                {
                    Message = "User is locked",
                    Success = false,
                    StatusCode = 400
                };
            }

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
                    user = _mapper.Map<CustomerDto>(user),
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

        public async Task<string> RegisterAdmin()
        {
            var identityUser = new Customer
            {
                Name = "Admin",
                Email = "admin@landp.com",
                UserName = "admin@landp.com",
                BirthDay = DateTime.Now,
                PhoneNumber = "123456789",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var result = await _userManager.CreateAsync(identityUser, "admin.123");

            if (result.Succeeded)
            {

                // assign role
                if (await _roleManager.RoleExistsAsync("Admin"))
                    await _userManager.AddToRoleAsync(identityUser, "admin");

                return identityUser.Id;
            }
            return null;
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
            var checkEmail = await _userManager.FindByEmailAsync(model.Email);
            if (checkEmail != null)
            {
                return new Response
                {
                    Message = "Email has been existed",
                    Success = false,
                    StatusCode = 409
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
                    Message = message,
                    Success = false,
                    Data = null,
                    StatusCode = 400
                };
            }
            if (updateProfileView.NewPassword != updateProfileView.ConfirmNewPassword)
            {
                return new Response
                {
                    Message = "Password doesn't match with confirm password",
                    Success = false,
                    Data = null,
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
                        Message = message,
                        Success = false,
                        Data = null,
                        StatusCode = 400
                    };
                }
            }
            return new Response
            {
                Message = "User updated successfully!",
                Success = true,
                StatusCode = 204,
                Data = _mapper.Map<CustomerDto>(user)
            };
        }

        public async Task<Response> GetUser()
        {
            var users = await _userManager.Users.Include(o => o.Orders).ToListAsync();
            return new Response
            {
                Data = _mapper.Map<List<CustomerForAdminDto>>(users)
            };
        }

        public async Task<Response> Disable(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(o => o.Id == userId);
            if (user == null)
            {
                return new Response
                {
                    StatusCode = 404,
                    Message = "Don't have any user with this id"
                };
            }
            var lockkoutEndDate = DateTime.UtcNow.AddYears(100);

            await _userManager.SetLockoutEnabledAsync(user, true);
            await _userManager.SetLockoutEndDateAsync(user, lockkoutEndDate);
            return new Response
            {
                Message = "Disable account successful"
            };
        }

        public async Task<Response> Enable(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(o => o.Id == userId);
            if (user == null)
            {
                return new Response
                {
                    StatusCode = 404,
                    Message = "Don't have any user with this id"
                };
            }

            user.LockoutEnabled = false;
            user.LockoutEnd = null;
            await _userManager.UpdateAsync(user);
            return new Response
            {
                Message = "Enable account successful"
            };
        }

        public async Task<Response> Statistics(DateTime fromDate, DateTime toDate)
        {
            var AllOrder = _repoOrder.ReadAll().Count();
            var AllRevenue = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.Delivered && o.Date >= fromDate && o.Date <= toDate) != null).Sum(o => o.SubTotal);


            var OrderCreated = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.New && o.Date >= fromDate && o.Date <= toDate) != null).Count();
            var OrderProcessing = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.Processing && o.Date >= fromDate && o.Date <= toDate) != null).Count();
            var OrderCancel = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.Canceled && o.Date >= fromDate && o.Date <= toDate) != null).Count();
            var OrderShipping = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.Shipping && o.Date >= fromDate && o.Date <= toDate) != null).Count();
            var OrderDelivered = _repoOrder.ReadByCondition(o => o.HistoryStatuses!
                .FirstOrDefault(o => o.Status == Status.Delivered && o.Date >= fromDate && o.Date <= toDate) != null).Count();

            var amountProduct = _repoDetail.ReadAll().Sum(o => o.Quantity);
            var amountGroupByBrand = _repoDetail.ReadAll().Include(o => o.Product).ThenInclude(o => o.Brand).GroupBy(o => o.Product!.Brand).Select(o => new
            {
                Name = o.Key!.Name,
                Id = o.Key.Id,
                Amount = o.Sum(p => p.Quantity)
            }).ToList();
            var amountGroupByCategory = _repoDetail.ReadAll().Include(o => o.Product).ThenInclude(o => o.Category).GroupBy(o => o.Product!.Category).Select(o => new
            {
                Name = o.Key!.Name,
                Id = o.Key.Id,
                Amount = o.Sum(p => p.Quantity)
            }).ToList();

            var data = new
            {
                amountOrder = AllOrder,
                amountProduct = amountProduct,
                amountRevenue = AllRevenue,
                order = new
                {
                    create = OrderCreated,
                    processing = OrderProcessing,
                    cancel = OrderCancel,
                    delivering = OrderShipping,
                    delivered = OrderDelivered
                },
                amountGroupByBrand = amountGroupByBrand,
                amountGroupByCategory = amountGroupByCategory
            };
            return new Response
            {
                Data = data
            };
        }
    }
}
