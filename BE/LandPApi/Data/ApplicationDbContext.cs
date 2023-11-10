using LandPApi.Models;
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
        public DbSet<AttributeOption> AttributeOptions { get; set; }
        public DbSet<AttributeSpec> AttributeSpecs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HistoryStatus> HistoryStatuses { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Slug> Slugs { get; set; }
        public DbSet<SlugProduct> SlugProducts { get; set; }
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

                entity.HasMany(o => o.AttributeOptions)
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

            builder.Entity<AttributeOption>(entity =>
            {
                entity.HasKey(o => new { o.Id, o.AttributeId });

                entity.HasOne(o => o.Attribute)
                        .WithMany(o => o.AttributeOptions)
                        .HasForeignKey(o => o.AttributeId);

                entity.HasMany(o => o.AttributeSpecs)
                        .WithOne(o => o.Option)
                        .HasForeignKey(o => new { o.OptionID, o.AttributeId });
            });

            builder.Entity<AttributeSpec>(entity =>
            {
                entity.HasKey(o => new { o.ProductId, o.AttributeId });

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.AttributeSpecs)
                        .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.Attribute)
                        .WithMany(o => o.AttributeSpecs)
                        .HasForeignKey(o => o.AttributeId);

                entity.HasOne(o => o.Option)
                        .WithMany(o => o.AttributeSpecs)
                        .HasForeignKey(o => new { o.OptionID, o.AttributeId });
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

            builder.Entity<Menu>(entity =>
            {
                entity.HasKey(o => o.slugId);

                entity.HasOne(o => o.Slug)
                        .WithOne(o => o.Menu)
                        .HasForeignKey<Menu>(o => o.slugId);

                entity.HasOne(o => o.ParentMenu)
                        .WithMany(o => o.ChildrenMenu)
                        .HasForeignKey(o => o.ParentId)
                        .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasMany(o => o.ChildrenMenu)
                        .WithOne(o => o.ParentMenu)
                        .HasForeignKey(o => o.ParentId)
                        .OnDelete(DeleteBehavior.ClientSetNull);

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
                entity.HasKey(o => new { o.OrderId, o.ProductId });

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

                entity.HasMany(o => o.SlugProducts)
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
                entity.HasKey(o => new { o.CustomerId, o.ProductId, o.OrderId });

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

            builder.Entity<Slug>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasMany(o => o.SlugProducts)
                        .WithOne(o => o.Slug)
                        .HasForeignKey(o => o.SlugId);

                entity.HasOne(o => o.Menu)
                        .WithOne(o => o.Slug)
                        .HasForeignKey<Slug>(o => o.MenuId)
                        .IsRequired(false);
            });


            builder.Entity<SlugProduct>(entity =>
            {
                entity.HasKey(o => new { o.SlugId, o.ProductId });

                entity.HasOne(o => o.Product)
                        .WithMany(o => o.SlugProducts)
                        .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.Slug)
                        .WithMany(o => o.SlugProducts)
                        .HasForeignKey(o => o.SlugId);
            });

            builder.Entity<LandPApi.Models.View>(entity =>
            {
                entity.HasKey(o => new { o.CustomerId, o.ProductId });

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
                new Customer { Id = adminId, Name = "Admin", UserName = "landpadmika@gmail.com", PasswordHash = hasher.HashPassword(null!, "Admin.123"), EmailConfirmed = true, Email = "landpadmika@gmail.com", NormalizedEmail = "landpadmika@gmail.com" },
                new Customer { Id = userId, Name = "User", UserName = "landpuserdemo@gmail.com", PasswordHash = hasher.HashPassword(null!, "Userdemo.123"), EmailConfirmed = true, Email = "landpuserdemo@gmail.com", NormalizedEmail = "landpuserdemo@gmail.com" },
                new Customer { Id = user1Id, Name = "User1", UserName = "landpuserdemo1@gmail.com", PasswordHash = hasher.HashPassword(null!, "Userdemo1.123"), EmailConfirmed = true, Email = "landpuserdemo1@gmail.com", NormalizedEmail = "landpuserdemo1@gmail.com" }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = superId, UserId = superId },
                new IdentityUserRole<string> { RoleId = adminId, UserId = adminId },
                new IdentityUserRole<string> { RoleId = userId, UserId = userId },
                new IdentityUserRole<string> { RoleId = userId, UserId = user1Id }
            );
            var addresuserId = Guid.Parse("0750d8d3-bfff-45f2-b081-2a86ffe91bfd");
            var addresuser1Id = Guid.Parse("3fd64b58-5ded-40ed-876c-027bcc759a75");
            builder.Entity<Address>().HasData(
                new Address { Id = addresuserId, CustomerId = userId, ProvinceName = "Cà Mau", ProvinceId = 252, DistrictName = "Thành phố Cà Mau", DistrictId = 1654, WardName = "8", WardCode = "610107", Detail = "Khóm 5" },
                new Address { Id = addresuser1Id, CustomerId = user1Id, ProvinceName = "Thành phố Hồ Chí Minh", ProvinceId = 202, DistrictName = "Quận 12", DistrictId = 1454, WardName = "Phường Tân Chánh Hiệp", WardCode = "21204", Detail = "Đường Tô Ký" }
            );
            //----------------------------------------------------------//
            var smartphoneId = Guid.Parse("bc17dda5-9e53-434d-ab30-32452bfc7d35");
            var laptopId = Guid.Parse("3f8d98cb-a695-4334-bec2-09008670c39a");
            var tabletId = Guid.Parse("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2");
            var smartwatchId = Guid.Parse("3649b208-05c6-4129-86bd-df77801d3d39");

            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = smartphoneId,
                    Name = "Smartphone",
                    Description = "A smart device",
                    AvatarUrl = ""
                },
                new Category()
                {
                    Id = laptopId,
                    Name = "Laptop",
                    Description = "A smart device",
                    AvatarUrl = ""
                },
                new Category()
                {
                    Id = tabletId,
                    Name = "Tablet",
                    Description = "A smart device",
                    AvatarUrl = ""
                },
                new Category()
                {
                    Id = smartwatchId,
                    Name = "Smartwatch",
                    Description = "A smart device",
                    AvatarUrl = ""
                }
            );

            var appleId = Guid.Parse("36326612-2d44-446f-87cd-d060d14237a6");
            var asusId = Guid.Parse("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e");
            var accerId = Guid.Parse("fc6fcd3e-f156-4a33-a257-c92adfba2c63");
            var dellId = Guid.Parse("04d63fc1-582a-4ad3-9132-b531101220ca");
            var xiaomiId = Guid.Parse("32a244dc-528a-402a-b8e0-d86b31f0b8cb");
            var samsungId = Guid.Parse("2ef43281-9c42-466e-ad66-483ff6f46326");

            builder.Entity<Brand>().HasData(
                new Brand()
                {
                    Id = samsungId,
                    Name = "Samsung",
                    Description = "Samsung Group or Samsung (Korean: 삼성, Roma: Samseong, Hanja: 三星; Sino-Vietnamese: Tam Tinh - 3 stars) is a South Korean multinational corporation headquartered in Samsung Town, Seocho , Seoul",
                    LogoUrl = ""
                },
                new Brand()
                {
                    Id = appleId,
                    Name = "Apple",
                    Description = "Apple is a large American technology corporation headquartered in Cupertino, California. Apple was founded on April 1, 1976 by three founders Steve Wozniak, Steve Jobs and Ronald Wayne, under the original name Apple Computer Inc, then changed its name to Apple in early 2007",
                    LogoUrl = ""
                },
                new Brand()
                {
                    Id = xiaomiId,
                    Name = "Xiaomi",
                    Description = "Xiaomi is a Chinese technology corporation , headquartered in Beijing. Considered the Apple of China, after only 5 years of establishment, Xiaomi has become the smartphone manufacturer with the 5th largest market share in the world and 1st in its home market (2015)",
                    LogoUrl = ""
                },
                new Brand()
                {
                    Id = asusId,
                    Name = "Assus",
                    Description = "In 2015 and 2016, Fortune magazine recognized ASUS as one of the world's most popular companies, and for the past four years, Interbrand has ranked ASUS as Taiwan's most valuable international brand . Loan",
                    LogoUrl = ""
                },
                new Brand()
                {
                    Id = dellId,
                    Name = "Dell",
                    Description = "Dell Inc is an American multinational company that develops and commercializes computer technology headquartered in Round Rock, Texas, United States. In 1984, Dell was founded by Michael Dell. It is the 28th largest company by revenue in the United States",
                    LogoUrl = ""
                },
                new Brand()
                {
                    Id = accerId,
                    Name = "Acer",
                    Description = "Founded in 1976, Acer is a Taiwanese multinational corporation of electronics and computer hardware",
                    LogoUrl = ""
                }
            );
            //------------------------------------------------------------//

            var macpro16 = Guid.NewGuid();
            var macair15 = Guid.NewGuid();
            var macair2020 = Guid.NewGuid();
            var macair2022_1 = Guid.NewGuid();
            var macair2022_2 = Guid.NewGuid();
            var macpro13 = Guid.NewGuid();

            var acer16 = Guid.NewGuid();
            var acerasp15 = Guid.NewGuid();
            var acernitro5 = Guid.NewGuid();

            var asus1 = Guid.NewGuid();
            var asus2 = Guid.NewGuid();
            var asus3 = Guid.NewGuid();

            var dellins15 = Guid.NewGuid();
            var dellins3530 = Guid.NewGuid();
            var dellins14 = Guid.NewGuid();
            var dellins16 = Guid.NewGuid();
            var dellvos3430 = Guid.NewGuid();
            var dellins142 = Guid.NewGuid();

            var ip15pm = Guid.NewGuid();
            var ip13 = Guid.NewGuid();
            var ip13mn = Guid.NewGuid();
            var ip14pm = Guid.NewGuid();
            var ip15p = Guid.NewGuid();
            var ip14 = Guid.NewGuid();

            var ssa05 = Guid.NewGuid();
            var xiaomi12c = Guid.NewGuid();
            var ipadpro = Guid.NewGuid();
            var tabss = Guid.NewGuid();

            var applewatch2 = Guid.NewGuid();
            #region Product
            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = macpro16,
                    Name = "Macbook Pro 16 M2 MAX 12C CPU 38C GPU 64GB 1TB SSD (SILVER)",
                    Description = "MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple's high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today's Apple fans.",
                    Price = 100190000,
                    ImageUrl = "https://lh3.googleusercontent.com/cPyVxwDbLfShad22xfK-dd2nlFWqTCSDMHXH7LffhPy37iGunzUM9VUtZCSiEgzzgPGcW3ZkGbImyjcVkf1RrjFr_plC_BjA=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "14copW3YiYA9OZtplLedaDhsV4LRN2eEz"
                },
                new Product()
                {
                    Id = macair15,
                    Name = "MacBook Air 15 M2 8C CPU 10C GPU 8GB 512GB SSD(Midnight)",
                    Description = "Updating",
                    Price = 39990000,
                    ImageUrl = "https://lh3.googleusercontent.com/lZLaRombXnbrg99vFtGOTiH4zUpkt3PhblRRTZWyqt7DUc-ztoRC6kT2VuuFD9-XJsPYf-8DVJNz1lRCs406a5NWdTROd1I=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "1SqDtpkZFWiXmnAoeGKMJB0JRg_jZy63g"
                },
                new Product()
                {
                    Id = macair2020,
                    Name = "MacBook Air 2020 13.3 inch MGNE3SA/A (M1/8GB/SSD512GB)",
                    Description = "MacBook Air 2020 13.3\" MGNE3SA/A belongs to a high-end laptop product line from the Apple brand that possesses outstanding performance thanks to being equipped with a genuine proprietary processor. With an elegant design and outstanding powerful configuration, MacBook Air 2020 13.3\" MGNE3SA/A promises to bring you an enjoyable experience",
                    Price = 34990000,
                    ImageUrl = "https://lh3.googleusercontent.com/lc6DzDy1TKN_guYmItGOG1DIWMp3iACXwfMJL4ZdlW501Sqm4j86XGaQDD_mrGiT8OoxFGj7FQGrc5DTR8MSZjrwV0ezEds=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "15zxKTkBDtJT9sr9bKwkfAQGZHnM6LjRz"
                },
                new Product()
                {
                    Id = macair2022_1,
                    Name = "MacBook Air 2022 13.6 inch Z15S00092 (M2/ 16GB/ 256GB SSD)",
                    Description = "MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple's high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today's Apple fans",
                    Price = 36890000,
                    ImageUrl = "https://lh3.googleusercontent.com/u2qUk5mgupuh9ubXaQxqE2kum6Exm8DygVJFez6Ksj6Yjb6CDjwQ3Jgh7bQ3-TjNxfWxmXTUd6zkxbA2w79-9zTlYsLUp9ah=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "1gzBXbbcWwhP3NKwYzlVZ10k362zzQ8WO"
                },
                new Product()
                {
                    Id = macair2022_2,
                    Name = "MacBook Air 2022 13.6 inch MLY33SA/A (M2/ 8GB/ SSD 256GB)",
                    Description = "Updating",
                    Price = 31900000,
                    ImageUrl = "https://lh3.googleusercontent.com/T4dQPx6nSJi3y147mwJH6kDJsxM6ULAAtIoZjgDDIi3yF5YpFYW7QbWh_nfT0Lhi2LxIDFuNPMamXlrBW-EcZ1NUGYBZ6VqbLw=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "1oRNlAF2LJEdMnyJsNbCGtirUa0GxSEYC"
                },
                new Product()
                {
                    Id = macpro13,
                    Name = "Macbook Pro 13 M2 8C CPU 10C GPU 24GB 512GB SSD (SILVER)",
                    Description = "Updating",
                    Price = 49590000,
                    ImageUrl = "https://lh3.googleusercontent.com/sPJkn-BIybufvMuXd1Ut6UkSWqz1UG76-WdZ3JcZ0GS1mNvYlY3_tUAGjzD_TkbC-k3HV_3bgGsmcoB56sbIVCLzcVmul6E=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = appleId,
                    FolderId = "10TOIotAbfwDK0MQmc1QyELyxy8oScukl"
                },

                new Product()
                {
                    Id = acer16,
                    Name = "Laptop ACER Nitro 16 Phoenix AN16-41-R5M4 (Ryzen 5 7535HS/RAM 8GB/RTX 4050/512GB SSD/ Windows 11)",
                    Description = "Are you a professional gamer, always want to have the best gaming experience? Are you also a person with a lot of work and study, need a versatile and efficient laptop? Are you also a lover of beauty and fashion, want a laptop with impressive design and convenience? If you have all the above requirements, then you cannot ignore ACER NITRO 16 PHOENIX Gaming Laptop - ACER's national gaming laptop, introduced by Phong Vu at a reasonable price. ACER NITRO 16 PHOENIX Gaming Laptop will satisfy you with the features below, let's find out in the article below!",
                    Price = 29990000,
                    ImageUrl = "https://lh3.googleusercontent.com/OzQVKRXMUlErjxiwqtLwpWvOWUbmuLay-lL_o80bXTheu_tfX-j07L8fuGtCgddQTrvaF_hbjKwxMlU7IxMgE_6oTkrW06Gs=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = accerId,
                    FolderId = "14xHS-BcOOmhjY013toMSWulGWKadT_0N"
                },
                new Product()
                {
                    Id = acerasp15,
                    Name = "Laptop ACER Aspire 5 A514-55-5954 (NX.K5BSV.001) (i5-1235U/RAM 8GB/512GB SSD/ Windows 11)",
                    Description = "Laptop Acer Aspire 5 A514-55-5954 NX. K5BSV.001 is one of the top choices for students as well as office workers. With a minimalist but still extremely sophisticated design along with powerful performance thanks to the Intel Core i5 CPU will be a great assistant for you in work, study as well as entertainment",
                    Price = 19990000,
                    ImageUrl = "https://lh3.googleusercontent.com/dF2OlQH_sxhOSNEUvCpUhODxCVoNqtrPHIDtosatk9iKmkmc_k6uq_5salWjPEob-5U1urzlFmTtqpByX7kvmdn0cKFB43Ps=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = accerId,
                    FolderId = "1U7gBEhG9szCsxXY95gzGO-mDX5M21Ric"
                },
                new Product()
                {
                    Id = acernitro5,
                    Name = "Laptop ACER Nitro 5 Eagle AN515-57-54MV (i5-11400H/RAM 8GB/RTX 3050/512GB SSD/ Windows 11)",
                    Description = "As a gaming laptop line of the Acer brand, the Acer Nitro 5 Eagle AN515-57-54MV laptop is equipped with a powerful i5 chip, NVIDIA GeForce RTX 3050 graphics card, 8Gb ram and large capacity. Combined with its beautiful and powerful design, this will be the choice for young gamers and people doing graphics-related work",
                    Price = 25990000,
                    ImageUrl = "https://lh3.googleusercontent.com/c7VuA4P8sHHJCilfzRVp50AQmgZEkJOyOCuh4vvkcT9jxfqTzZVd2gepUFSSqzXVSEljnYlAN319sJD-H1IztNcxPT3UypA=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = accerId,
                    FolderId = "1p7PobtADVoyyLZnOokk2ltDiFCAsdyfL"
                },

                new Product()
                {
                    Id = asus1,
                    Name = "Laptop ASUS Vivobook X515EA-EJ3633W (i3-1115G4/RAM 8GB/512GB SSD/ Windows 11)",
                    Description = "ASUS Vivobook X515EA-EJ3633W laptop (i3-1115G4) is equipped with Intel Core i3 CPU, 8GB Onboard DDR4 RAM capacity along with 512GB SSD hard drive for you to freely store study data, basic work with office tasks. Anti-glare screens help protect your eyes well from harmful blue light",
                    Price = 11290000,
                    ImageUrl = "https://lh3.googleusercontent.com/kkZs0JLWxfJpJg1dMiuzMDNayo_HpxHAaCQzVHE_ecuXjXD3vvZTGynpe4S2Ou5Y0FR-HVCIh4UU_o11huEYAm104zukaYlk=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = asusId,
                    FolderId = "1lge0An1ZzjQlD3oV-cjenDJ9M4WJzTL7"
                },
                new Product()
                {
                    Id = asus2,
                    Name = "Laptop ASUS Vivobook 15 X1504VA-NJ025W (i5-1335U/RAM 8GB/512GB SSD/ Windows 11)",
                    Description = "Updating",
                    Price = 17990000,
                    ImageUrl = "https://lh3.googleusercontent.com/_w0us6FSWOX-V9byAkNIbBL2BDR0CH7_pQODsmFKEP2PcEHM4O8EfHSy2LpBx35SX5SWgQFNEJ0aW1kPp-_aujK9mhL2_AjBHg=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = asusId,
                    FolderId = "1iEEPx1N9MkI7LBBP_hBwODMvZ6sih4mX"
                },
                new Product()
                {
                    Id = asus3,
                    Name = "Laptop ASUS Vivobook 16 M1605YA-MB303W (Ryzen 7 7730U/RAM 16GB/512GB SSD/ Windows 11)",
                    Description = "Updating",
                    Price = 18490000,
                    ImageUrl = "https://lh3.googleusercontent.com/GBCMEXu9-VgSeUAO8fW-XlSD-9GGd5YYwOkH8yi3cQOn0rRXFvNbIkDhoQbcr0iI3aeO6PDS4hHS2ZbQDhA8Rwedz5u1VOnS=w1000-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = asusId,
                    FolderId = "1kX3Ic2DGpw7jR46-iNGWgpDlHGHNt40o"
                },

                new Product()
                {
                    Id = dellins15,
                    Name = "Laptop Dell Inspiron 15 3520 (3520-71003264) (i3-1215U/RAM 8GB/512GB SSD/ Windows 11 + Office)",
                    Description = "The Dell Inspiron 15 3520 3520-71003264 i3-1215U Carbon Black is the perfect office laptop. The device is equipped with Intel Core i3 Alder Lake - 1215U chip, integrated Intel UHD Graphics card. Not too powerful but enough to meet your daily study and work needs",
                    Price = 15990000,
                    ImageUrl = "https://lh3.googleusercontent.com/nOikqpVL4HXGK3Hs6wKff1Wnl-U7aYbpvw6lu83FHjfGNVGMdF6OyoVLq_pErwB-MmmfDmN7VKIEaQ6Fc9T7k6hKYoXafeYhYg=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "1yobT5QGolFBw6r3dGOBKtutHG0eizgfy"
                },
                new Product()
                {
                    Id = dellins3530,
                    Name = "Laptop Dell Inspiron 3530 - N5I5791W1 (i5-1335U/RAM 16GB/512GB SSD/ Windows 11 + Office)",
                    Description = "Updating",
                    Price = 20290000,
                    ImageUrl = "https://lh3.googleusercontent.com/b00d0m8txaixII_rmYYCu1W1N0yeXlgANpNPvGC6ATQLAFZWbyqtUnAMqJhTsirVuwCVMXb0FwX6JXBPRPQLtAmGujAbLNuS=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "1ildfLhZpElIwWRcHPfmhIe9xwWhusoTY"
                },
                new Product()
                {
                    Id = dellins14,
                    Name = "Laptop Dell Inspiron 14 5430 - i5P165W11SL2050 (i5-1340P/RAM 16GB/512GB SSD/ Windows 11 + Office)",
                    Description = "Updating",
                    Price = 29790000,
                    ImageUrl = "https://lh3.googleusercontent.com/wFM2g6YQMMVWACV2sVKL6ouSZpVFWeIcwvWZ9f1mjyDBOzPNghhib2EPJBLrRUcbrDbC52fSzGwRp8sCLbpvoYHkbE3nsg0=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "1Wxkpz8DL6OAuA-iE2Y8QfINzWwMdcYN7"
                },
                new Product()
                {
                    Id = dellins16,
                    Name = "Laptop Dell Inspiron 16 5630 - i7P165W11SL2050 (i7-1360P/RAM 16GB/512GB SSD/ Windows 11 + Office)",
                    Description = "Updating",
                    Price = 30990000,
                    ImageUrl = "https://lh3.googleusercontent.com/kC9I2-5m1WbJlbXYStTMIuVcLNj1Qex_Bae7GQ1iqEwBzj1GhQSUCy2IJXxL0qinWDyWFlO80JZcYVN1YXLEPnhmsW70t639ww=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "1VCX_PE9G4DIU16blKhPiCdhWPWC6mvR8"
                },
                new Product()
                {
                    Id = dellvos3430,
                    Name = "Laptop Dell Vostro 3430 (i7-1355U/RAM 16GB/512GB SSD/ Windows 11 + Office)",
                    Description = "Updating",
                    Price = 26690000,
                    ImageUrl = "https://lh3.googleusercontent.com/QQEbvWwDKVxZedtS1EFexrYOZa6RqhW1J7mFYZU_IiMjbwV5fWHQWXvCxwwdv5hWK-GMOgthkMOslRRCAIUSA5p-HyCLbLE=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "134Zgrr4qGMDGTvc5iv-ajH2cELOW9GsK"
                },
                new Product()
                {
                    Id = dellins142,
                    Name = "Laptop Dell Inspiron 14 5430 (i7-1360P/RAM 16GB/1TB SSD/ Windows 11 + Office)",
                    Description = "Updating",
                    Price = 31490000,
                    ImageUrl = "https://lh3.googleusercontent.com/JzaLDtRkM112HJ0nqZ1SiIVOxSimMwOgmCx00Bbat3LXC7H-cCja3vJJg4Ac70UHfE2TVGCMp6loAqLMUT8VD0WSvxCqphM=w500-rw",
                    Quantity = 100,
                    CategoryId = laptopId,
                    BrandId = dellId,
                    FolderId = "1sxNQzMjOHSJ7fTAIWGWdVkx1YkuAxdbw"
                },

                new Product()
                {
                    Id = ip15pm,
                    Name = "iPhone 15 Pro Max - Genuine VNA",
                    Description = "iPhone 15 Pro Max belongs to the high-end product line that has just been launched by Apple on the market in 2023, retaining the outstanding design \"Dynamic Island\" along with a series of luxurious colors. The iPhone 15 Pro max is equipped with a new A17 Bionic chip with outstanding and powerful processing performance today to perform the tasks you want",
                    Price = 43990000,
                    ImageUrl = "https://lh3.googleusercontent.com/8w4MFwwKtq8dboBtb_bJLWcYgZge4G4G3kVv2tF8yKEQfUeu0xihFhvC2IGiZaQrnSfoZDU_Qcbk938-uolUGIX396P_qlQ=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1Ifg5rJYBvzJtFdk6ZfqM_cUbJvf6k6Mj"
                },
                new Product()
                {
                    Id = ip13,
                    Name = "iPhone 13 128GB Pink mobile phone (MLPH3VN/A)",
                    Description = "The set of 4 versions of iPhone 12 is still attractive and has not cooled, but Apple brings users a new super product iPhone 13 with many interesting improvements that promise to bring the most attractive experience to users",
                    Price = 24990000,
                    ImageUrl = "https://lh3.googleusercontent.com/NA85MErOuDh4WfEGmnTIDG6O-SMoCvMve2sGMqKpBJ-CrGCRcdv7Ouo5HpRr-ZrnIbah9GEWcZA_hO7BRmu4wHw0UktOkZgo=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1q9K2oaCGMyerUkMlELsDRoBZrfGXmhNa"
                },
                new Product()
                {
                    Id = ip13mn,
                    Name = "iPhone 13 mini 128GB (pink) (3J765VN/A) (DEMO) (PINK) - Exhibits",
                    Description = "Updating",
                    Price = 17490000,
                    ImageUrl = "https://lh3.googleusercontent.com/rT4c6CfzG8osJnzcpD4kDpdmInxJZ3y_qKBaR5OiMKNUWvV3KDVCh5Ke4vm6D2tmQYluG4_gVDR5wHKgob2lKasef-ODOmWh=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1FGeL7rFIhopiQKRmN4N47myHzxBOSmOB"
                },
                new Product()
                {
                    Id = ip14pm,
                    Name = "iPhone 14 Pro Max | Genuine VNA",
                    Description = "iPhone 14 Pro Max launched in September 2022 has made a prominent mark on the smart mobile market worldwide by an impressive makeover of the \"Dynamic Island\" screen design. iPhone 14 pro series is favored by Apple when equipped with a powerful A16 Bionic chip with outstanding processing performance, helping you perform many tasks on the device at the same time without jerking or lag",
                    Price = 36990000,
                    ImageUrl = "https://lh3.googleusercontent.com/Y1OVqtPmmjFd3lzbR0onqBQLgUtNkiX2T4zCffguTiZoMs73EJ9naybVgmrRat4i6bqWSC6oMQYvkWZlKxWlddEY3EzNvIj6=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "10CQlOpmK0_9G6lBaJnvZ5TvXnecJOFgR"
                },
                new Product()
                {
                    Id = ip15p,
                    Name = "iPhone 15 Plus - Genuine VNA",
                    Description = "In the iPhone 15 series collection launched in 2023, iPhone 15 Plus in particular and other iPhone 15 versions in general are highly appreciated to have a leap in new design, outstanding features are improved compared to the iPhone 14 series in 2022, bringing a completely new experience for iPhone enthusiasts. Join Phong Vu to learn about iPhone 15 Plus through this article!",
                    Price = 27990000,
                    ImageUrl = "https://lh3.googleusercontent.com/_eACMH4Tyg60SnkYcrMPgscrJ1P6PB8I_hmIUdWjDouY-hSJ44lNjiD2BDE6XMQ_ZUoIUvU9C4zlJCfBOwv5AC-eA6eQC1g=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1PeJEiAIBag3DupEC0hZOI4BRKqtuoTI5"
                },
                new Product()
                {
                    Id = ip14,
                    Name = "iPhone 14 128GB",
                    Description = "Product descriptions will be updated as soon as possible!",
                    Price = 24990000,
                    ImageUrl = "https://lh3.googleusercontent.com/HD6tK_lv_T2Hp6WDHzRREnZI0T-Cnx1hgDTAPuMWZBHB8di1gdeyL5KBZz34diG54BDRF0zqXQL6loA90vL4HoS0jmUYFEc=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = appleId,
                    FolderId = "1rgiZ9htIqDMEvN_6_xUpKZQ3oXMY704V"
                },
                new Product()
                {
                    Id = ssa05,
                    Name = "Samsung Galaxy A05 (4+128) (Black) (SM-A055FZKGXXV)",
                    Description = "Updating",
                    Price = 3090000,
                    ImageUrl = "https://lh3.googleusercontent.com/knEb077WDBllxLpzXhn_3HIAoR-l7TvZzCd2fsUL7P1dOeN5W6WDNQVDBn3xpHIir8jYE37c9s0ZI47I-rtni2dm2SB5xe8shg=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = samsungId,
                    FolderId = "10Z1Q2lr51ycdqF6fejHz_WgoaX7qDpYl"
                },
                new Product()
                {
                    Id = xiaomi12c,
                    Name = "Xiaomi Redmi 12C (4GB/64GB) (Blue)",
                    Description = "Updating",
                    Price = 3590000,
                    ImageUrl = "https://lh3.googleusercontent.com/wSCq7HZuqP30D8ZFZrFpi95EX_GLeN22ZymVx5_it-B8QjrqL2xdQ8q98PJix7lE0BtpOfTaPNVazU84Gv9YyADTC57OAss=w500-rw",
                    Quantity = 100,
                    CategoryId = smartphoneId,
                    BrandId = xiaomiId,
                    FolderId = "19a9uKIG6FsYwGBIpdAOOeuybQIfhg_3I"
                },
                new Product()
                {
                    Id = ipadpro,
                    Name = "iPad Pro 11 inch M2 Wifi",
                    Description = "Updating",
                    Price = 23990000,
                    ImageUrl = "https://lh3.googleusercontent.com/xrZTVonyBNNMAjArfukj_4B1xD8O4T_poW3j0SLYpaYVIvei3Pv2zYzefhLA65v_6_2aFfv0953cGXXVZ8UBZAu0g5CLSA=w500-rw",
                    Quantity = 100,
                    CategoryId = tabletId,
                    BrandId = appleId,
                    FolderId = "1R0gypNL_KuXDb4Hsw-TK92OB4wyBcKlN"
                },
                new Product()
                {
                    Id = tabss,
                    Name = "Samsung Galaxy Tab S7 FE LTE Tablet 4GB/64GB (Black) (SM-T735NZKAXXV)",
                    Description = "Updating",
                    Price = 13990000,
                    ImageUrl = "https://lh3.googleusercontent.com/WDBs6MVNz4hnSM3L1ukUN98WmnDm7Ag_s_AhLNYVWuvg0lYprSCTmtj8UDNCHu621AvU1eUMwlEylid-_JamBDp1Xdo33W0b=w500-rw",
                    Quantity = 100,
                    CategoryId = tabletId,
                    BrandId = samsungId,
                    FolderId = "1HVLMIm5HTuj-anZwQGeewsD4XpeioTLx"
                },
                new Product()
                {
                    Id = applewatch2,
                    Name = "Apple Watch Ultra 2 4G 49mm (Blue Olive Alpine - M Titanium Case) (MREY3VN/A)",
                    Description = "Updating",
                    Price = 25990000,
                    ImageUrl = "https://lh3.googleusercontent.com/h1DPkY2SVo3kw4e37lnqiJRd1nd5QlaNPDXxjiF8UJ4yakeTrR1wNzGO4W7qTMjSy8qQI7_2yS_B2M6975c4ceziO__U0MryBw=w500-rw",
                    Quantity = 100,
                    CategoryId = smartwatchId,
                    BrandId = appleId,
                    FolderId = "18B4NF_mYnJqpx41VfJLjAGBKbtQyfB4M"
                }
            );
            #endregion
            #region ProductPrice
            builder.Entity<ProductPrice>().HasData(
                new ProductPrice()
                {
                    Id = 1,
                    ProductId = macpro16,
                    Price = 94690000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 2,
                    ProductId = macair15,
                    Price = 34790000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 3,
                    ProductId = macair2020,
                    Price = 29990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 4,
                    ProductId = macair2022_1,
                    Price = 33290000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 5,
                    ProductId = macair2022_2,
                    Price = 26590000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },

                // no price for macpro13
                new ProductPrice()
                {
                    Id = 6,
                    ProductId = acer16,
                    Price = 25990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 7,
                    ProductId = acerasp15,
                    Price = 14990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 8,
                    ProductId = acernitro5,
                    Price = 18990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 9,
                    ProductId = asus1,
                    Price = 9490000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 10,
                    ProductId = asus2,
                    Price = 14990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 11,
                    ProductId = asus3,
                    Price = 15690000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 12,
                    ProductId = dellins15,
                    Price = 14390000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 13,
                    ProductId = dellins3530,
                    Price = 18590000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 14,
                    ProductId = dellins14,
                    Price = 27990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 15,
                    ProductId = dellins16,
                    Price = 28690000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 16,
                    ProductId = dellvos3430,
                    Price = 24890000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 17,
                    ProductId = dellins142,
                    Price = 30290000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 18,
                    ProductId = ip15pm,
                    Price = 39490000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 19,
                    ProductId = ip13,
                    Price = 15990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                // no price for ip13mn
                new ProductPrice()
                {
                    Id = 20,
                    ProductId = ip14pm,
                    Price = 29190000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 21,
                    ProductId = ip15p,
                    Price = 25190000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 22,
                    ProductId = ip14,
                    Price = 18790000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 23,
                    ProductId = ssa05,
                    Price = 2990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 24,
                    ProductId = xiaomi12c,
                    Price = 2490000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 25,
                    ProductId = ipadpro,
                    Price = 19990000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 26,
                    ProductId = tabss,
                    Price = 9390000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                },
                new ProductPrice()
                {
                    Id = 27,
                    ProductId = applewatch2,
                    Price = 21490000,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now.AddDays(10)
                }
            );
            #endregion
            #region Document
            builder.Entity<Document>().HasData(
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1fXgj_qQJMKNQczOx0Kd_0foAVyiYcmb8",
                    ProductId = macpro16
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1F2Z5C1km_4FvIa70xF0b8bL-OwsK07d6",
                    ProductId = macpro16
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1IrnkUeFEoVdNEY-FMf0Y4i33tOEOh1l8",
                    ProductId = macpro16
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1p0Eq0ptA7J3g5mTUP9g131BgLb6XCiyI",
                    ProductId = macpro16
                },

                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1KGDOpVmwofx2viWcLPSdji5_dVz6IEYK",
                    ProductId = macair15
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1NB-4hrhVBTP0kRbx9VOMRxMEOIsuT0Dt",
                    ProductId = macair15
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1hcc5bb9xZwftkpNNLbNSdWO-OaglGEU-",
                    ProductId = macair15
                },

                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=18_VERsQCkR5top5RyAiyXBWoyQTVgYLU",
                    ProductId = macair2020
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1oA7zu7vf9vxdDzRUOfTShMTO9TMYB2t1",
                    ProductId = macair2020
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1gCSDRkYeTgsuklm4-ZUVKutTKTu6bsOW",
                    ProductId = macair2020
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=13YRnumTXIikNyks6MMGS7IHy2XKsLcUG",
                    ProductId = macair2020
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1_8nLKemsZNH5ob80loz-Rjk46gIPCyAk",
                    ProductId = macair2020
                },

                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1AoKIxY1_KpVC--DBDv-5vkL7KRBETaTj",
                    ProductId = macair2022_1
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=19JhyKc7SDq8OS-FKWCEE1fHlB9zmlF4_",
                    ProductId = macair2022_1
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1D6w59akVTqabNKBcaDFvZeGh0DHiPZNS",
                    ProductId = macair2022_1
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1ANMv2MD1x9POXwFzqbtAFJaSVDsBygR_",
                    ProductId = macair2022_1
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1jFJ0Dy7LgyF9l-bnF6VeOVpvbqDDXkgz",
                    ProductId = macair2022_1
                },

                new Document()
                {
                    Id = "",
                    ProductId = macair2022_2
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1sojVUeqtcf6kDA84Mdj73JcbipmW5HP0",
                    ProductId = macair2022_2
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1pW-V7JEHlpOswTpw68p7GbAV_NV8i62S",
                    ProductId = macair2022_2
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=17g-gOr-mKqeRCKmv3aLa7kNBIf8AMza2",
                    ProductId = macair2022_2
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1_mXukBwuEtyZsG7bR_MDAO-d7PjMhP-w",
                    ProductId = macair2022_2
                },

                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1sf_iHr6KcO6Gl7oucfq46NirqaBERifh",
                    ProductId = macpro13
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1vpOJlcWyzrUGceYi-ilCZ4b3ufeMZapS",
                    ProductId = macpro13
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1KAPyG_jY6xo0pp13IhGHq3HosAlc42hB",
                    ProductId = macpro13
                },
                new Document()
                {
                    Id = "https://drive.google.com/uc?export=view&id=1pmIx4SB6rmApjVB6YIm9rYmsn7C5GNua",
                    ProductId = macpro13
                }
            );
            #endregion
            #region Attribute
            builder.Entity<Attribute>().HasData(
                new Attribute()
                {
                    Id = 1,
                    Name = "Trademark"
                },
                new Attribute()
                {
                    Id = 2,
                    Name = "Warranty"
                },
                new Attribute()
                {
                    Id = 3,
                    Name = "Laptop series"
                },
                new Attribute()
                {
                    Id = 4,
                    Name = "Colour"
                },
                new Attribute()
                {
                    Id = 5,
                    Name = "Demand"
                },
                new Attribute()
                {
                    Id = 6,
                    Name = "CPU generation"
                },
                new Attribute()
                {
                    Id = 7,
                    Name = "CPU"
                },
                new Attribute()
                {
                    Id = 8,
                    Name = "Graphics chip"
                },
                new Attribute()
                {
                    Id = 9,
                    Name = "RAM"
                },
                new Attribute()
                {
                    Id = 10,
                    Name = "Monitor"
                },
                new Attribute()
                {
                    Id = 11,
                    Name = "Archive"
                },
                new Attribute()
                {
                    Id = 12,
                    Name = "Video output port"
                },
                new Attribute()
                {
                    Id = 13,
                    Name = "Gateway"
                },
                new Attribute()
                {
                    Id = 14,
                    Name = "Wireless connection"
                },
                new Attribute()
                {
                    Id = 15,
                    Name = "Keyboard"
                },
                new Attribute()
                {
                    Id = 16,
                    Name = "Operating system"
                },
                new Attribute()
                {
                    Id = 17,
                    Name = "Dimension"
                },
                new Attribute()
                {
                    Id = 18,
                    Name = "Battery"
                },
                new Attribute()
                {
                    Id = 19,
                    Name = "Mass"
                },
                new Attribute()
                {
                    Id = 20,
                    Name = "Included accessories"
                },
                new Attribute()
                {
                    Id = 21,
                    Name = "Series"
                },
                new Attribute()
                {
                    Id = 22,
                    Name = "Screen type"
                },
                new Attribute()
                {
                    Id = 23,
                    Name = "Resolution"
                },
                new Attribute()
                {
                    Id = 24,
                    Name = "Capacity(ROM)"
                },
                new Attribute()
                {
                    Id = 25,
                    Name = "Chip"
                },
                new Attribute()
                {
                    Id = 26,
                    Name = "Battery technology"
                },
                new Attribute()
                {
                    Id = 27,
                    Name = "Charging port"
                },
                new Attribute()
                {
                    Id = 28,
                    Name = "SIM type"
                },
                new Attribute()
                {
                    Id = 29,
                    Name = "Mobile networks"
                },
                new Attribute()
                {
                    Id = 30,
                    Name = "Rear camera"
                },
                new Attribute()
                {
                    Id = 31,
                    Name = "Front camera"
                },
                new Attribute()
                {
                    Id = 32,
                    Name = "Wifi"
                },
                new Attribute()
                {
                    Id = 33,
                    Name = "GPS"
                },
                new Attribute()
                {
                    Id = 34,
                    Name = "Blutooth"
                },
                new Attribute()
                {
                    Id = 35,
                    Name = "Headphone jack"
                },
                new Attribute()
                {
                    Id = 36,
                    Name = "Feature"
                },
                new Attribute()
                {
                    Id = 37,
                    Name = "Case Size"
                },
                new Attribute()
                {
                    Id = 38,
                    Name = "Screen technology"
                },
                new Attribute()
                {
                    Id = 39,
                    Name = "Screen size"
                },
                new Attribute()
                {
                    Id = 40,
                    Name = "Glass Material"
                },
                new Attribute()
                {
                    Id = 41,
                    Name = "Internal memory"
                },
                new Attribute()
                {
                    Id = 42,
                    Name = "Connect"
                },
                new Attribute()
                {
                    Id = 43,
                    Name = "Time of use"
                },
                new Attribute()
                {
                    Id = 44,
                    Name = "Material"
                },
                new Attribute()
                {
                    Id = 45,
                    Name = "Strap"
                }
            );
            #endregion
            #region AttributeOption
            builder.Entity<AttributeOption>().HasData(
                new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 1,
                    Value = "APPLE"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 1,
                    Value = "ACER"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 1,
                    Value = "ASUS"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 1,
                    Value = "Dell"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 1,
                    Value = "Samsung"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 1,
                    Value = "Xiaomi"
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 3,
                    Value = "Macbook Pro"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 3,
                    Value = "Macbook Air"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 3,
                    Value = "Aspire 5"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 3,
                    Value = "Nitro 5"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 3,
                    Value = "Nitro 16"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 3,
                    Value = "Vivobook"
                }, new AttributeOption()
                {
                    Id = 7,
                    AttributeId = 3,
                    Value = "Inspiron"
                }, new AttributeOption()
                {
                    Id = 8,
                    AttributeId = 3,
                    Value = "Vostro"
                },




                new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 4,
                    Value = "Silver"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 4,
                    Value = "Gold"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 4,
                    Value = "Red"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 4,
                    Value = "Midnight"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 4,
                    Value = "Starlight"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 4,
                    Value = "White"
                }, new AttributeOption()
                {
                    Id = 7,
                    AttributeId = 4,
                    Value = "Sand gold"
                }, new AttributeOption()
                {
                    Id = 8,
                    AttributeId = 4,
                    Value = "Bronze gold"
                }, new AttributeOption()
                {
                    Id = 9,
                    AttributeId = 4,
                    Value = "Green"
                }, new AttributeOption()
                {
                    Id = 10,
                    AttributeId = 4,
                    Value = "Grey"
                }, new AttributeOption()
                {
                    Id = 11,
                    AttributeId = 4,
                    Value = "Silver gray"
                }, new AttributeOption()
                {
                    Id = 12,
                    AttributeId = 4,
                    Value = "Dark gray"
                }, new AttributeOption()
                {
                    Id = 13,
                    AttributeId = 4,
                    Value = "Black"
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 5,
                    Value = "Business"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 5,
                    Value = "Entrepreneur"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 5,
                    Value = "Gaming"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 5,
                    Value = "Family"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 5,
                    Value = "Students"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 5,
                    Value = "Office"
                }, new AttributeOption()
                {
                    Id = 7,
                    AttributeId = 5,
                    Value = "Graphics - Engineering"
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 6,
                    Value = "Apple M"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 6,
                    Value = "Celeron"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 6,
                    Value = "Core i3"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 6,
                    Value = "Core i5"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 6,
                    Value = "Core i7"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 6,
                    Value = "Core i9"
                }, new AttributeOption()
                {
                    Id = 7,
                    AttributeId = 6,
                    Value = "Qualcomn"
                }, new AttributeOption()
                {
                    Id = 8,
                    AttributeId = 6,
                    Value = "Snapdrogon"
                }, new AttributeOption()
                {
                    Id = 9,
                    AttributeId = 6,
                    Value = "Ryzen 3"
                }, new AttributeOption()
                {
                    Id = 10,
                    AttributeId = 6,
                    Value = "Ryzen 5"
                }, new AttributeOption()
                {
                    Id = 11,
                    AttributeId = 6,
                    Value = "Ryzen 7"
                }, new AttributeOption()
                {
                    Id = 12,
                    AttributeId = 6,
                    Value = "Ryzen 9"
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 9,
                    Value = "4GB"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 9,
                    Value = "8GB"
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 9,
                    Value = "16GB"
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 9,
                    Value = "24GB"
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 9,
                    Value = "32GB"
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 9,
                    Value = "64GB"
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 10,
                    Value = "11.6\""
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 10,
                    Value = "12.3\""
                }, new AttributeOption()
                {
                    Id = 3,
                    AttributeId = 10,
                    Value = "13\""
                }, new AttributeOption()
                {
                    Id = 4,
                    AttributeId = 10,
                    Value = "13.3\""
                }, new AttributeOption()
                {
                    Id = 5,
                    AttributeId = 10,
                    Value = "13.4\""
                }, new AttributeOption()
                {
                    Id = 6,
                    AttributeId = 10,
                    Value = "13.5\""
                }, new AttributeOption()
                {
                    Id = 7,
                    AttributeId = 10,
                    Value = "13.6\""
                }, new AttributeOption()
                {
                    Id = 8,
                    AttributeId = 10,
                    Value = "14\""
                }, new AttributeOption()
                {
                    Id = 9,
                    AttributeId = 10,
                    Value = "14.2\""
                }, new AttributeOption()
                {
                    Id = 10,
                    AttributeId = 10,
                    Value = "14.5\""
                }, new AttributeOption()
                {
                    Id = 11,
                    AttributeId = 10,
                    Value = "15.3\""
                }, new AttributeOption()
                {
                    Id = 12,
                    AttributeId = 10,
                    Value = "15.6\""
                }, new AttributeOption()
                {
                    Id = 13,
                    AttributeId = 10,
                    Value = "16\""
                }, new AttributeOption()
                {
                    Id = 14,
                    AttributeId = 10,
                    Value = "16.1\""
                }, new AttributeOption()
                {
                    Id = 15,
                    AttributeId = 10,
                    Value = "17\""
                }, new AttributeOption()
                {
                    Id = 16,
                    AttributeId = 10,
                    Value = "17.3\""
                }, new AttributeOption()
                {
                    Id = 17,
                    AttributeId = 10,
                    Value = "18\""
                }, new AttributeOption()
                {
                    Id = 1,
                    AttributeId = 16,
                    Value = "Android"
                }, new AttributeOption()
                {
                    Id = 2,
                    AttributeId = 16,
                    Value = "iOS"
                }
            );
            #endregion
            #region AttributeSpec
            builder.Entity<AttributeSpec>().HasData(
                new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 1,
                    OptionID = 1
                },
                new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 2,
                    Value = "12 months"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 3,
                    OptionID = 1
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 4,
                    OptionID = 1
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 5,
                    OptionID = 1
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 6,
                    OptionID = 1
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 7,
                    Value = "Apple M2 Max ( 12-Core CPU / 64-Core GPU )"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 8
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 9,
                    OptionID = 6
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 10,
                    OptionID = 13
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 11
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 12,
                    Value = "1 x HDMI"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 13,
                    Value = "3 x Thunderbolt 4 , 1 x 3.5 mm , 1 x SDXC Card Slot"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 14,
                    Value = "WiFi 802.11ax (Wifi 6) , Bluetooth 5.3"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 15
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 16,
                    Value = "macOS"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 17,
                    Value = "1.68 x 35.57 x 24.81 cm"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 18,
                    Value = "100 Wh"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 19,
                    Value = "2.1 kg"
                }, new AttributeSpec()
                {
                    ProductId = macpro16,
                    AttributeId = 20,
                }

            );
            #endregion
            #region Slug
            var laptopslug = "laptop";
            var macbookslug = "laptop-apple-macbook";
            var acerslug = "laptop-acer";
            var asusslug = "laptop-asus";
            var dellslug = "laptop-dell";

            var smartphoneslug = "smartphone";
            var iphoneslug = "smartphone-iphone";
            var ssspslug = "smartphone-samsung";
            var xiaomislug = "smartphone-xiaomi";

            var tabletslug = "tablet";
            var ipadslug = "tablet-ipad";
            var sstabletslug = "tablet-samsung";

            var smartwatchslug = "smartwatch";
            var applewatchslug = "smartwatch-apple";

            // slider
            var blackfriday = "black-friday";
            var bestsale = "best-sale";
            var salelaptop = "sale-laptop";
            builder.Entity<Slug>().HasData(
                new Slug()
                {
                    Id = laptopslug,
                    Title = "Laptop",
                    Image = "https://lh3.googleusercontent.com/lFZZtBMUqkbl9qKKUe3DSmHqpb62UjWrOkxqcJ6lN3yM83Wg2Irp-ZlvkUwGO6TMcsscLELMZa_lN9jo8tKteWsCzmUii7po=rw"
                }, new Slug()
                {
                    Id = macbookslug,
                    Title = "Apple (Macbook)",
                }, new Slug()
                {
                    Id = acerslug,
                    Title = "Acer",
                }, new Slug()
                {
                    Id = asusslug,
                    Title = "ASUS",
                }, new Slug()
                {
                    Id = dellslug,
                    Title = "Dell",
                }, new Slug()
                {
                    Id = smartphoneslug,
                    Title = "Smartphone",
                    Image = "https://lh3.googleusercontent.com/qtC62XnXkTsyJbMok7Z7Uu5GOPvhqslzU5YscZZ0HvorTWRs0Qg5s8gWU6l6CTcmc-pQA2y1myJCZ92t9VDq=rw"
                }, new Slug()
                {
                    Id = iphoneslug,
                    Title = "Iphone",
                }, new Slug()
                {
                    Id = ssspslug,
                    Title = "Samsung",
                }, new Slug()
                {
                    Id = xiaomislug,
                    Title = "Xiaomi",
                }, new Slug()
                {
                    Id = tabletslug,
                    Title = "Tablet",
                    Image = "https://lh3.googleusercontent.com/dkzFFaKYmPLLkPnC-cyefC1u1Qh0Iy_6Loz7adsbIMs-KAK8FA_PwUOklM3gEppESc1uSeaTa63U4Vejifo=rw"
                }, new Slug()
                {
                    Id = ipadslug,
                    Title = "Apple (iPad)",
                }, new Slug()
                {
                    Id = sstabletslug,
                    Title = "Samsung",
                }, new Slug()
                {
                    Id = smartwatchslug,
                    Title = "Smartwatch",
                    Image = "https://th.bing.com/th/id/R.2650cb6112fbd5590eb781022a3c148e?rik=ZlMWy8mm%2fzwGTg&pid=ImgRaw&r=0"
                }, new Slug()
                {
                    Id = applewatchslug,
                    Title = "Apple",
                },
                // slider
                new Slug()
                {
                    Id = blackfriday,
                    Title = "Black Friday",
                    Image = "https://ben.com.vn/tin-tuc/wp-content/uploads/2021/10/black-friday-la-ngay-bao-nhieu-750x536.jpg",
                    IsSilder = true
                }, new Slug()
                {
                    Id = bestsale,
                    Title = "Sale up to 50%",
                    Image = "https://cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/homev2/fs-0611-1211-theme/desk/tgdd/banner-title.gif",
                    IsSilder = true
                }, new Slug()
                {
                    Id = salelaptop,
                    Title = "Laptop gaming sale up to 40%",
                    Image = "https://static.vecteezy.com/system/resources/thumbnails/006/241/067/small/abstract-polygon-3d-triangle-yellow-geometric-background-free-photo.jpg",
                    IsSilder = true
                }
            );

            #endregion
            #region SlugProduct
            builder.Entity<SlugProduct>().HasData(
                new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macpro16
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macair15
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macair2020
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macair2022_1
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macair2022_2
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = macpro13
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = acer16
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = acerasp15
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = acernitro5
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = asus1
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = asus2
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = asus3
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellins15
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellins3530
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellins14
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellins16
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellvos3430
                }, new SlugProduct()
                {
                    SlugId = laptopslug,
                    ProductId = dellins142
                },

                // slug lv2

                new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macpro16
                }, new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macair15
                }, new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macair2020
                }, new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macair2022_1
                }, new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macair2022_2
                }, new SlugProduct()
                {
                    SlugId = macbookslug,
                    ProductId = macpro13
                }, new SlugProduct()
                {
                    SlugId = acerslug,
                    ProductId = acer16
                }, new SlugProduct()
                {
                    SlugId = acerslug,
                    ProductId = acerasp15
                }, new SlugProduct()
                {
                    SlugId = acerslug,
                    ProductId = acernitro5
                }, new SlugProduct()
                {
                    SlugId = asusslug,
                    ProductId = asus1
                }, new SlugProduct()
                {
                    SlugId = asusslug,
                    ProductId = asus2
                }, new SlugProduct()
                {
                    SlugId = asusslug,
                    ProductId = asus3
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellins15
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellins3530
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellins14
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellins16
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellvos3430
                }, new SlugProduct()
                {
                    SlugId = dellslug,
                    ProductId = dellins142
                },

                // smartphone slug
                new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip15pm
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip13
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip13mn
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip14pm
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip15p
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ip14
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = ssa05
                }, new SlugProduct()
                {
                    SlugId = smartphoneslug,
                    ProductId = xiaomi12c
                },
                // smartphone lv2
                new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip15pm
                }, new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip13
                }, new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip13mn
                }, new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip14pm
                }, new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip15p
                }, new SlugProduct()
                {
                    SlugId = iphoneslug,
                    ProductId = ip14
                }, new SlugProduct()
                {
                    SlugId = ssspslug,
                    ProductId = ssa05
                }, new SlugProduct()
                {
                    SlugId = xiaomislug,
                    ProductId = xiaomi12c
                }, new SlugProduct()
                {
                    SlugId = tabletslug,
                    ProductId = ipadpro
                }, new SlugProduct()
                {
                    SlugId = tabletslug,
                    ProductId = tabss
                }, new SlugProduct()
                {
                    SlugId = ipadslug,
                    ProductId = ipadpro
                }, new SlugProduct()
                {
                    SlugId = sstabletslug,
                    ProductId = tabss
                }, new SlugProduct()
                {
                    SlugId = smartwatchslug,
                    ProductId = applewatch2
                }, new SlugProduct()
                {
                    SlugId = applewatchslug,
                    ProductId = applewatch2
                },

                // black friday
                new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = applewatch2
                }, new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = acer16
                }, new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = ip15pm
                }, new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = dellins142
                }, new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = asus3
                }, new SlugProduct()
                {
                    SlugId = blackfriday,
                    ProductId = tabss
                },

                // 11.11
                new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = macair15
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = macair2020
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = macair2022_2
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = acerasp15
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = acernitro5
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = dellvos3430
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = tabss
                }, new SlugProduct()
                {
                    SlugId = bestsale,
                    ProductId = ipadpro
                },

                // sale laptop
                new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = dellins16
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = dellins14
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = dellins15
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = dellins142
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = dellins3530
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = asus1
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = acerasp15
                }, new SlugProduct()
                {
                    SlugId = salelaptop,
                    ProductId = acer16
                }
            );
            #endregion
            #region Menu
            #endregion
        }
    }
}
