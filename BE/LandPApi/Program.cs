﻿using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Middleware;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

namespace LandPApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Round((double)2528451 / 23000, 2).ToString());
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //------------------------------------------------//
            builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }, poolSize: 128);
            Console.WriteLine(builder.Configuration["demo"]);
            builder.Services.AddIdentity<Customer, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["AuthSettings:Audience"],
                    ValidIssuer = builder.Configuration["AuthSettings:Issuer"],
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["AuthSettings:Key"])),
                    ValidateIssuerSigningKey = true
                };
            })
            .AddGoogle(googleOptions =>
            {
                // Đọc thông tin Authentication:Google từ appsettings.json
                IConfigurationSection googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");

                // Thiết lập ClientID và ClientSecret để truy cập API google
                googleOptions.ClientId = googleAuthNSection["ClientId"];
                googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
                // Cấu hình Url callback lại từ Google (không thiết lập thì mặc định là /signin-google)
                //googleOptions.CallbackPath = "/dang-nhap-tu-google";
            });

            builder.Services.AddScoped(typeof(IRepository<>), typeof(SqlServerRepository<>));
            builder.Services.AddScoped(typeof(IGenericService<,,>), typeof(GenericService<,,>));

            builder.Services.AddScoped<IAttributeService, AttributeService>();
            builder.Services.AddScoped<IAttributeGroupService, AttributeGroupService>();
            builder.Services.AddScoped<IAttributeOptionService, AttributeOptionService>();
            builder.Services.AddScoped<IAttributeSpeccService, AttributeSpecService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<ICacheService, CacheService>();
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductPriceService, ProductPriceService>();

            builder.Services.AddScoped<ICartItemService, CartItemService>();
            builder.Services.AddScoped<IHistoryStatusService, HistoryStatusService>();
            builder.Services.AddScoped<IMenuService, MenuService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<ISlugService, SlugService>();
            builder.Services.AddScoped<ISlugProductService, SlugProductService>();
            builder.Services.AddScoped<IViewService, ViewService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();
            builder.Services.AddScoped<ICaculateOrderService, CaculateOrderService>();
            builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IMailService, GmailService>();
            builder.Services.AddScoped<IDriveService, GGDriveService>();
            builder.Services.AddScoped<IDocumentService, DocumentService>();


            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddRazorPages();


            builder.Services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = int.MaxValue;
            });

            builder.Services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = int.MaxValue; // if don't set default value is: 30 MB
            });


            builder.Services.AddCors(p => p.AddPolicy("myCors", build =>
            {
                //build.WithOrigins("http://localhost:3000/")
                //        .AllowAnyHeader()
                //        .AllowAnyMethod();
                build.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
            }));
            builder.WebHost.UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("https://*:7051")
                .UseIISIntegration();
            builder.Services.Configure<KestrelServerOptions>(option =>
            {
                option.AllowSynchronousIO = true;
            });
            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            //=================================================//
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("myCors");

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.UseStaticFiles();

            app.MapRazorPages();

            app.UseMiddleware<CheckAcessMiddleware>();

            app.Run();
        }
    }
}