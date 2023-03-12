using LandPApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LandPApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HistoryStatus> HistoryStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LandPApi.Models.View> Views { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Address>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(e => e.Customer)
                .WithMany(o => o.Addresses)
                .HasForeignKey(e => e.CustomerId);
            });

            builder.Entity<Brand>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasMany(o => o.Products)
                        .WithOne(o => o.Brand)
                        .HasForeignKey(o => o.BrandId);
            });

            builder.Entity<CartItem>(entity =>
            {
                entity.HasKey(o => new { o.CustomerId, o.ProductId });

                entity.HasOne(o => o.Customer)
                        .WithMany(o => o.CartItems)
                        .HasForeignKey(o => o.CustomerId);
                entity.HasOne(o => o.Product)
                        .WithMany(o => o.CartItems)
                        .HasForeignKey(o => o.ProductId);
            });

            builder.Entity<Category>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasMany(o => o.Products)
                        .WithOne(o => o.Category)
                        .HasForeignKey(o => o.CategoryId);
            });

            builder.Entity<HistoryStatus>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(o => o.Order)
                        .WithMany(o => o.HistoryStatuses)
                        .HasForeignKey(o => o.OrderId);

                entity.Property(o => o.Status)
                        .HasConversion(new EnumToStringConverter<Status>());
            });

            builder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.Property(o => o.Status)
                         .HasConversion(new EnumToStringConverter<Status>());

                entity.HasOne(o => o.Customer)
                        .WithMany(o => o.Orders)
                        .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.Address)
                        .WithMany(o => o.Orders)
                        .HasForeignKey(o => o.AddressId);

                entity.HasMany(o => o.HistoryStatuses)
                        .WithOne(o => o.Order)
                        .HasForeignKey(o => o.OrderId);

                entity.HasMany(o => o.OrderDetails)
                        .WithOne(o => o.Order)
                        .HasForeignKey(o => o.OrderId);

                entity.HasMany(o => o.Reviews)
                        .WithOne(o => o.Order)
                        .HasForeignKey(o => o.OrderId);

            });

            builder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(o => new {o.OrderId, o.ProductId});

                entity.HasOne(o => o.Order)
                        .WithMany(o => o.OrderDetails)
                        .HasForeignKey(o => o.OrderId);

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.OrderDetails)
                        .HasForeignKey(o => o.ProductId);
            });

            builder.Entity<Product>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasMany(o => o.CartItems)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);

                entity.HasMany(o => o.Views)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);

                entity.HasMany(o => o.OrderDetails)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.Category)
                        .WithMany(o => o.Products)
                        .HasForeignKey(o => o.CategoryId);

                entity.HasOne(o => o.Brand)
                        .WithMany(o => o.Products)
                        .HasForeignKey(o => o.BrandId);

                entity.HasMany(o => o.Reviews)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);
            });
            builder.Entity<Review>(entity =>
            {
                entity.HasKey(o => new { o.CustomerId, o.ProductId});

                entity.HasOne(o => o.Customer)
                        .WithMany(o => o.Reviews)
                        .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.Reviews)
                        .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.Order)
                        .WithMany(o => o.Reviews)
                        .HasForeignKey(o => o.OrderId);
            });

            builder.Entity<LandPApi.Models.View>(entity =>
            {
                entity.HasKey(o => new {o.CustomerId, o.ProductId});

                entity.HasOne(o => o.Customer)
                        .WithMany(o => o.Views)
                        .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.Views)
                        .HasForeignKey(o => o.ProductId);

            });
            SeedRoles(builder);
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "SuperAdmin", ConcurrencyStamp = "0", NormalizedName = "SuperAdmin" },
                    new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                    new IdentityRole() { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Category"
                }
            );
            builder.Entity<Brand>().HasData(
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung"
                }
            );
        }
    }
}
