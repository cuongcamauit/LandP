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
        public DbSet<Document> Documents { get; set; }
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

            builder.Entity<Document>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.Documents)
                        .HasForeignKey(o => o.ProductId);
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

                entity.HasMany(o => o.Documents)
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
                    Id = Guid.Parse("bc17dda5-9e53-434d-ab30-32452bfc7d35"),
                    Name = "Smartphone",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=1VPowiqiVfyuL7Pzntp1mqJV748v34zfb"
                },
                new Category()
                {
                    Id = Guid.Parse("3f8d98cb-a695-4334-bec2-09008670c39a"),
                    Name = "Laptop",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=15Lo6BabMJo7m9p-VSve4kls1pG2VA1AN"
                }
            );
            builder.Entity<Brand>().HasData(
                new Brand()
                {
                    Id = Guid.Parse("2ef43281-9c42-466e-ad66-483ff6f46326"),
                    Name = "Samsung",
                    Description = "A branch from korea",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1JrfIHh1Fi9aM66IMLd2jdZwurx1As6x0"

                },
                new Brand()
                {
                    Id = Guid.Parse("36326612-2d44-446f-87cd-d060d14237a6"),
                    Name = "Apple",
                    Description = "A branch from Ameria",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1DfzKYG8dsu0C0tNK_5U8GNBM3IE92fsz"
                }
            );

            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.Parse("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"),
                    Name = "Samsung Galaxy A23",
                    Description = "Màn hình:\r\n\r\nPLS TFT LCD6.6\"Full HD+\r\nHệ điều hành:\r\n\r\nAndroid 12\r\nCamera sau:\r\n\r\nChính 50 MP & Phụ 5 MP, 2 MP, 2 MP\r\nCamera trước:\r\n\r\n8 MP\r\nChip:\r\n\r\nSnapdragon 680\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n2 Nano SIMHỗ trợ 4G\r\nPin, Sạc:\r\n\r\n5000 mAh25 W",
                    Price = 4990000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL",
                    Unit = "Unit",
                    Quantity = 100,
                    PercentSale = 0,
                    CategoryId = Guid.Parse("bc17dda5-9e53-434d-ab30-32452bfc7d35"),
                    BrandId = Guid.Parse("2ef43281-9c42-466e-ad66-483ff6f46326"),
                    FolderId = "12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn"
                }, 
                new Product()
                {
                    Id = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                    Name = "Iphone 12",
                    Description = "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n2 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A14 Bionic\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n2815 mAh20 W",
                    Price = 15590000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By",
                    Unit = "Unit",
                    Quantity = 50,
                    PercentSale = 20,
                    CategoryId = Guid.Parse("bc17dda5-9e53-434d-ab30-32452bfc7d35"),
                    BrandId = Guid.Parse("36326612-2d44-446f-87cd-d060d14237a6"),
                    FolderId = "1b9JWfgUruHr6j3U3XalWbAD2UO329_6X"
                }
            );

            builder.Entity<Document>().HasData(
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1IzG911rHzKN2p51Ite3JZqDV1FonTt4d",
                    ProductId = Guid.Parse("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"),
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1DeA5LM1HQsUEb9tXUHEg27fWqKenJJDG",
                    ProductId = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1JgLvP6rxTkkkmdWG7RhyqB4nMnaktLE6",
                    ProductId = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1g7NLy-NZE9OTZhH0xctgVXONMNjHpQ4V",
                    ProductId = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1JO-t8NpCi9qb9Jx8pmXbdHMvPg8LQAg3",
                    ProductId = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                }
            );
        }
    }
}
