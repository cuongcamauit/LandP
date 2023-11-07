using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
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
                name: "Menus",
                columns: table => new
                {
                    slugId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.slugId);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Menus",
                        principalColumn: "slugId");
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
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    isDefault = table.Column<bool>(type: "bit", nullable: false)
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
                name: "AttributeOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeOptions", x => new { x.Id, x.AttributeId });
                    table.ForeignKey(
                        name: "FK_AttributeOptions_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttributeGroups",
                columns: table => new
                {
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeGroups", x => new { x.AttributeId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_AttributeGroups_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeGroups_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FolderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
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
                name: "Slugs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSilder = table.Column<bool>(type: "bit", nullable: false),
                    MenuId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slugs_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "slugId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    ShippingFee = table.Column<double>(type: "float", nullable: false),
                    ShippingFeeVoucher = table.Column<double>(type: "float", nullable: false),
                    ShopVoucher = table.Column<double>(type: "float", nullable: false),
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
                name: "AttributeSpecs",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeSpecs", x => new { x.ProductId, x.AttributeId });
                    table.ForeignKey(
                        name: "FK_AttributeSpecs_AttributeOptions_OptionID_AttributeId",
                        columns: x => new { x.OptionID, x.AttributeId },
                        principalTable: "AttributeOptions",
                        principalColumns: new[] { "Id", "AttributeId" });
                    table.ForeignKey(
                        name: "FK_AttributeSpecs_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ProductPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
                name: "SlugProducts",
                columns: table => new
                {
                    SlugId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlugProducts", x => new { x.SlugId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_SlugProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlugProducts_Slugs_SlugId",
                        column: x => x.SlugId,
                        principalTable: "Slugs",
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
                    Price = table.Column<double>(type: "float", nullable: false)
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
                    { "04be0c35-571e-425c-992e-15a7227286de", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "093e46bd-c8bc-433f-b787-40612a589754", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com", true, false, null, "User", "landpuserdemo@gmail.com", null, "AQAAAAEAACcQAAAAEGgDTcm9pl3Mr9iFGY7W4MaCd6YgcXOAnoKL7bBUY1TPTdKL2eVWL6lGEsF/DI2vzQ==", null, false, "b39d0501-eea1-4dac-a14c-c377a24aa77f", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com" },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a92574a8-1cda-48b1-96d3-8c62ea91beb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com", true, false, null, "User1", "landpuserdemo1@gmail.com", null, "AQAAAAEAACcQAAAAEFHFF3lY7OpTp8+KLg/h6n7EeGR6aidTzKBhfD7ipiqHCrpz8rkooxwvIOyzm37rCw==", null, false, "8bc3a39d-4059-4d82-9b1e-95650307bb08", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12fcdd95-6a64-4336-898e-93eaf0139645", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com", true, false, null, "Super Admin", "landpsupadmika@gmail.com", null, "AQAAAAEAACcQAAAAEDPNSjuijuGtzfdzFDX57hTfYdvQm8+PCl+JBxCfZvke4mdEAUxupGeLgpBksmFwfg==", null, false, "51d70255-a690-45f1-800a-eb83ec318e21", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "265a0e10-7fb1-432f-b4ee-739cb743690d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com", true, false, null, "Admin", "landpadmika@gmail.com", null, "AQAAAAEAACcQAAAAEPC66+FYW/QXs3fRHG7OBpVreItvgj+j92HJSq2v7huLnPGuNushLVZemS9P1oJ+4A==", null, false, "37c18347-2195-417b-9296-e402d23aba91", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com" }
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
                columns: new[] { "Id", "CustomerId", "Detail", "DistrictId", "DistrictName", "ProvinceId", "ProvinceName", "WardCode", "WardName", "isDefault" },
                values: new object[,]
                {
                    { new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", "Khóm 5", 1654, "Thành phố Cà Mau", 252, "Cà Mau", "610107", "8", false },
                    { new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", "Đường Tô Ký", 1454, "Quận 12", 202, "Thành phố Hồ Chí Minh", "21204", "Phường Tân Chánh Hiệp", false }
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
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("034573e2-712f-4095-ba28-3b0cdaa1c291"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("0dc865d5-c725-40a9-8fc8-54e7ffb8bc63"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau khi trình làng hàng loạt mẫu iPhone vào tháng 09/2022 thì Apple cũng đã tiếp tục giới thiệu series iPad mới cho năm 2022. Trong đó iPad 10 WiFi 64GB là cái tên được hãng chú trọng khá nhiều về việc tối ưu giá thành nhằm giúp người dùng có thể dễ dàng tiếp cận. Máy hỗ trợ hệ điều hành iPadOS 16 cùng con chip Apple A14 Bionic giúp mang lại hiệu năng vượt trội.", "18kx0xh8gVJAJllf-4ZVeFZFfkJHI1zkX", "https://drive.google.com/uc?export=view&id=1PjgSj70e2Oc1GC-DJBiVkzs77mAdEokF", false, "iPad 10", 11190000.0, 10, "Unit" },
                    { new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi Redmi Note 12 Pro 5G là mẫu điện thoại thuộc dòng Redmi Note được chính thức ra mắt trong năm 2023, máy mang trên mình những cải tiến vượt trội về thiết kế, camera và hiệu năng, đáp ứng mượt mà hầu hết các nhu cầu khác nhau của người dùng.", "1gBdpMXybH0HOxSKI6g9AdmisL9IUMfPq", "https://drive.google.com/uc?export=view&id=190zjmRvUnsTZdB4iDizNBjqKI_fk5L3a", false, "Xiaomi Redmi Note 12 Pro 5G", 9960000.0, 50, "Unit" },
                    { new Guid("1429c801-f882-47fc-91ba-6f9572fbb443"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("242e3a90-3290-440c-954e-707fdbb39b3a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n2 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A14 Bionic\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n2815 mAh20 W", "1b9JWfgUruHr6j3U3XalWbAD2UO329_6X", "https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By", false, "Iphone 12", 15590000.0, 50, "Unit" },
                    { new Guid("2c3309b8-5e91-4451-a2b0-270ee2cf33ca"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("3e9d9046-0534-44cf-a0fa-746a31acad9f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau thành công của iPad 8, Apple cho đã cho ra mắt máy tính bảng iPad 9 WiFi 64GB - phiên bản tiếp theo của dòng iPad 10.2 inch, về cơ bản nó kế thừa những điểm mạnh từ các phiên bản trước đó và được cải tiến thêm hiệu suất, trải nghiệm người dùng nhằm giúp nhu cầu sử dụng giải trí và làm việc tiện lợi, linh hoạt hơn", "1SZ3o96HmpNycsXIeOzuXBDF3dgh6v85o", "https://drive.google.com/uc?export=view&id=1IK5bpXd3iGWJbMDOS5c_zG5Zk5th3hhl", false, "iPad 9", 7990000.0, 10, "Unit" },
                    { new Guid("4d8cbe5f-b318-4101-959d-8fc1a1b17a3a"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("5d7beeaf-f51e-44bb-ae26-aadb1bdc0276"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nếu bạn đang tìm kiếm một chiếc laptop gaming nhưng vẫn sở hữu một mức giá phải chăng thì laptop Asus TUF Gaming F15 FX506LHB i5 (HN188W) sẽ là sự lựa chọn đáng cân nhắc với card đồ họa rời NVIDIA GeForce GTX mạnh mẽ cùng phong cách thiết kế cứng cáp, độc đáo. ", "1504cqv26tU1E4JAWix9Ajxwh3XCH8tOv", "https://drive.google.com/uc?export=view&id=1s_UzQewLQ4zb7cX25cwUYAlVa3CpuCP9", false, "TUF Gaming F15", 16990000.0, 50, "Unit" },
                    { new Guid("61a1dce1-164c-4a2f-a6e1-6397c5033bfb"), new Guid("fc1a0ff3-92d8-4a16-adb5-8c901bbe48f2"), new Guid("76f4c144-6e3f-44bf-a292-8dd21a461b5d"), "Chuột Không dây Bluetooth Silent Logitech Signature M650 sở hữu kiểu dáng công thái học cùng độ phân giải lớn, đáp ứng tốt gần như mọi nhu cầu từ sử dụng cơ bản tới những tác vụ chuyên nghiệp của người dùng.", "1M0-dUHbo7g_pkLPbQu9NMTPc9tnGkwr7", "https://drive.google.com/uc?export=view&id=1ukyWOlXUIJzxVzjmNN5hPlrnHN0yET7b", false, "Bluetooth Silent Logitech Signature M650", 765000.0, 10, "Unit" },
                    { new Guid("6955eb13-86b8-456a-a676-3d29af3e764f"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("777ffbe5-1f43-4b6c-80d3-6b3cffbcb721"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Sau thành công của dòng Galaxy Watch4, tháng 8/2022 ông lớn công nghệ Samsung đã cho ra mắt thế hệ smartwatch tiếp theo của hãng mang tên Samsung Galaxy Watch5 40 mm.", "1v5XPVE3A_7XnX4yUf8OekLE54mHXr_CZ", "https://drive.google.com/uc?export=view&id=17uBw10YiFMD2ET9pw_wiXkznPsQrAhr0", false, "Samsung Galaxy Watch5", 5490000.0, 10, "Unit" },
                    { new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new Guid("2d750aa2-ea06-47ea-916c-abb6661f9781"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Đồng hồ thông minh Suunto 7 Dây silicone phiên bản màu đen trang bị mặt kính cường lực chống va đập, màn hình AMOLED 1.97 inch (454 x 454 pixels) cùng độ sáng lên tới 1000 nits, vì thế có thể hiển thị sắc nét ngay cả khi ở điều kiện có ánh sáng mặt trời. Đặc biệt, với thiết kế dây đeo silicone tạo cảm giác mềm mại và dễ chịu khi đeo trong thời gian dài.", "15B4NY2lAFY9DXr1Z40hwoQNjI5ZjnpZ4", "https://drive.google.com/uc?export=view&id=1-nQviihO_G_HGipaWd72aRUURK4zkm6S", false, "Suunto 7", 7250000.0, 5, "Unit" },
                    { new Guid("7ef93a25-83c7-42d3-85e1-a3e18b234ac0"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("87fb9b17-751c-42e2-b506-89717496646a"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("99c30773-c617-419d-a12a-2e2db67f3faa"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("b1b356c3-4fe5-41ef-8679-653992ac0721"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi 12T series đã ra mắt trong sự kiện của Xiaomi vào ngày 4/10, trong đó có Xiaomi 12T 5G 128GB - máy sở hữu nhiều công nghệ hàng đầu trong giới smartphone tiêu biểu như: Chipset mạnh mẽ đến từ MediaTek, camera 108 MP sắc nét cùng khả năng sạc 120 W siêu nhanh.", "1RvQvCVJ2wk72oMqDuYfeuTBHSIHNhplS", "https://drive.google.com/uc?export=view&id=165CbvBDjo8PPjxn2MPHVe2YrZPZ1oCwd", false, "Xiaomi 12T 5G 128GB", 9890000.0, 3, "Unit" },
                    { new Guid("cdf09130-c814-416e-ba4b-59078bdbf4e1"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("ce2bb946-c098-43e9-bf2e-e83fbe8bf903"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nPLS TFT LCD6.6\"Full HD+\r\nHệ điều hành:\r\n\r\nAndroid 12\r\nCamera sau:\r\n\r\nChính 50 MP & Phụ 5 MP, 2 MP, 2 MP\r\nCamera trước:\r\n\r\n8 MP\r\nChip:\r\n\r\nSnapdragon 680\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n2 Nano SIMHỗ trợ 4G\r\nPin, Sạc:\r\n\r\n5000 mAh25 W", "12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn", "https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL", false, "Samsung Galaxy A23", 4990000.0, 100, "Unit" },
                    { new Guid("d06f0a2f-f1bd-4322-bd28-d59eb55e010b"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("d5682976-7d8c-4549-884c-e85f73ddbed3"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Vostro 3510 i5 (P112F002BBL) sở hữu cấu hình mạnh mẽ, đa nhiệm mượt mà trên sức mạnh của bộ vi xử lý Intel thế hệ 11, cùng một thiết kế đơn giản mà sang đẹp, sẽ là lựa chọn đắt giá đáp ứng nhu cầu học tập, làm việc hay giải trí của bạn.", "1R9qzBw6zNwBARHF8aGu2_qJYlil161yl", "https://drive.google.com/uc?export=view&id=1ELd9fd2dk2meSyxz-hVnsIp8_gFrnHxp", false, "Dell Vostro 3510", 17990000.0, 10, "Unit" },
                    { new Guid("db75a250-2626-44e7-9177-ec16d1a9883c"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("e36801b3-6cc9-426c-8e4c-e7b86d89db40"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("ebd97c78-cc87-4a30-b146-571892dae36d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("f8bb0d7a-eed0-4295-97b1-03e206e66c6b"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("fb732361-a9fc-4eef-9911-013209aa2366"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" }
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
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("039c02f8-295e-47f7-bf41-df7563060515"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4433), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4415), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4416), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("5de24961-48a5-4496-816e-1840a6889924"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4424), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4414), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("7dc81bcc-6b9b-4f33-a102-bc3fc5303fec"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4430), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("89fe8d4e-588f-4da1-8f72-3c3ca91ad478"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4420), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("91c610c1-b1eb-45a2-9380-8a679ac6ddda"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4426), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("b68d7699-772a-4e9a-a994-b5488ee73fa6"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4418), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4409), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("e873a5c3-8af2-4df2-a3d7-c8c55ff1feb6"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4428), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("ed6294ff-6e5e-4318-9cd7-7abeee62f237"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4423), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Views",
                columns: new[] { "CustomerId", "ProductId", "Date", "Quantity" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4332), 1 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4313), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4334), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4335), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4333), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4336), 1 }
                });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("12f54cd6-ed2f-4717-af76-7cb4bc546fc4"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4661), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("2e163394-e7f4-43c6-a445-3563c069bc33"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4646), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("52a3cbbb-fa9c-490f-8a2c-14f2e53022a1"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4634), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("5d53d573-3ed5-43cf-b613-2ccf42a40fbd"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4631), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("763f6c49-45f8-4cb3-a586-00717c1d0303"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4654), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("7a549847-c92e-44d3-996c-959fc47f650e"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4663), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("a240a097-8c19-4faa-aca8-05c9addaef97"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4665), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("ade93783-ed18-4190-b154-d95e209be33f"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4667), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("be27e5a5-f3b9-4aa4-9f28-7c02d669a892"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4648), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("beddfc09-c02b-4ab6-97f1-df65ef4e08bb"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4629), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("e22ac8a7-3c52-4028-be85-fa4441297bd9"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4644), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("ef8860b5-7525-47bd-9a96-85ce21dfd15c"), new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4622), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("039c02f8-295e-47f7-bf41-df7563060515"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 4 },
                    { new Guid("5de24961-48a5-4496-816e-1840a6889924"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 2 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 15590000.0, 1 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 3 },
                    { new Guid("7dc81bcc-6b9b-4f33-a102-bc3fc5303fec"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("89fe8d4e-588f-4da1-8f72-3c3ca91ad478"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("91c610c1-b1eb-45a2-9380-8a679ac6ddda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b68d7699-772a-4e9a-a994-b5488ee73fa6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 1 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 15590000.0, 2 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 3 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), 4990000.0, 2 },
                    { new Guid("e873a5c3-8af2-4df2-a3d7-c8c55ff1feb6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("ed6294ff-6e5e-4318-9cd7-7abeee62f237"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4739), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4734), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4741), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4737), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("039c02f8-295e-47f7-bf41-df7563060515"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4756), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4740), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("7dc81bcc-6b9b-4f33-a102-bc3fc5303fec"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4755), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4736), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), "Good", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4731), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ổn trong tầm giá", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4743), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5de24961-48a5-4496-816e-1840a6889924"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4750), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("89fe8d4e-588f-4da1-8f72-3c3ca91ad478"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4748), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("91c610c1-b1eb-45a2-9380-8a679ac6ddda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4751), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b68d7699-772a-4e9a-a994-b5488ee73fa6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4744), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e873a5c3-8af2-4df2-a3d7-c8c55ff1feb6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4753), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("ed6294ff-6e5e-4318-9cd7-7abeee62f237"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 11, 7, 10, 54, 18, 56, DateTimeKind.Local).AddTicks(4749), 5 }
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
                name: "IX_AttributeGroups_CategoryId",
                table: "AttributeGroups",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOptions_AttributeId",
                table: "AttributeOptions",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeSpecs_AttributeId",
                table: "AttributeSpecs",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeSpecs_OptionID_AttributeId",
                table: "AttributeSpecs",
                columns: new[] { "OptionID", "AttributeId" });

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
                name: "IX_Menus_ParentId",
                table: "Menus",
                column: "ParentId");

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
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrices",
                column: "ProductId");

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
                name: "IX_SlugProducts_ProductId",
                table: "SlugProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Slugs_MenuId",
                table: "Slugs",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

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
                name: "AttributeGroups");

            migrationBuilder.DropTable(
                name: "AttributeSpecs");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "HistoryStatuses");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SlugProducts");

            migrationBuilder.DropTable(
                name: "Views");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AttributeOptions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Slugs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
