using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Attribute = LandPApi.Models.Attribute;

namespace LandPApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeGroup> AttributeGroups { get; set; }
        public DbSet<AttributeSpec> AttributeSpecs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HistoryStatus> HistoryStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
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

            builder.Entity<Attribute>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.Property(o => o.Id)
                        .ValueGeneratedOnAdd();

                entity.HasMany(o => o.AttributeGroups)
                        .WithOne(o => o.Attribute)
                        .HasForeignKey(o => o.AttributeId);

                entity.HasMany(o => o.AttributeSpecs)
                        .WithOne(o => o.Attribute)
                        .HasForeignKey(o => o.AttributeId);           
            });

            builder.Entity<AttributeGroup>(entity =>
            {
                entity.HasKey(o => new { o.AttributeId, o.CategoryId });

                entity.HasOne(o => o.Category)
                        .WithMany(o => o.AttributeGroups)
                        .HasForeignKey(o => o.CategoryId);

                entity.HasOne(o => o.Attribute)
                        .WithMany(o => o.AttributeGroups)
                        .HasForeignKey(o => o.AttributeId);
            });

            builder.Entity<AttributeSpec>(entity =>
            {
                entity.HasKey(o => new { o.ProductId, o.AttributeId});

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.AttributeSpecs)
                        .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.Attribute)
                        .WithMany(o => o.AttributeSpecs)
                        .HasForeignKey(o => o.AttributeId);
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
                entity.HasMany(o => o.AttributeGroups)
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

                entity.HasMany(o => o.ProductPrices)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);

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
                entity.HasMany(o => o.AttributeSpecs)
                        .WithOne(o => o.Product)
                        .HasForeignKey(o => o.ProductId);
            });

            builder.Entity<ProductPrice>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id)
                        .ValueGeneratedOnAdd();
                entity.HasOne(o => o.Product)
                        .WithMany(o => o.ProductPrices)
                        .HasForeignKey(o => o.ProductId);
            });


            builder.Entity<Review>(entity =>
            {
                entity.HasKey(o => new { o.CustomerId, o.ProductId, o.OrderId});

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
            var superId = "289f6c6a783e4d89b25c847d1ffa4833";
            var adminId = "43bd8d30-85af-4960-8a9f-d7f7eeeb8571";
            var userId = "04be0c35-571e-425c-992e-15a7227286de";
            var user1Id = "1b0b163d-032f-4e19-9e64-d89bf02f1751";
            var hasher = new PasswordHasher<Customer>();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = superId, Name = "SuperAdmin", ConcurrencyStamp = "0", NormalizedName = "SuperAdmin" },
                new IdentityRole() { Id = adminId, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = userId, Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
            );

            builder.Entity<Customer>().HasData(
                new Customer { Id = superId, Name = "Super Admin", UserName = "landpsupadmika@gmail.com", PasswordHash = hasher.HashPassword(null!, "Superadmin.123"), EmailConfirmed = true, Email = "landpsupadmika@gmail.com", NormalizedEmail = "landpsupadmika@gmail.com" },
                new Customer { Id = adminId, Name = "Admin"      , UserName = "landpadmika@gmail.com"   , PasswordHash = hasher.HashPassword(null!, "Admin.123")     , EmailConfirmed = true, Email = "landpadmika@gmail.com"   , NormalizedEmail = "landpadmika@gmail.com" },
                new Customer { Id = userId , Name = "User"       , UserName = "landpuserdemo@gmail.com" , PasswordHash = hasher.HashPassword(null!, "Userdemo.123")  , EmailConfirmed = true, Email = "landpuserdemo@gmail.com" , NormalizedEmail = "landpuserdemo@gmail.com" },
                new Customer { Id = user1Id, Name = "User1"      , UserName = "landpuserdemo1@gmail.com", PasswordHash = hasher.HashPassword(null!, "Userdemo1.123") , EmailConfirmed = true, Email = "landpuserdemo1@gmail.com", NormalizedEmail = "landpuserdemo1@gmail.com"}
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = superId, UserId = superId },
                new IdentityUserRole<string> { RoleId = adminId, UserId = adminId},
                new IdentityUserRole<string> { RoleId = userId, UserId = userId},
                new IdentityUserRole<string> { RoleId = userId, UserId = user1Id}
            );
            var addresuserId = Guid.Parse("0750d8d3-bfff-45f2-b081-2a86ffe91bfd");
            var addresuser1Id = Guid.Parse("3fd64b58-5ded-40ed-876c-027bcc759a75");
            builder.Entity<Address>().HasData(
                new Address { Id = addresuserId, CustomerId = userId, Province = "Cà Mau", District = "Thành phố Cà Mau", Ward = "8", Detail = "5"},    
                new Address { Id = addresuser1Id, CustomerId = user1Id, Province = "Thành phố Hồ Chí Minh", District = "12", Ward = "Tân Chánh Hiệp", Detail = "Tô Ký"}    
            );
            //----------------------------------------------------------//
            var smartphoneId = Guid.Parse("bc17dda5-9e53-434d-ab30-32452bfc7d35");
            var laptopId = Guid.Parse("3f8d98cb-a695-4334-bec2-09008670c39a");
            var tabletId = Guid.Parse("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2");
            var smartwatchId = Guid.Parse("3649b208-05c6-4129-86bd-df77801d3d39");
            var mouseId = Guid.Parse("76f4c144-6e3f-44bf-a292-8dd21a461b5d");

            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = smartphoneId,
                    Name = "Smartphone",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=1VPowiqiVfyuL7Pzntp1mqJV748v34zfb"
                },
                new Category()
                {
                    Id = laptopId,
                    Name = "Laptop",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=15Lo6BabMJo7m9p-VSve4kls1pG2VA1AN"
                },
                new Category()
                {
                    Id = tabletId,
                    Name = "Tablet",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=1EHDwKK-pKe78N_-Ns3RhID7Wg3S2nmDP"
                },
                new Category()
                {
                    Id = smartwatchId,
                    Name = "Smartwatch",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=1y_ap3ooVR_djmamFvklsm0tx-d9Zrt3V"
                },
                new Category()
                {
                    Id = mouseId,
                    Name = "Mouse",
                    Description = "A smart device",
                    AvatarUrl = "https://drive.google.com/uc?export=view&id=1N6u8HMtyTtdXWGBxz5AFRzk2KbvB6aVc"
                }
            );

            var xiaomiId = Guid.Parse("32a244dc-528a-402a-b8e0-d86b31f0b8cb");
            var samsungId = Guid.Parse("2ef43281-9c42-466e-ad66-483ff6f46326");
            var appleId = Guid.Parse("36326612-2d44-446f-87cd-d060d14237a6");
            var asusId = Guid.Parse("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e");
            var dellId = Guid.Parse("04d63fc1-582a-4ad3-9132-b531101220ca");
            var suuntoId = Guid.Parse("2d750aa2-ea06-47ea-916c-abb6661f9781");
            var logitechId = Guid.Parse("fc1a0ff3-92d8-4a16-adb5-8c901bbe48f2");

            builder.Entity<Brand>().HasData(
                new Brand()
                {
                    Id = samsungId,
                    Name = "Samsung",
                    Description = "A branch from korea",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1JrfIHh1Fi9aM66IMLd2jdZwurx1As6x0"

                },
                new Brand()
                {
                    Id = appleId,
                    Name = "Apple",
                    Description = "A branch from Ameria",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1DfzKYG8dsu0C0tNK_5U8GNBM3IE92fsz"
                },
                new Brand()
                {
                    Id = xiaomiId,
                    Name = "Xiaomi",
                    Description = "A branch from China",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1WGo9ev5XnfDETamxPvTVaJJuAYr892Nf"
                },
                new Brand()
                {
                    Id = asusId,
                    Name = "Assus",
                    Description = "A branch from China",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1CYKkazDIXzIw_q6ioPB8NlgZTjnhor-N"
                },
                new Brand()
                {
                    Id = dellId,
                    Name = "Dell",
                    Description = "A branch from China",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1Q0u1RB9SfYkxXXmF2s9CPyTXKVY4IN1A"
                },
                new Brand()
                {
                    Id = suuntoId,
                    Name = "Suunto",
                    Description = "A branch from China",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1T3galDlqvff5zyZd8kf19McJK9V7iAvL"
                },
                new Brand()
                {
                    Id = logitechId,
                    Name = "Logitech",
                    Description = "A branch from China",
                    LogoUrl = "https://drive.google.com/uc?export=view&id=1F9Sn87qp9kkJbbANHNKSXoE6pYwLPVz-"
                }
            );
            //------------------------------------------------------------//

            var ssa23Id = Guid.Parse("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04");
            var ip12Id = Guid.Parse("257c3301-487b-4c18-bc3d-21ffb71a4d43");
            var xiaominote12pro5gId = Guid.Parse("13c2386e-1348-42ef-8de1-46d7515eb3df");
            var xiaomi12t5gId = Guid.Parse("c2c75508-8eac-47de-a3fa-43c44ce8e917");
            var tuff15Id = Guid.Parse("5d7beeaf-f51e-44bb-ae26-aadb1bdc0276");
            var vostro3510Id = Guid.Parse("d5682976-7d8c-4549-884c-e85f73ddbed3");
            var ipad9Id = Guid.Parse("3e9d9046-0534-44cf-a0fa-746a31acad9f");
            var ipad10Id = Guid.Parse("13461ff9-0374-4101-a88e-a01dff5f1d8e");
            var suunto7Id = Guid.Parse("7d7b21dd-b2fe-4179-8238-e871f52fcb2a");
            var galaxywatch5Id = Guid.Parse("777ffbe5-1f43-4b6c-80d3-6b3cffbcb721");
            var logitecgm650Id = Guid.Parse("61a1dce1-164c-4a2f-a6e1-6397c5033bfb");

            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = ssa23Id,
                    Name = "Samsung Galaxy A23",
                    Description = "Màn hình:\r\n\r\nPLS TFT LCD6.6\"Full HD+\r\nHệ điều hành:\r\n\r\nAndroid 12\r\nCamera sau:\r\n\r\nChính 50 MP & Phụ 5 MP, 2 MP, 2 MP\r\nCamera trước:\r\n\r\n8 MP\r\nChip:\r\n\r\nSnapdragon 680\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n2 Nano SIMHỗ trợ 4G\r\nPin, Sạc:\r\n\r\n5000 mAh25 W",
                    Price = 4990000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL",
                    
                    Quantity = 100,
                    //PercentSale = 0,
                    CategoryId = smartphoneId,
                    BrandId = samsungId,
                    FolderId = "12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn"
                }, 
                new Product()
                {
                    Id = ip12Id,
                    Name = "Iphone 12",
                    Description = "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n2 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A14 Bionic\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n2815 mAh20 W",
                    Price = 15590000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By",
                    
                    Quantity = 50,
                    //PercentSale = 20,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1b9JWfgUruHr6j3U3XalWbAD2UO329_6X"
                },
                new Product()
                {
                    Id = xiaominote12pro5gId,
                    Name = "Xiaomi Redmi Note 12 Pro 5G",
                    Description = "Xiaomi Redmi Note 12 Pro 5G là mẫu điện thoại thuộc dòng Redmi Note được chính thức ra mắt trong năm 2023, máy mang trên mình những cải tiến vượt trội về thiết kế, camera và hiệu năng, đáp ứng mượt mà hầu hết các nhu cầu khác nhau của người dùng.",
                    Price = 9960000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=190zjmRvUnsTZdB4iDizNBjqKI_fk5L3a",
                    
                    Quantity = 50,
                    //PercentSale = 2,
                    BrandId = xiaomiId,
                    CategoryId = smartphoneId,
                    FolderId = "1gBdpMXybH0HOxSKI6g9AdmisL9IUMfPq"
                },
                new Product()
                {
                    Id = xiaomi12t5gId,
                    Name = "Xiaomi 12T 5G 128GB",
                    Description = "Xiaomi 12T series đã ra mắt trong sự kiện của Xiaomi vào ngày 4/10, trong đó có Xiaomi 12T 5G 128GB - máy sở hữu nhiều công nghệ hàng đầu trong giới smartphone tiêu biểu như: Chipset mạnh mẽ đến từ MediaTek, camera 108 MP sắc nét cùng khả năng sạc 120 W siêu nhanh.",
                    Price = 9890000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=165CbvBDjo8PPjxn2MPHVe2YrZPZ1oCwd",
                    
                    Quantity = 3,
                    //PercentSale = 0,
                    BrandId = xiaomiId,
                    CategoryId = smartphoneId,
                    FolderId = "1RvQvCVJ2wk72oMqDuYfeuTBHSIHNhplS"
                },
                new Product()
                {
                    Id = tuff15Id,
                    Name = "TUF Gaming F15",
                    Description = "Nếu bạn đang tìm kiếm một chiếc laptop gaming nhưng vẫn sở hữu một mức giá phải chăng thì laptop Asus TUF Gaming F15 FX506LHB i5 (HN188W) sẽ là sự lựa chọn đáng cân nhắc với card đồ họa rời NVIDIA GeForce GTX mạnh mẽ cùng phong cách thiết kế cứng cáp, độc đáo. ",
                    Price = 16990000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1s_UzQewLQ4zb7cX25cwUYAlVa3CpuCP9",
                    
                    Quantity = 50,
                    //PercentSale = 0,
                    BrandId = asusId,
                    CategoryId = laptopId,
                    FolderId = "1504cqv26tU1E4JAWix9Ajxwh3XCH8tOv"
                },
                new Product()
                {
                    Id = vostro3510Id,
                    Name = "Dell Vostro 3510",
                    Description = "Laptop Dell Vostro 3510 i5 (P112F002BBL) sở hữu cấu hình mạnh mẽ, đa nhiệm mượt mà trên sức mạnh của bộ vi xử lý Intel thế hệ 11, cùng một thiết kế đơn giản mà sang đẹp, sẽ là lựa chọn đắt giá đáp ứng nhu cầu học tập, làm việc hay giải trí của bạn.",
                    Price = 17990000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1ELd9fd2dk2meSyxz-hVnsIp8_gFrnHxp",
                    
                    Quantity = 10,
                    //PercentSale = 20,
                    BrandId = dellId,
                    CategoryId = laptopId,
                    FolderId = "1R9qzBw6zNwBARHF8aGu2_qJYlil161yl"
                },
                new Product()
                {
                    Id = ipad9Id,
                    Name = "iPad 9",
                    Description = "Sau thành công của iPad 8, Apple cho đã cho ra mắt máy tính bảng iPad 9 WiFi 64GB - phiên bản tiếp theo của dòng iPad 10.2 inch, về cơ bản nó kế thừa những điểm mạnh từ các phiên bản trước đó và được cải tiến thêm hiệu suất, trải nghiệm người dùng nhằm giúp nhu cầu sử dụng giải trí và làm việc tiện lợi, linh hoạt hơn",
                    Price = 7990000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1IK5bpXd3iGWJbMDOS5c_zG5Zk5th3hhl",
                    Quantity = 10,
                    //PercentSale = 0,
                    BrandId = appleId,
                    CategoryId = tabletId,
                    FolderId = "1SZ3o96HmpNycsXIeOzuXBDF3dgh6v85o"
                },
                new Product()
                {
                    Id = ipad10Id,
                    Name = "iPad 10",
                    Description = "Sau khi trình làng hàng loạt mẫu iPhone vào tháng 09/2022 thì Apple cũng đã tiếp tục giới thiệu series iPad mới cho năm 2022. Trong đó iPad 10 WiFi 64GB là cái tên được hãng chú trọng khá nhiều về việc tối ưu giá thành nhằm giúp người dùng có thể dễ dàng tiếp cận. Máy hỗ trợ hệ điều hành iPadOS 16 cùng con chip Apple A14 Bionic giúp mang lại hiệu năng vượt trội.",
                    Price = 11190000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1PjgSj70e2Oc1GC-DJBiVkzs77mAdEokF",
                    Quantity = 10,
                    //PercentSale = 2,
                    BrandId = appleId,
                    CategoryId = tabletId,
                    FolderId = "18kx0xh8gVJAJllf-4ZVeFZFfkJHI1zkX"
                },
                new Product()
                {
                    Id = suunto7Id,
                    Name = "Suunto 7",
                    Description = "Đồng hồ thông minh Suunto 7 Dây silicone phiên bản màu đen trang bị mặt kính cường lực chống va đập, màn hình AMOLED 1.97 inch (454 x 454 pixels) cùng độ sáng lên tới 1000 nits, vì thế có thể hiển thị sắc nét ngay cả khi ở điều kiện có ánh sáng mặt trời. Đặc biệt, với thiết kế dây đeo silicone tạo cảm giác mềm mại và dễ chịu khi đeo trong thời gian dài.",
                    Price = 7250000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1-nQviihO_G_HGipaWd72aRUURK4zkm6S",
                    Quantity = 5,
                    //PercentSale = 0,
                    BrandId = suuntoId,
                    CategoryId = smartwatchId,
                    FolderId = "15B4NY2lAFY9DXr1Z40hwoQNjI5ZjnpZ4"
                },
                new Product()
                {
                    Id = galaxywatch5Id,
                    Name = "Samsung Galaxy Watch5",
                    Description = "Sau thành công của dòng Galaxy Watch4, tháng 8/2022 ông lớn công nghệ Samsung đã cho ra mắt thế hệ smartwatch tiếp theo của hãng mang tên Samsung Galaxy Watch5 40 mm.",
                    Price = 5490000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=17uBw10YiFMD2ET9pw_wiXkznPsQrAhr0",
                    Quantity = 10,
                    //PercentSale = 0,
                    BrandId = samsungId,
                    CategoryId = smartwatchId,
                    FolderId = "1v5XPVE3A_7XnX4yUf8OekLE54mHXr_CZ"
                },
                new Product()
                {
                    Id = logitecgm650Id,
                    Name = "Bluetooth Silent Logitech Signature M650",
                    Description = "Chuột Không dây Bluetooth Silent Logitech Signature M650 sở hữu kiểu dáng công thái học cùng độ phân giải lớn, đáp ứng tốt gần như mọi nhu cầu từ sử dụng cơ bản tới những tác vụ chuyên nghiệp của người dùng.",
                    Price = 765000,
                    ImageUrl = "https://drive.google.com/uc?export=view&id=1ukyWOlXUIJzxVzjmNN5hPlrnHN0yET7b",
                    Quantity = 10,
                    //PercentSale = 0,
                    BrandId = logitechId,
                    CategoryId = mouseId,
                    FolderId = "1M0-dUHbo7g_pkLPbQu9NMTPc9tnGkwr7"
                },
                ///--------------------------------------//
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Laptop Asus Gaming ROG Strix G15",
                    Description = "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. " ,
                    Price = 22990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg",
                    Quantity = 50,
                    //PercentSale = 10,
                    CategoryId = laptopId,
                    BrandId = asusId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus Gaming ROG Strix SCAR 15 G533ZM ",
                    Description = "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.",
                    Price = 37490000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg",
                    Quantity = 40,
                    //PercentSale = 20,
                    CategoryId = laptopId,
                    BrandId = asusId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus Gaming ROG Strix SCAR 17 G733PZ ",
                    Description = "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất." ,
                    Price = 84000000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg",
                    Quantity = 10,
                    //PercentSale = 10,
                    CategoryId = laptopId,
                    BrandId = asusId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus Zenbook 14 Flip OLED UP3404VA ",
                    Description = "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ",
                    Price = 31990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg",
                    Quantity = 10,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = asusId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus Vivobook S 14 Flip TP3402VA ",
                    Description = "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn." ,
                    Price = 20990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg",
                    Quantity = 20,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = asusId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 16 5620",
                    Description = "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên." ,
                    Price = 21990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg",
                    Quantity = 20,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Gaming Alienware m15 R6 ",
                    Description = "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game." ,
                    Price = 47490000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg",
                    Quantity = 20,
                    //PercentSale = 10,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Gaming G15 5511 ",
                    Description = "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường." ,
                    Price = 21990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg",
                    Quantity = 30,
                    //PercentSale = 2,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 15 5515",
                    Description = "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng." ,
                    Price = 17990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg",
                    Quantity = 10,
                    //PercentSale = 3,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 15 3520",
                    Description = "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng." ,
                    Price = 16990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg",
                    Quantity = 30,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 15 3511",
                    Description = "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên." ,
                    Price = 12690000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg",
                    Quantity = 10,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 15 3511",
                    Description = "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên." ,
                    Price = 12690000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg",
                    Quantity = 10,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Dell Inspiron 15 3511",
                    Description = "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên." ,
                    Price = 12690000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg",
                    Quantity = 10,
                    //PercentSale = 5,
                    CategoryId = laptopId,
                    BrandId = dellId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 14 Pro Max 1TB",
                    Description = "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.",
                    Price = 51990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg",
                    Quantity = 10,
                    //PercentSale = 20,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 14 Pro Max",
                    Description = "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.",
                    Price = 27990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg",
                    Quantity = 20,
                    //PercentSale = 15,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 14 Pro",
                    Description = "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.",
                    Price = 24990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg",
                    Quantity = 10,
                    //PercentSale = 13,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 14 ",
                    Description = "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.",
                    Price = 19990000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg",
                    Quantity = 10,
                    //PercentSale = 5,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 14 Plus",
                    Description = "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.",
                    Price = 21890000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg",
                    Quantity = 15,
                    //PercentSale = 5,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 13 ",
                    Description = "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.",
                    Price = 17000000,
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg",
                    Quantity = 25,
                    //PercentSale = 20,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                }

            );

            builder.Entity<LandPApi.Models.View>().HasData(
                new Models.View
                {
                    CustomerId = userId,
                    ProductId = xiaomi12t5gId
                },
                new Models.View
                {
                    CustomerId = userId,
                    ProductId = xiaominote12pro5gId
                }, 
                new Models.View
                {
                    CustomerId = user1Id,
                    ProductId = xiaomi12t5gId
                }, 
                new Models.View
                {
                    CustomerId = user1Id,
                    ProductId = xiaominote12pro5gId
                }, 
                new Models.View
                {
                    CustomerId = user1Id,
                    ProductId = suunto7Id
                },
                new Models.View
                {
                    CustomerId = user1Id,
                    ProductId = ssa23Id
                }
            );

            var order1 = Guid.Parse("cd9218db-08c0-4af8-9058-0ac6cf7d58b9");
            var order2 = Guid.Parse("6925f34b-4021-4fe9-9155-88b9e0df0678");
            var order3 = Guid.Parse("5470e410-d659-4cdc-b84b-bb174a67a2bf");
            var order4 = Guid.NewGuid();
            var order5 = Guid.NewGuid();
            var order6 = Guid.NewGuid();
            var order7 = Guid.NewGuid();
            var order8 = Guid.NewGuid();
            var order9 = Guid.NewGuid();
            var order10 = Guid.NewGuid();
            var order11 = Guid.NewGuid();
            
            builder.Entity<Order>().HasData(
                new Order
                {
                    Id = order1,
                    CustomerId = userId,
                    AddressId = addresuserId,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 67640200,
                },
                new Order
                {
                    Id = order2,
                    CustomerId = userId,
                    AddressId = addresuserId,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 56154400,
                },
                new Order
                {
                    Id = order3,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 58364800,
                },
                new Order
                {
                    Id = order4,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order5,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order6,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order7,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order8,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order9,
                    CustomerId = user1Id,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order10,
                    CustomerId = userId,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                },
                new Order
                {
                    Id = order11,
                    CustomerId = userId,
                    AddressId = addresuser1Id,
                    PaidAt = DateTime.Now,
                    Status = Status.Delivered,
                    Total = 7250000,
                }
            );

            builder.Entity<OrderDetail>().HasData(
                new OrderDetail
                {
                    OrderId = order1,
                    ProductId = ssa23Id,
                    Quantity = 2,
                    Price = 4990000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order1,
                    ProductId = ip12Id,
                    Quantity = 2,
                    Price = 15590000,
                    //PercentSale = 20
                },
                new OrderDetail
                {
                    OrderId = order1,
                    ProductId = ipad10Id,
                    Quantity = 1,
                    Price = 11190000,
                    //PercentSale = 2
                },
                new OrderDetail
                {
                    OrderId = order1,
                    ProductId = suunto7Id,
                    Quantity = 3,
                    Price = 7250000,
                    //PercentSale = 0
                },

                //----------------------------//
                new OrderDetail
                {
                    OrderId = order2,
                    ProductId = ip12Id,
                    Quantity = 1,
                    Price = 15590000,
                    //PercentSale = 20
                },
                new OrderDetail
                {
                    OrderId = order2,
                    ProductId = ipad10Id,
                    Quantity = 2,
                    Price = 11190000,
                    //PercentSale = 2
                },
                new OrderDetail
                {
                    OrderId = order2,
                    ProductId = suunto7Id,
                    Quantity = 3,
                    Price = 7250000,
                    //PercentSale = 0
                },

                //-----------------//
                new OrderDetail
                {
                    OrderId = order3,
                    ProductId = ipad10Id,
                    Quantity = 4,
                    Price = 11190000,
                    //PercentSale = 2
                },
                new OrderDetail
                {
                    OrderId = order4,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order5,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order6,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order7,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order8,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order9,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order10,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                },
                new OrderDetail
                {
                    OrderId = order11,
                    ProductId = suunto7Id,
                    Quantity = 2,
                    Price = 7250000,
                    //PercentSale = 0
                }
            );

            builder.Entity<HistoryStatus>().HasData(
                new HistoryStatus
                {
                    OrderId = order1,
                    Id = Guid.NewGuid(),
                    Status = Status.New,
                },
                new HistoryStatus
                {
                    OrderId = order1,
                    Id = Guid.NewGuid(),
                    Status = Status.Processing,
                },
                new HistoryStatus
                {
                    OrderId = order1,
                    Id = Guid.NewGuid(),
                    Status = Status.Shipping,
                },
                new HistoryStatus
                {
                    OrderId = order1,
                    Id = Guid.NewGuid(),
                    Status = Status.Delivered,
                },
                //--------//
                new HistoryStatus
                {
                    OrderId = order2,
                    Id = Guid.NewGuid(),
                    Status = Status.New,
                },
                new HistoryStatus
                {
                    OrderId = order2,
                    Id = Guid.NewGuid(),
                    Status = Status.Processing,
                },
                new HistoryStatus
                {
                    OrderId = order2,
                    Id = Guid.NewGuid(),
                    Status = Status.Shipping,
                },
                new HistoryStatus
                {
                    OrderId = order2,
                    Id = Guid.NewGuid(),
                    Status = Status.Delivered,
                },
                //-----//
                new HistoryStatus
                {
                    OrderId = order3,
                    Id = Guid.NewGuid(),
                    Status = Status.New,
                },
                new HistoryStatus
                {
                    OrderId = order3,
                    Id = Guid.NewGuid(),
                    Status = Status.Processing,
                },
                new HistoryStatus
                {
                    OrderId = order3,
                    Id = Guid.NewGuid(),
                    Status = Status.Shipping,
                },
                new HistoryStatus
                {
                    OrderId = order3,
                    Id = Guid.NewGuid(),
                    Status = Status.Delivered,
                }
            );

            builder.Entity<Review>().HasData(
                new Review
                {
                    CustomerId = userId,
                    OrderId = order1,
                    ProductId = ssa23Id,
                    Comment = "Good",
                    Rating = 5                    
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order1,
                    ProductId = ipad10Id,
                    Comment = "More than expected!",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order1,
                    ProductId = suunto7Id,
                    Comment = "Wonderful",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order1,
                    ProductId = ip12Id,
                    Comment = "Ok",
                    Rating = 4
                },

                //-------//
                new Review
                {
                    CustomerId = userId,
                    OrderId = order2,
                    ProductId = ipad10Id,
                    Comment = "More than expected!",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order2,
                    ProductId = suunto7Id,
                    Comment = "Wonderful",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order2,
                    ProductId = ip12Id,
                    Comment = "Ok",
                    Rating = 4
                },
                //---//
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order3,
                    ProductId = suunto7Id,
                    Comment = "Ổn trong tầm giá",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order4,
                    ProductId = suunto7Id,
                    Comment = "Wonderful",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order5,
                    ProductId = suunto7Id,
                    Comment = "Ok",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order6,
                    ProductId = suunto7Id,
                    Comment = "No problem",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order7,
                    ProductId = suunto7Id,
                    Comment = "So expensive",
                    Rating = 1
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order8,
                    ProductId = suunto7Id,
                    Comment = "worth the money",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = user1Id,
                    OrderId = order9,
                    ProductId = suunto7Id,
                    Comment = "Comfortable",
                    Rating = 4
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order10,
                    ProductId = suunto7Id,
                    Comment = "Product beauty",
                    Rating = 5
                },
                new Review
                {
                    CustomerId = userId,
                    OrderId = order11,
                    ProductId = suunto7Id,
                    Comment = "More than expected",
                    Rating = 3
                }
            );


            builder.Entity<Document>().HasData(
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1IzG911rHzKN2p51Ite3JZqDV1FonTt4d",
                    ProductId = ssa23Id,
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1DeA5LM1HQsUEb9tXUHEg27fWqKenJJDG",
                    ProductId = ip12Id,
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1JgLvP6rxTkkkmdWG7RhyqB4nMnaktLE6",
                    ProductId = ip12Id,
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1g7NLy-NZE9OTZhH0xctgVXONMNjHpQ4V",
                    ProductId = ip12Id,
                },
                new Document
                {
                    Id = "https://drive.google.com/uc?export=view&id=1JO-t8NpCi9qb9Jx8pmXbdHMvPg8LQAg3",
                    ProductId = ip12Id,
                }
            );


           

        }
    }
}
