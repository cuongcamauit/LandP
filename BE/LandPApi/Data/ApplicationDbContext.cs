using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Service;
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
                    PercentSale = 0,
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
                    PercentSale = 20,
                    CategoryId = smartphoneId,
                    BrandId = samsungId,
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
                    PercentSale = 2,
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
                    PercentSale = 0,
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
                    PercentSale = 0,
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
                    PercentSale = 20,
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
                    PercentSale = 0,
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
                    PercentSale = 2,
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
                    PercentSale = 0,
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
                    PercentSale = 0,
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
                    PercentSale = 0,
                    BrandId = logitechId,
                    CategoryId = mouseId,
                    FolderId = "1M0-dUHbo7g_pkLPbQu9NMTPc9tnGkwr7"
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
