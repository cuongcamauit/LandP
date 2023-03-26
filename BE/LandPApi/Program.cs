using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Middleware;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
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
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //------------------------------------------------//
            builder.Services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddIdentity<Customer, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
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
            });

            builder.Services.AddScoped(typeof(IRepository<>), typeof(SqlServerRepository<>));
            builder.Services.AddScoped(typeof(IGenericService<,,>), typeof(GenericService<,,>));

            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICartItemService, CartItemService>();
            builder.Services.AddScoped<IHistoryStatusService, HistoryStatusService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IViewService, ViewService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();
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
                build.WithOrigins("https://*:8080", "https://*.3000");
            }));
            builder.WebHost.UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("https://*:7051")
                .UseIISIntegration();

            //=================================================//
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();
            
            app.MapControllers();

            app.UseStaticFiles();

            app.MapRazorPages();

            //app.UseMiddleware<CheckAcessMiddleware>();

            //app.UseCors("myCors");

            app.Run();
        }
    }
}