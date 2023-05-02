using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FolderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PercentSale = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.CustomerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => new { x.CustomerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Views_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Views_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryStatuses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PercentSale = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.CustomerId, x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", "2", "User", "User" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", "0", "SuperAdmin", "SuperAdmin" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", "1", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDay", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "733405a6-2831-409d-af9e-fda4482bf1b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com", true, false, null, "User", "landpuserdemo@gmail.com", null, "AQAAAAEAACcQAAAAEFNTWZCk8LwFZwKcu3QNx87BcTUpQuJeyD7wHdLOGw0mvp/MMp1jj9qs0QSR0uuFjQ==", null, false, "8bbbede7-b0a5-428a-9e00-511bcab6f8cf", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com" },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1287e7ed-143f-4444-8d4d-73272254e210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com", true, false, null, "User1", "landpuserdemo1@gmail.com", null, "AQAAAAEAACcQAAAAEMIKQT22a7WefbHmv7h+BptOkfSBgo6JXlo3MU32zSJvpsBKxHJ4SDm1SEWDukNRyw==", null, false, "a5e79b67-17eb-4990-99d5-d48607f06f2a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f063e9f4-3be4-4ba3-a611-b6cf0d587fad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com", true, false, null, "Super Admin", "landpsupadmika@gmail.com", null, "AQAAAAEAACcQAAAAEKUIe6bil4VjV2M15apPqRhWhNQjQvW4yp4lYH3ueZfN7RcvKsECiwkWk6W3EJwu4A==", null, false, "34a83a86-d6a3-42ad-a929-66f0a1c2b403", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a846ad0f-3bfe-45ee-a093-6841c895ae08", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com", true, false, null, "Admin", "landpadmika@gmail.com", null, "AQAAAAEAACcQAAAAEMIBUk0cZUcqCs2yF1qu580/Xt7GiNDaImlzFZ4gaPqjJOHTeddsuFsvW2IFJ0l02w==", null, false, "db4fa872-c039-435f-bc1e-4a626413a6f8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), "A branch from China", "https://drive.google.com/uc?export=view&id=1Q0u1RB9SfYkxXXmF2s9CPyTXKVY4IN1A", "Dell" },
                    { new Guid("2d750aa2-ea06-47ea-916c-abb6661f9781"), "A branch from China", "https://drive.google.com/uc?export=view&id=1T3galDlqvff5zyZd8kf19McJK9V7iAvL", "Suunto" },
                    { new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), "A branch from korea", "https://drive.google.com/uc?export=view&id=1JrfIHh1Fi9aM66IMLd2jdZwurx1As6x0", "Samsung" },
                    { new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), "A branch from China", "https://drive.google.com/uc?export=view&id=1WGo9ev5XnfDETamxPvTVaJJuAYr892Nf", "Xiaomi" },
                    { new Guid("36326612-2d44-446f-87cd-d060d14237a6"), "A branch from Ameria", "https://drive.google.com/uc?export=view&id=1DfzKYG8dsu0C0tNK_5U8GNBM3IE92fsz", "Apple" },
                    { new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), "A branch from China", "https://drive.google.com/uc?export=view&id=1CYKkazDIXzIw_q6ioPB8NlgZTjnhor-N", "Assus" },
                    { new Guid("fc1a0ff3-92d8-4a16-adb5-8c901bbe48f2"), "A branch from China", "https://drive.google.com/uc?export=view&id=1F9Sn87qp9kkJbbANHNKSXoE6pYwLPVz-", "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AvatarUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "https://drive.google.com/uc?export=view&id=1y_ap3ooVR_djmamFvklsm0tx-d9Zrt3V", "A smart device", "Smartwatch" },
                    { new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "https://drive.google.com/uc?export=view&id=15Lo6BabMJo7m9p-VSve4kls1pG2VA1AN", "A smart device", "Laptop" },
                    { new Guid("76f4c144-6e3f-44bf-a292-8dd21a461b5d"), "https://drive.google.com/uc?export=view&id=1N6u8HMtyTtdXWGBxz5AFRzk2KbvB6aVc", "A smart device", "Mouse" },
                    { new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "https://drive.google.com/uc?export=view&id=1EHDwKK-pKe78N_-Ns3RhID7Wg3S2nmDP", "A smart device", "Tablet" },
                    { new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "https://drive.google.com/uc?export=view&id=1VPowiqiVfyuL7Pzntp1mqJV748v34zfb", "A smart device", "Smartphone" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CustomerId", "Detail", "District", "Province", "Ward" },
                values: new object[,]
                {
                    { new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", "5", "Thành phố Cà Mau", "Cà Mau", "8" },
                    { new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", "Tô Ký", "12", "Thành phố Hồ Chí Minh", "Tân Chánh Hiệp" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", "04be0c35-571e-425c-992e-15a7227286de" },
                    { "04be0c35-571e-425c-992e-15a7227286de", "1b0b163d-032f-4e19-9e64-d89bf02f1751" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", "289f6c6a783e4d89b25c847d1ffa4833" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", "43bd8d30-85af-4960-8a9f-d7f7eeeb8571" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "Name", "PercentSale", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau khi trình làng hàng loạt mẫu iPhone vào tháng 09/2022 thì Apple cũng đã tiếp tục giới thiệu series iPad mới cho năm 2022. Trong đó iPad 10 WiFi 64GB là cái tên được hãng chú trọng khá nhiều về việc tối ưu giá thành nhằm giúp người dùng có thể dễ dàng tiếp cận. Máy hỗ trợ hệ điều hành iPadOS 16 cùng con chip Apple A14 Bionic giúp mang lại hiệu năng vượt trội.", "18kx0xh8gVJAJllf-4ZVeFZFfkJHI1zkX", "https://drive.google.com/uc?export=view&id=1PjgSj70e2Oc1GC-DJBiVkzs77mAdEokF", "iPad 10", 2.0, 11190000.0, 10, "Unit" },
                    { new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi Redmi Note 12 Pro 5G là mẫu điện thoại thuộc dòng Redmi Note được chính thức ra mắt trong năm 2023, máy mang trên mình những cải tiến vượt trội về thiết kế, camera và hiệu năng, đáp ứng mượt mà hầu hết các nhu cầu khác nhau của người dùng.", "1gBdpMXybH0HOxSKI6g9AdmisL9IUMfPq", "https://drive.google.com/uc?export=view&id=190zjmRvUnsTZdB4iDizNBjqKI_fk5L3a", "Xiaomi Redmi Note 12 Pro 5G", 2.0, 9960000.0, 50, "Unit" },
                    { new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n2 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A14 Bionic\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n2815 mAh20 W", "1b9JWfgUruHr6j3U3XalWbAD2UO329_6X", "https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By", "Iphone 12", 20.0, 15590000.0, 50, "Unit" },
                    { new Guid("3e9d9046-0534-44cf-a0fa-746a31acad9f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau thành công của iPad 8, Apple cho đã cho ra mắt máy tính bảng iPad 9 WiFi 64GB - phiên bản tiếp theo của dòng iPad 10.2 inch, về cơ bản nó kế thừa những điểm mạnh từ các phiên bản trước đó và được cải tiến thêm hiệu suất, trải nghiệm người dùng nhằm giúp nhu cầu sử dụng giải trí và làm việc tiện lợi, linh hoạt hơn", "1SZ3o96HmpNycsXIeOzuXBDF3dgh6v85o", "https://drive.google.com/uc?export=view&id=1IK5bpXd3iGWJbMDOS5c_zG5Zk5th3hhl", "iPad 9", 0.0, 7990000.0, 10, "Unit" },
                    { new Guid("5d7beeaf-f51e-44bb-ae26-aadb1bdc0276"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nếu bạn đang tìm kiếm một chiếc laptop gaming nhưng vẫn sở hữu một mức giá phải chăng thì laptop Asus TUF Gaming F15 FX506LHB i5 (HN188W) sẽ là sự lựa chọn đáng cân nhắc với card đồ họa rời NVIDIA GeForce GTX mạnh mẽ cùng phong cách thiết kế cứng cáp, độc đáo. ", "1504cqv26tU1E4JAWix9Ajxwh3XCH8tOv", "https://drive.google.com/uc?export=view&id=1s_UzQewLQ4zb7cX25cwUYAlVa3CpuCP9", "TUF Gaming F15", 0.0, 16990000.0, 50, "Unit" },
                    { new Guid("61a1dce1-164c-4a2f-a6e1-6397c5033bfb"), new Guid("fc1a0ff3-92d8-4a16-adb5-8c901bbe48f2"), new Guid("76f4c144-6e3f-44bf-a292-8dd21a461b5d"), "Chuột Không dây Bluetooth Silent Logitech Signature M650 sở hữu kiểu dáng công thái học cùng độ phân giải lớn, đáp ứng tốt gần như mọi nhu cầu từ sử dụng cơ bản tới những tác vụ chuyên nghiệp của người dùng.", "1M0-dUHbo7g_pkLPbQu9NMTPc9tnGkwr7", "https://drive.google.com/uc?export=view&id=1ukyWOlXUIJzxVzjmNN5hPlrnHN0yET7b", "Bluetooth Silent Logitech Signature M650", 0.0, 765000.0, 10, "Unit" },
                    { new Guid("777ffbe5-1f43-4b6c-80d3-6b3cffbcb721"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Sau thành công của dòng Galaxy Watch4, tháng 8/2022 ông lớn công nghệ Samsung đã cho ra mắt thế hệ smartwatch tiếp theo của hãng mang tên Samsung Galaxy Watch5 40 mm.", "1v5XPVE3A_7XnX4yUf8OekLE54mHXr_CZ", "https://drive.google.com/uc?export=view&id=17uBw10YiFMD2ET9pw_wiXkznPsQrAhr0", "Samsung Galaxy Watch5", 0.0, 5490000.0, 10, "Unit" },
                    { new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new Guid("2d750aa2-ea06-47ea-916c-abb6661f9781"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Đồng hồ thông minh Suunto 7 Dây silicone phiên bản màu đen trang bị mặt kính cường lực chống va đập, màn hình AMOLED 1.97 inch (454 x 454 pixels) cùng độ sáng lên tới 1000 nits, vì thế có thể hiển thị sắc nét ngay cả khi ở điều kiện có ánh sáng mặt trời. Đặc biệt, với thiết kế dây đeo silicone tạo cảm giác mềm mại và dễ chịu khi đeo trong thời gian dài.", "15B4NY2lAFY9DXr1Z40hwoQNjI5ZjnpZ4", "https://drive.google.com/uc?export=view&id=1-nQviihO_G_HGipaWd72aRUURK4zkm6S", "Suunto 7", 0.0, 7250000.0, 5, "Unit" },
                    { new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi 12T series đã ra mắt trong sự kiện của Xiaomi vào ngày 4/10, trong đó có Xiaomi 12T 5G 128GB - máy sở hữu nhiều công nghệ hàng đầu trong giới smartphone tiêu biểu như: Chipset mạnh mẽ đến từ MediaTek, camera 108 MP sắc nét cùng khả năng sạc 120 W siêu nhanh.", "1RvQvCVJ2wk72oMqDuYfeuTBHSIHNhplS", "https://drive.google.com/uc?export=view&id=165CbvBDjo8PPjxn2MPHVe2YrZPZ1oCwd", "Xiaomi 12T 5G 128GB", 0.0, 9890000.0, 3, "Unit" },
                    { new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nPLS TFT LCD6.6\"Full HD+\r\nHệ điều hành:\r\n\r\nAndroid 12\r\nCamera sau:\r\n\r\nChính 50 MP & Phụ 5 MP, 2 MP, 2 MP\r\nCamera trước:\r\n\r\n8 MP\r\nChip:\r\n\r\nSnapdragon 680\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n2 Nano SIMHỗ trợ 4G\r\nPin, Sạc:\r\n\r\n5000 mAh25 W", "12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn", "https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL", "Samsung Galaxy A23", 0.0, 4990000.0, 100, "Unit" },
                    { new Guid("d5682976-7d8c-4549-884c-e85f73ddbed3"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Vostro 3510 i5 (P112F002BBL) sở hữu cấu hình mạnh mẽ, đa nhiệm mượt mà trên sức mạnh của bộ vi xử lý Intel thế hệ 11, cùng một thiết kế đơn giản mà sang đẹp, sẽ là lựa chọn đắt giá đáp ứng nhu cầu học tập, làm việc hay giải trí của bạn.", "1R9qzBw6zNwBARHF8aGu2_qJYlil161yl", "https://drive.google.com/uc?export=view&id=1ELd9fd2dk2meSyxz-hVnsIp8_gFrnHxp", "Dell Vostro 3510", 20.0, 17990000.0, 10, "Unit" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "ProductId" },
                values: new object[,]
                {
                    { "https://drive.google.com/uc?export=view&id=1DeA5LM1HQsUEb9tXUHEg27fWqKenJJDG", new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                    { "https://drive.google.com/uc?export=view&id=1g7NLy-NZE9OTZhH0xctgVXONMNjHpQ4V", new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                    { "https://drive.google.com/uc?export=view&id=1IzG911rHzKN2p51Ite3JZqDV1FonTt4d", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                    { "https://drive.google.com/uc?export=view&id=1JgLvP6rxTkkkmdWG7RhyqB4nMnaktLE6", new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                    { "https://drive.google.com/uc?export=view&id=1JO-t8NpCi9qb9Jx8pmXbdHMvPg8LQAg3", new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8240), "Delivered", 58364800.0 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8237), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8238), "Delivered", 56154400.0 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8234), "Delivered", 67640200.0 }
                });

            migrationBuilder.InsertData(
                table: "Views",
                columns: new[] { "CustomerId", "ProductId", "Date" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8195) },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8179) },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8197) },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8201) },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8196) },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8202) }
                });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("07614b9b-bf2d-4bad-a16b-a0a41bcf67e3"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8361), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("849285e7-02a0-4e38-b99b-35ca475b0a13"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8360), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("854cb2ce-a93a-471c-8a29-f06843766612"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8342), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("92119b84-e7d4-43dc-99a7-e674bd92f907"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8356), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("955bb84a-8ad9-448a-b17f-65548aa21145"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8379), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("99538a16-efbf-4027-9b91-15cf0d1e767e"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8362), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("9f9e0ef6-8abb-436d-9bf4-a555b8e68717"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8382), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("a4799b06-f321-42c2-a202-8225890471a0"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8376), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("d2f3e875-6211-4f38-a24e-597f68955b91"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8377), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("d3a77831-89d9-4644-a7d0-7a4eca5d3c32"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8380), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("e255dadb-b8e4-4908-a6be-c81dfc21d2c4"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8358), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("f5113cb8-a5b1-41a0-b0c9-c150f325399d"), new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8355), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "PercentSale", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 2.0, 11190000.0, 4 },
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 2.0, 11190000.0, 2 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 20.0, 15590000.0, 1 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 3 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 2.0, 11190000.0, 1 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 20.0, 15590000.0, 2 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 3 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), 0.0, 4990000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8411), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8408), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8413), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8410), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8412), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8409), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), "Good", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8406), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 5, 2, 17, 13, 41, 424, DateTimeKind.Local).AddTicks(8414), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ProductId",
                table: "Documents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStatuses_OrderId",
                table: "HistoryStatuses",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OrderId",
                table: "Reviews",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Views_ProductId",
                table: "Views",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "HistoryStatuses");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Views");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
