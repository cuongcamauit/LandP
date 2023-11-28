using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    { "04be0c35-571e-425c-992e-15a7227286de", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "553c6f83-c021-4a96-a181-4cf90824026e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com", true, false, null, "User", "landpuserdemo@gmail.com", null, "AQAAAAEAACcQAAAAEIn6No2h1MhHrhJ6UYBpB6L8MHmNgG/FHAGP8nyoEyuyJ6VXIoAtLZX0EoJCEBzXfQ==", null, false, "8a258324-c5d3-4902-bdd3-73d335ebec7d", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com" },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3bdd4d17-941e-4357-8279-0ce0020181cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com", true, false, null, "User1", "landpuserdemo1@gmail.com", null, "AQAAAAEAACcQAAAAEFWtdGs741UYoAtYozbHGsLVWpaLRQOEwuekyjpMVQPMH/j21efNY0GoiaY/rR02XQ==", null, false, "f1bc11bc-cf99-4bce-8a7f-f373e036d053", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b13e5e5-c07c-4801-a73e-165c4c81f313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com", true, false, null, "Super Admin", "landpsupadmika@gmail.com", null, "AQAAAAEAACcQAAAAEEFLQOaiNupK7UFutTYf0oSoV693G+9GZlL72N3AbFuxgewrvW/5x6oANdwBoI6UcQ==", null, false, "e9421996-5e26-42f0-b757-4ee3b5b6abc3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "beb22cb4-880a-4ce4-afc1-24060e508592", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com", true, false, null, "Admin", "landpadmika@gmail.com", null, "AQAAAAEAACcQAAAAEJVQuv8NY2kC120EydStbJrt4DyliimrSumQyqJwkebmBokVk2Wxtk2yN3cuGMomLg==", null, false, "6a2ddc25-1465-4080-a258-61b02e14e1e1", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Trademark" },
                    { 2, null, "Warranty" },
                    { 3, null, "Laptop series" },
                    { 4, null, "Colour" },
                    { 5, null, "Demand" },
                    { 6, null, "CPU generation" },
                    { 7, null, "CPU" },
                    { 8, null, "Graphics chip" },
                    { 9, null, "RAM" },
                    { 10, null, "Monitor" },
                    { 11, null, "Archive" },
                    { 12, null, "Video output port" },
                    { 13, null, "Gateway" },
                    { 14, null, "Wireless connection" },
                    { 15, null, "Keyboard" },
                    { 16, null, "Operating system" },
                    { 17, null, "Dimension" },
                    { 18, null, "Battery" },
                    { 19, null, "Mass" },
                    { 20, null, "Included accessories" },
                    { 21, null, "Series" },
                    { 22, null, "Screen type" },
                    { 23, null, "Resolution" },
                    { 24, null, "Capacity(ROM)" },
                    { 25, null, "Chip" },
                    { 26, null, "Battery technology" },
                    { 27, null, "Charging port" },
                    { 28, null, "SIM type" },
                    { 29, null, "Mobile networks" },
                    { 30, null, "Rear camera" },
                    { 31, null, "Front camera" },
                    { 32, null, "Wifi" },
                    { 33, null, "GPS" },
                    { 34, null, "Blutooth" },
                    { 35, null, "Headphone jack" },
                    { 36, null, "Feature" },
                    { 37, null, "Case Size" },
                    { 38, null, "Screen technology" },
                    { 39, null, "Screen size" },
                    { 40, null, "Glass Material" },
                    { 41, null, "Internal memory" },
                    { 42, null, "Connect" },
                    { 43, null, "Time of use" },
                    { 44, null, "Material" },
                    { 45, null, "Strap" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), "Dell Inc is an American multinational company that develops and commercializes computer technology headquartered in Round Rock, Texas, United States. In 1984, Dell was founded by Michael Dell. It is the 28th largest company by revenue in the United States", "", "Dell" },
                    { new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), "Samsung Group or Samsung (Korean: 삼성, Roma: Samseong, Hanja: 三星; Sino-Vietnamese: Tam Tinh - 3 stars) is a South Korean multinational corporation headquartered in Samsung Town, Seocho , Seoul", "", "Samsung" },
                    { new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), "Xiaomi is a Chinese technology corporation , headquartered in Beijing. Considered the Apple of China, after only 5 years of establishment, Xiaomi has become the smartphone manufacturer with the 5th largest market share in the world and 1st in its home market (2015)", "", "Xiaomi" },
                    { new Guid("36326612-2d44-446f-87cd-d060d14237a6"), "Apple is a large American technology corporation headquartered in Cupertino, California. Apple was founded on April 1, 1976 by three founders Steve Wozniak, Steve Jobs and Ronald Wayne, under the original name Apple Computer Inc, then changed its name to Apple in early 2007", "", "Apple" },
                    { new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), "In 2015 and 2016, Fortune magazine recognized ASUS as one of the world's most popular companies, and for the past four years, Interbrand has ranked ASUS as Taiwan's most valuable international brand . Loan", "", "Assus" },
                    { new Guid("fc6fcd3e-f156-4a33-a257-c92adfba2c63"), "Founded in 1976, Acer is a Taiwanese multinational corporation of electronics and computer hardware", "", "Acer" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AvatarUrl", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "", "A smart device", "Smartwatch" },
                    { new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "", "A smart device", "Laptop" },
                    { new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "", "A smart device", "Tablet" },
                    { new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "", "A smart device", "Smartphone" }
                });

            migrationBuilder.InsertData(
                table: "Slugs",
                columns: new[] { "Id", "Image", "IsDeleted", "IsSilder", "MenuId", "Title" },
                values: new object[,]
                {
                    { "best-sale", "https://cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/homev2/fs-0611-1211-theme/desk/tgdd/banner-title.gif", false, true, null, "Sale up to 50%" },
                    { "black-friday", "https://ben.com.vn/tin-tuc/wp-content/uploads/2021/10/black-friday-la-ngay-bao-nhieu-750x536.jpg", false, true, null, "Black Friday" },
                    { "laptop", "https://lh3.googleusercontent.com/lFZZtBMUqkbl9qKKUe3DSmHqpb62UjWrOkxqcJ6lN3yM83Wg2Irp-ZlvkUwGO6TMcsscLELMZa_lN9jo8tKteWsCzmUii7po=rw", false, false, null, "Laptop" },
                    { "laptop-acer", null, false, false, null, "Acer" },
                    { "laptop-apple-macbook", null, false, false, null, "Apple (Macbook)" },
                    { "laptop-asus", null, false, false, null, "ASUS" },
                    { "laptop-dell", null, false, false, null, "Dell" },
                    { "sale-laptop", "https://static.vecteezy.com/system/resources/thumbnails/006/241/067/small/abstract-polygon-3d-triangle-yellow-geometric-background-free-photo.jpg", false, true, null, "Laptop gaming sale up to 40%" },
                    { "smartphone", "https://lh3.googleusercontent.com/qtC62XnXkTsyJbMok7Z7Uu5GOPvhqslzU5YscZZ0HvorTWRs0Qg5s8gWU6l6CTcmc-pQA2y1myJCZ92t9VDq=rw", false, false, null, "Smartphone" },
                    { "smartphone-iphone", null, false, false, null, "Iphone" },
                    { "smartphone-samsung", null, false, false, null, "Samsung" },
                    { "smartphone-xiaomi", null, false, false, null, "Xiaomi" },
                    { "smartwatch", "https://th.bing.com/th/id/R.2650cb6112fbd5590eb781022a3c148e?rik=ZlMWy8mm%2fzwGTg&pid=ImgRaw&r=0", false, false, null, "Smartwatch" },
                    { "smartwatch-apple", null, false, false, null, "Apple" },
                    { "tablet", "https://lh3.googleusercontent.com/dkzFFaKYmPLLkPnC-cyefC1u1Qh0Iy_6Loz7adsbIMs-KAK8FA_PwUOklM3gEppESc1uSeaTa63U4Vejifo=rw", false, false, null, "Tablet" },
                    { "tablet-ipad", null, false, false, null, "Apple (iPad)" },
                    { "tablet-samsung", null, false, false, null, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CustomerId", "Detail", "DistrictId", "DistrictName", "ProvinceId", "ProvinceName", "WardCode", "WardName", "isDefault" },
                values: new object[,]
                {
                    { new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", "Khóm 5", 1654, "Thành phố Cà Mau", 252, "Cà Mau", "610107", "8", true },
                    { new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", "Đường Tô Ký", 1454, "Quận 12", 202, "Thành phố Hồ Chí Minh", "21204", "Phường Tân Chánh Hiệp", true }
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
                table: "AttributeOptions",
                columns: new[] { "AttributeId", "Id", "Value" },
                values: new object[,]
                {
                    { 1, 1, "APPLE" },
                    { 3, 1, "Macbook Pro" },
                    { 4, 1, "Silver" },
                    { 5, 1, "Business" },
                    { 6, 1, "Apple M" },
                    { 9, 1, "4GB" },
                    { 10, 1, "11.6\"" },
                    { 16, 1, "Android" },
                    { 1, 2, "ACER" },
                    { 3, 2, "Macbook Air" },
                    { 4, 2, "Gold" },
                    { 5, 2, "Entrepreneur" },
                    { 6, 2, "Celeron" },
                    { 9, 2, "8GB" },
                    { 10, 2, "12.3\"" },
                    { 16, 2, "iOS" },
                    { 1, 3, "ASUS" },
                    { 3, 3, "Aspire 5" },
                    { 4, 3, "Red" },
                    { 5, 3, "Gaming" },
                    { 6, 3, "Core i3" },
                    { 9, 3, "16GB" },
                    { 10, 3, "13\"" },
                    { 1, 4, "Dell" },
                    { 3, 4, "Nitro 5" },
                    { 4, 4, "Midnight" },
                    { 5, 4, "Family" },
                    { 6, 4, "Core i5" },
                    { 9, 4, "24GB" },
                    { 10, 4, "13.3\"" },
                    { 1, 5, "Samsung" },
                    { 3, 5, "Nitro 16" },
                    { 4, 5, "Starlight" },
                    { 5, 5, "Students" },
                    { 6, 5, "Core i7" },
                    { 9, 5, "32GB" },
                    { 10, 5, "13.4\"" },
                    { 1, 6, "Xiaomi" },
                    { 3, 6, "Vivobook" },
                    { 4, 6, "White" },
                    { 5, 6, "Office" },
                    { 6, 6, "Core i9" },
                    { 9, 6, "64GB" },
                    { 10, 6, "13.5\"" },
                    { 3, 7, "Inspiron" },
                    { 4, 7, "Sand gold" },
                    { 5, 7, "Graphics - Engineering" },
                    { 6, 7, "Qualcomn" },
                    { 10, 7, "13.6\"" },
                    { 3, 8, "Vostro" },
                    { 4, 8, "Bronze gold" },
                    { 6, 8, "Snapdrogon" },
                    { 10, 8, "14\"" },
                    { 4, 9, "Green" },
                    { 6, 9, "Ryzen 3" },
                    { 10, 9, "14.2\"" },
                    { 4, 10, "Grey" },
                    { 6, 10, "Ryzen 5" },
                    { 10, 10, "14.5\"" },
                    { 4, 11, "Silver gray" },
                    { 6, 11, "Ryzen 7" },
                    { 10, 11, "15.3\"" },
                    { 4, 12, "Dark gray" },
                    { 6, 12, "Ryzen 9" },
                    { 10, 12, "15.6\"" },
                    { 4, 13, "Black" },
                    { 10, 13, "16\"" },
                    { 10, 14, "16.1\"" },
                    { 10, 15, "17\"" },
                    { 10, 16, "17.3\"" },
                    { 10, 17, "18\"" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "134Zgrr4qGMDGTvc5iv-ajH2cELOW9GsK", "https://lh3.googleusercontent.com/QQEbvWwDKVxZedtS1EFexrYOZa6RqhW1J7mFYZU_IiMjbwV5fWHQWXvCxwwdv5hWK-GMOgthkMOslRRCAIUSA5p-HyCLbLE=w500-rw", false, "Laptop Dell Vostro 3430 (i7-1355U/RAM 16GB/512GB SSD/ Windows 11 + Office)", 26690000.0, 100, "Unit" },
                    { new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), new Guid("fc6fcd3e-f156-4a33-a257-c92adfba2c63"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Acer Aspire 5 A514-55-5954 NX. K5BSV.001 is one of the top choices for students as well as office workers. With a minimalist but still extremely sophisticated design along with powerful performance thanks to the Intel Core i5 CPU will be a great assistant for you in work, study as well as entertainment", "1U7gBEhG9szCsxXY95gzGO-mDX5M21Ric", "https://lh3.googleusercontent.com/dF2OlQH_sxhOSNEUvCpUhODxCVoNqtrPHIDtosatk9iKmkmc_k6uq_5salWjPEob-5U1urzlFmTtqpByX7kvmdn0cKFB43Ps=w500-rw", false, "Laptop ACER Aspire 5 A514-55-5954 (NX.K5BSV.001) (i5-1235U/RAM 8GB/512GB SSD/ Windows 11)", 19990000.0, 100, "Unit" },
                    { new Guid("160df69f-314c-4441-9415-3771c02be5ff"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1ildfLhZpElIwWRcHPfmhIe9xwWhusoTY", "https://lh3.googleusercontent.com/b00d0m8txaixII_rmYYCu1W1N0yeXlgANpNPvGC6ATQLAFZWbyqtUnAMqJhTsirVuwCVMXb0FwX6JXBPRPQLtAmGujAbLNuS=w500-rw", false, "Laptop Dell Inspiron 3530 - N5I5791W1 (i5-1335U/RAM 16GB/512GB SSD/ Windows 11 + Office)", 20290000.0, 100, "Unit" },
                    { new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1sxNQzMjOHSJ7fTAIWGWdVkx1YkuAxdbw", "https://lh3.googleusercontent.com/JzaLDtRkM112HJ0nqZ1SiIVOxSimMwOgmCx00Bbat3LXC7H-cCja3vJJg4Ac70UHfE2TVGCMp6loAqLMUT8VD0WSvxCqphM=w500-rw", false, "Laptop Dell Inspiron 14 5430 (i7-1360P/RAM 16GB/1TB SSD/ Windows 11 + Office)", 31490000.0, 100, "Unit" },
                    { new Guid("25a9275b-b220-4063-8b38-864efb9d08f2"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Updating", "18B4NF_mYnJqpx41VfJLjAGBKbtQyfB4M", "https://lh3.googleusercontent.com/h1DPkY2SVo3kw4e37lnqiJRd1nd5QlaNPDXxjiF8UJ4yakeTrR1wNzGO4W7qTMjSy8qQI7_2yS_B2M6975c4ceziO__U0MryBw=w500-rw", false, "Apple Watch Ultra 2 4G 49mm (Blue Olive Alpine - M Titanium Case) (MREY3VN/A)", 25990000.0, 100, "Unit" },
                    { new Guid("337e8f9b-fe09-4d5c-ba48-53d2514088ea"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Updating", "10Z1Q2lr51ycdqF6fejHz_WgoaX7qDpYl", "https://lh3.googleusercontent.com/knEb077WDBllxLpzXhn_3HIAoR-l7TvZzCd2fsUL7P1dOeN5W6WDNQVDBn3xpHIir8jYE37c9s0ZI47I-rtni2dm2SB5xe8shg=w500-rw", false, "Samsung Galaxy A05 (4+128) (Black) (SM-A055FZKGXXV)", 3090000.0, 100, "Unit" },
                    { new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "ASUS Vivobook X515EA-EJ3633W laptop (i3-1115G4) is equipped with Intel Core i3 CPU, 8GB Onboard DDR4 RAM capacity along with 512GB SSD hard drive for you to freely store study data, basic work with office tasks. Anti-glare screens help protect your eyes well from harmful blue light", "1lge0An1ZzjQlD3oV-cjenDJ9M4WJzTL7", "https://lh3.googleusercontent.com/kkZs0JLWxfJpJg1dMiuzMDNayo_HpxHAaCQzVHE_ecuXjXD3vvZTGynpe4S2Ou5Y0FR-HVCIh4UU_o11huEYAm104zukaYlk=w500-rw", false, "Laptop ASUS Vivobook X515EA-EJ3633W (i3-1115G4/RAM 8GB/512GB SSD/ Windows 11)", 11290000.0, 100, "Unit" },
                    { new Guid("4bbb500c-b891-4bc5-ae09-61181631eaed"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "In the iPhone 15 series collection launched in 2023, iPhone 15 Plus in particular and other iPhone 15 versions in general are highly appreciated to have a leap in new design, outstanding features are improved compared to the iPhone 14 series in 2022, bringing a completely new experience for iPhone enthusiasts. Join Phong Vu to learn about iPhone 15 Plus through this article!", "1PeJEiAIBag3DupEC0hZOI4BRKqtuoTI5", "https://lh3.googleusercontent.com/_eACMH4Tyg60SnkYcrMPgscrJ1P6PB8I_hmIUdWjDouY-hSJ44lNjiD2BDE6XMQ_ZUoIUvU9C4zlJCfBOwv5AC-eA6eQC1g=w500-rw", false, "iPhone 15 Plus - Genuine VNA", 27990000.0, 100, "Unit" },
                    { new Guid("67a25c7b-6bd8-4c9f-af25-b607a399552e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max launched in September 2022 has made a prominent mark on the smart mobile market worldwide by an impressive makeover of the \"Dynamic Island\" screen design. iPhone 14 pro series is favored by Apple when equipped with a powerful A16 Bionic chip with outstanding processing performance, helping you perform many tasks on the device at the same time without jerking or lag", "10CQlOpmK0_9G6lBaJnvZ5TvXnecJOFgR", "https://lh3.googleusercontent.com/Y1OVqtPmmjFd3lzbR0onqBQLgUtNkiX2T4zCffguTiZoMs73EJ9naybVgmrRat4i6bqWSC6oMQYvkWZlKxWlddEY3EzNvIj6=w500-rw", false, "iPhone 14 Pro Max | Genuine VNA", 36990000.0, 100, "Unit" },
                    { new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1oRNlAF2LJEdMnyJsNbCGtirUa0GxSEYC", "https://lh3.googleusercontent.com/T4dQPx6nSJi3y147mwJH6kDJsxM6ULAAtIoZjgDDIi3yF5YpFYW7QbWh_nfT0Lhi2LxIDFuNPMamXlrBW-EcZ1NUGYBZ6VqbLw=w500-rw", false, "MacBook Air 2022 13.6 inch MLY33SA/A (M2/ 8GB/ SSD 256GB)", 31900000.0, 100, "Unit" },
                    { new Guid("78e9f709-ee91-4f58-82e7-50edf62fd3bf"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Updating", "1FGeL7rFIhopiQKRmN4N47myHzxBOSmOB", "https://lh3.googleusercontent.com/rT4c6CfzG8osJnzcpD4kDpdmInxJZ3y_qKBaR5OiMKNUWvV3KDVCh5Ke4vm6D2tmQYluG4_gVDR5wHKgob2lKasef-ODOmWh=w500-rw", false, "iPhone 13 mini 128GB (pink) (3J765VN/A) (DEMO) (PINK) - Exhibits", 17490000.0, 100, "Unit" },
                    { new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1kX3Ic2DGpw7jR46-iNGWgpDlHGHNt40o", "https://lh3.googleusercontent.com/GBCMEXu9-VgSeUAO8fW-XlSD-9GGd5YYwOkH8yi3cQOn0rRXFvNbIkDhoQbcr0iI3aeO6PDS4hHS2ZbQDhA8Rwedz5u1VOnS=w1000-rw", false, "Laptop ASUS Vivobook 16 M1605YA-MB303W (Ryzen 7 7730U/RAM 16GB/512GB SSD/ Windows 11)", 18490000.0, 100, "Unit" },
                    { new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), new Guid("fc6fcd3e-f156-4a33-a257-c92adfba2c63"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "As a gaming laptop line of the Acer brand, the Acer Nitro 5 Eagle AN515-57-54MV laptop is equipped with a powerful i5 chip, NVIDIA GeForce RTX 3050 graphics card, 8Gb ram and large capacity. Combined with its beautiful and powerful design, this will be the choice for young gamers and people doing graphics-related work", "1p7PobtADVoyyLZnOokk2ltDiFCAsdyfL", "https://lh3.googleusercontent.com/c7VuA4P8sHHJCilfzRVp50AQmgZEkJOyOCuh4vvkcT9jxfqTzZVd2gepUFSSqzXVSEljnYlAN319sJD-H1IztNcxPT3UypA=w500-rw", false, "Laptop ACER Nitro 5 Eagle AN515-57-54MV (i5-11400H/RAM 8GB/RTX 3050/512GB SSD/ Windows 11)", 25990000.0, 100, "Unit" },
                    { new Guid("86446b09-6675-4c94-a8c9-44abad169e1f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 15 Pro Max belongs to the high-end product line that has just been launched by Apple on the market in 2023, retaining the outstanding design \"Dynamic Island\" along with a series of luxurious colors. The iPhone 15 Pro max is equipped with a new A17 Bionic chip with outstanding and powerful processing performance today to perform the tasks you want", "1Ifg5rJYBvzJtFdk6ZfqM_cUbJvf6k6Mj", "https://lh3.googleusercontent.com/8w4MFwwKtq8dboBtb_bJLWcYgZge4G4G3kVv2tF8yKEQfUeu0xihFhvC2IGiZaQrnSfoZDU_Qcbk938-uolUGIX396P_qlQ=w500-rw", false, "iPhone 15 Pro Max - Genuine VNA", 43990000.0, 100, "Unit" },
                    { new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Updating", "1HVLMIm5HTuj-anZwQGeewsD4XpeioTLx", "https://lh3.googleusercontent.com/WDBs6MVNz4hnSM3L1ukUN98WmnDm7Ag_s_AhLNYVWuvg0lYprSCTmtj8UDNCHu621AvU1eUMwlEylid-_JamBDp1Xdo33W0b=w500-rw", false, "Samsung Galaxy Tab S7 FE LTE Tablet 4GB/64GB (Black) (SM-T735NZKAXXV)", 13990000.0, 100, "Unit" },
                    { new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple's high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today's Apple fans", "1gzBXbbcWwhP3NKwYzlVZ10k362zzQ8WO", "https://lh3.googleusercontent.com/u2qUk5mgupuh9ubXaQxqE2kum6Exm8DygVJFez6Ksj6Yjb6CDjwQ3Jgh7bQ3-TjNxfWxmXTUd6zkxbA2w79-9zTlYsLUp9ah=w1000-rw", false, "MacBook Air 2022 13.6 inch Z15S00092 (M2/ 16GB/ 256GB SSD)", 36890000.0, 100, "Unit" },
                    { new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "The Dell Inspiron 15 3520 3520-71003264 i3-1215U Carbon Black is the perfect office laptop. The device is equipped with Intel Core i3 Alder Lake - 1215U chip, integrated Intel UHD Graphics card. Not too powerful but enough to meet your daily study and work needs", "1yobT5QGolFBw6r3dGOBKtutHG0eizgfy", "https://lh3.googleusercontent.com/nOikqpVL4HXGK3Hs6wKff1Wnl-U7aYbpvw6lu83FHjfGNVGMdF6OyoVLq_pErwB-MmmfDmN7VKIEaQ6Fc9T7k6hKYoXafeYhYg=w500-rw", false, "Laptop Dell Inspiron 15 3520 (3520-71003264) (i3-1215U/RAM 8GB/512GB SSD/ Windows 11 + Office)", 15990000.0, 100, "Unit" },
                    { new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple's high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today's Apple fans.", "14copW3YiYA9OZtplLedaDhsV4LRN2eEz", "https://lh3.googleusercontent.com/cPyVxwDbLfShad22xfK-dd2nlFWqTCSDMHXH7LffhPy37iGunzUM9VUtZCSiEgzzgPGcW3ZkGbImyjcVkf1RrjFr_plC_BjA=w500-rw", false, "Macbook Pro 16 M2 MAX 12C CPU 38C GPU 64GB 1TB SSD (SILVER)", 100190000.0, 100, "Unit" },
                    { new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "10TOIotAbfwDK0MQmc1QyELyxy8oScukl", "https://lh3.googleusercontent.com/sPJkn-BIybufvMuXd1Ut6UkSWqz1UG76-WdZ3JcZ0GS1mNvYlY3_tUAGjzD_TkbC-k3HV_3bgGsmcoB56sbIVCLzcVmul6E=w1000-rw", false, "Macbook Pro 13 M2 8C CPU 10C GPU 24GB 512GB SSD (SILVER)", 49590000.0, 100, "Unit" },
                    { new Guid("c7fac1ba-64b9-40d0-a4fb-31242e76ed68"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Updating", "1R0gypNL_KuXDb4Hsw-TK92OB4wyBcKlN", "https://lh3.googleusercontent.com/xrZTVonyBNNMAjArfukj_4B1xD8O4T_poW3j0SLYpaYVIvei3Pv2zYzefhLA65v_6_2aFfv0953cGXXVZ8UBZAu0g5CLSA=w500-rw", false, "iPad Pro 11 inch M2 Wifi", 23990000.0, 100, "Unit" },
                    { new Guid("ca568ebb-1eb3-4635-b65c-2d1fc2a17e5f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "The set of 4 versions of iPhone 12 is still attractive and has not cooled, but Apple brings users a new super product iPhone 13 with many interesting improvements that promise to bring the most attractive experience to users", "1q9K2oaCGMyerUkMlELsDRoBZrfGXmhNa", "https://lh3.googleusercontent.com/NA85MErOuDh4WfEGmnTIDG6O-SMoCvMve2sGMqKpBJ-CrGCRcdv7Ouo5HpRr-ZrnIbah9GEWcZA_hO7BRmu4wHw0UktOkZgo=w500-rw", false, "iPhone 13 128GB Pink mobile phone (MLPH3VN/A)", 24990000.0, 100, "Unit" },
                    { new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1iEEPx1N9MkI7LBBP_hBwODMvZ6sih4mX", "https://lh3.googleusercontent.com/_w0us6FSWOX-V9byAkNIbBL2BDR0CH7_pQODsmFKEP2PcEHM4O8EfHSy2LpBx35SX5SWgQFNEJ0aW1kPp-_aujK9mhL2_AjBHg=w1000-rw", false, "Laptop ASUS Vivobook 15 X1504VA-NJ025W (i5-1335U/RAM 8GB/512GB SSD/ Windows 11)", 17990000.0, 100, "Unit" },
                    { new Guid("d4958a5d-b450-4f1a-a692-b1f5191c02a5"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Updating", "19a9uKIG6FsYwGBIpdAOOeuybQIfhg_3I", "https://lh3.googleusercontent.com/wSCq7HZuqP30D8ZFZrFpi95EX_GLeN22ZymVx5_it-B8QjrqL2xdQ8q98PJix7lE0BtpOfTaPNVazU84Gv9YyADTC57OAss=w500-rw", false, "Xiaomi Redmi 12C (4GB/64GB) (Blue)", 3590000.0, 100, "Unit" },
                    { new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1SqDtpkZFWiXmnAoeGKMJB0JRg_jZy63g", "https://lh3.googleusercontent.com/lZLaRombXnbrg99vFtGOTiH4zUpkt3PhblRRTZWyqt7DUc-ztoRC6kT2VuuFD9-XJsPYf-8DVJNz1lRCs406a5NWdTROd1I=w1000-rw", false, "MacBook Air 15 M2 8C CPU 10C GPU 8GB 512GB SSD(Midnight)", 39990000.0, 100, "Unit" },
                    { new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "MacBook Air 2020 13.3\" MGNE3SA/A belongs to a high-end laptop product line from the Apple brand that possesses outstanding performance thanks to being equipped with a genuine proprietary processor. With an elegant design and outstanding powerful configuration, MacBook Air 2020 13.3\" MGNE3SA/A promises to bring you an enjoyable experience", "15zxKTkBDtJT9sr9bKwkfAQGZHnM6LjRz", "https://lh3.googleusercontent.com/lc6DzDy1TKN_guYmItGOG1DIWMp3iACXwfMJL4ZdlW501Sqm4j86XGaQDD_mrGiT8OoxFGj7FQGrc5DTR8MSZjrwV0ezEds=w1000-rw", false, "MacBook Air 2020 13.3 inch MGNE3SA/A (M1/8GB/SSD512GB)", 34990000.0, 100, "Unit" },
                    { new Guid("e79b3817-a992-4439-b48b-379fc5e8582f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Product descriptions will be updated as soon as possible!", "1rgiZ9htIqDMEvN_6_xUpKZQ3oXMY704V", "https://lh3.googleusercontent.com/HD6tK_lv_T2Hp6WDHzRREnZI0T-Cnx1hgDTAPuMWZBHB8di1gdeyL5KBZz34diG54BDRF0zqXQL6loA90vL4HoS0jmUYFEc=w500-rw", false, "iPhone 14 128GB", 24990000.0, 100, "Unit" },
                    { new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), new Guid("fc6fcd3e-f156-4a33-a257-c92adfba2c63"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Are you a professional gamer, always want to have the best gaming experience? Are you also a person with a lot of work and study, need a versatile and efficient laptop? Are you also a lover of beauty and fashion, want a laptop with impressive design and convenience? If you have all the above requirements, then you cannot ignore ACER NITRO 16 PHOENIX Gaming Laptop - ACER's national gaming laptop, introduced by Phong Vu at a reasonable price. ACER NITRO 16 PHOENIX Gaming Laptop will satisfy you with the features below, let's find out in the article below!", "14xHS-BcOOmhjY013toMSWulGWKadT_0N", "https://lh3.googleusercontent.com/OzQVKRXMUlErjxiwqtLwpWvOWUbmuLay-lL_o80bXTheu_tfX-j07L8fuGtCgddQTrvaF_hbjKwxMlU7IxMgE_6oTkrW06Gs=w1000-rw", false, "Laptop ACER Nitro 16 Phoenix AN16-41-R5M4 (Ryzen 5 7535HS/RAM 8GB/RTX 4050/512GB SSD/ Windows 11)", 29990000.0, 100, "Unit" },
                    { new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1VCX_PE9G4DIU16blKhPiCdhWPWC6mvR8", "https://lh3.googleusercontent.com/kC9I2-5m1WbJlbXYStTMIuVcLNj1Qex_Bae7GQ1iqEwBzj1GhQSUCy2IJXxL0qinWDyWFlO80JZcYVN1YXLEPnhmsW70t639ww=w500-rw", false, "Laptop Dell Inspiron 16 5630 - i7P165W11SL2050 (i7-1360P/RAM 16GB/512GB SSD/ Windows 11 + Office)", 30990000.0, 100, "Unit" },
                    { new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Updating", "1Wxkpz8DL6OAuA-iE2Y8QfINzWwMdcYN7", "https://lh3.googleusercontent.com/wFM2g6YQMMVWACV2sVKL6ouSZpVFWeIcwvWZ9f1mjyDBOzPNghhib2EPJBLrRUcbrDbC52fSzGwRp8sCLbpvoYHkbE3nsg0=w500-rw", false, "Laptop Dell Inspiron 14 5430 - i5P165W11SL2050 (i5-1340P/RAM 16GB/512GB SSD/ Windows 11 + Office)", 29790000.0, 100, "Unit" }
                });

            migrationBuilder.InsertData(
                table: "AttributeSpecs",
                columns: new[] { "AttributeId", "ProductId", "OptionID", "Value" },
                values: new object[,]
                {
                    { 1, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 4, null },
                    { 2, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "12 months" },
                    { 3, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 8, null },
                    { 4, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 10, null },
                    { 5, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 3, null },
                    { 6, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 5, null },
                    { 7, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "Intel Core i7-1355U ( 1.7 GHz - 5.0 GHz / 12MB / 10 cores, 12 threads )" },
                    { 8, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "GeForce MX550 2GB GDDR6 / Intel Iris Xe Graphics" },
                    { 9, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 3, null },
                    { 10, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), 8, null },
                    { 11, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "1 x HDMI" },
                    { 13, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "Windows 11 Home SL" },
                    { 17, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "1.8 kg" },
                    { 20, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), null, "Adapter, power cord" },
                    { 1, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 2, null },
                    { 2, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "12 months" },
                    { 3, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 3, null },
                    { 4, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 10, null },
                    { 5, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 3, null },
                    { 6, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 4, null },
                    { 7, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "Intel Core i5-1235U ( 1.3 GHz - 4.4GHz / 12MB / 10 cores, 12 threads )" },
                    { 8, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "Onboard Intel Iris Xe Graphics" },
                    { 9, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 2, null },
                    { 10, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), 8, null },
                    { 11, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "1 x HDMI" },
                    { 13, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "Windows 11 Home SL" },
                    { 17, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "4 cell 90 Wh , Built-in battery" },
                    { 19, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "2.6 kg" },
                    { 20, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), null, "Adapter, power cord" },
                    { 1, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 4, null },
                    { 2, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "12 months" },
                    { 3, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 7, null },
                    { 4, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 12, null },
                    { 5, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 1, null },
                    { 6, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 3, null },
                    { 7, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "Intel Core i3-1215U ( 1.2 GHz - 4.4 GHz / 10MB / 6 cores, 8 threads )" },
                    { 8, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "Onboard Intel UHD Graphics" },
                    { 9, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 2, null },
                    { 10, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), 12, null },
                    { 11, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "1 x HDMI" },
                    { 13, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "Windows 11 Home SL" },
                    { 17, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "1.8 kg" },
                    { 20, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), null, "Adapter, power cord" },
                    { 1, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 4, null },
                    { 2, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "12 months" },
                    { 3, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 7, null },
                    { 4, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 1, null },
                    { 5, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 6, null },
                    { 6, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 5, null },
                    { 7, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "Intel Core i7-1360P ( 2.2 GHz – 5.0 GHz / 18MB / 12 cores, 16 threads )" },
                    { 8, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "RTX 2050 4GB GDDR6 / Intel Iris Xe Graphics" },
                    { 9, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 3, null },
                    { 10, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), 8, null },
                    { 11, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "1 x HDMI" },
                    { 13, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "Windows 11 Home SL" },
                    { 17, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "1.8 kg" },
                    { 20, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), null, "Adapter, power cord" },
                    { 1, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 3, null },
                    { 2, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "12 months" },
                    { 3, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 6, null },
                    { 4, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 1, null },
                    { 5, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 6, null },
                    { 6, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 3, null },
                    { 7, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "Intel Core i3-1115G4 ( 3.0 GHz – 4.10 GHz / 6MB / 2 cores, 4 threads )" },
                    { 8, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "Onboard Intel UHD Graphics" },
                    { 9, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 2, null },
                    { 10, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), 12, null },
                    { 11, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "1 x HDMI" },
                    { 13, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "Windows 11 Home SL" },
                    { 17, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "1.8 kg" },
                    { 20, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), null, "Adapter, power cord" },
                    { 1, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 1, null },
                    { 2, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "12 months" },
                    { 3, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 2, null },
                    { 4, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 4, null },
                    { 5, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 1, null },
                    { 6, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 1, null },
                    { 7, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "Apple M2 ( 8-Core CPU / 10-Core GPU )" },
                    { 8, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, null },
                    { 9, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 2, null },
                    { 10, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), 7, null },
                    { 11, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, null },
                    { 12, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "1 x HDMI" },
                    { 13, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "2 x Thunderbolt 3 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.0" },
                    { 15, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, null },
                    { 16, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "macOS" },
                    { 17, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "30.41 x 21.24 x 0.41–1.61 cm" },
                    { 18, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "53 Wh" },
                    { 19, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, "1.3 kg" },
                    { 20, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), null, null },
                    { 1, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 3, null },
                    { 2, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "12 months" },
                    { 3, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 6, null },
                    { 4, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 1, null },
                    { 5, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 6, null },
                    { 6, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 11, null },
                    { 7, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "AMD Ryzen 7 7730U ( 2.0 GHz - 4.5 GHz / 16MB / 8 cores, 16 threads )" },
                    { 8, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "Onboard AMD Radeon Graphics" },
                    { 9, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 3, null },
                    { 10, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), 13, null },
                    { 11, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "1 x HDMI" },
                    { 13, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "Windows 11 Home SL" },
                    { 17, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "1.8 kg" },
                    { 20, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), null, "Adapter, power cord" },
                    { 1, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 2, null },
                    { 2, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "12 months" },
                    { 3, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 4, null },
                    { 4, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 13, null },
                    { 5, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 3, null },
                    { 6, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 4, null },
                    { 7, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "Intel Core i5-11400H ( 2.7 GHz - 4.5 GHz / 12MB / 6 cores, 12 threads )" },
                    { 8, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "RTX 3050 4GB GDDR6 / Intel UHD Graphics" },
                    { 9, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 2, null },
                    { 10, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), 12, null },
                    { 11, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "1 x HDMI" },
                    { 13, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "Windows 11 Home SL" },
                    { 17, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "4 cell 90 Wh , Built-in battery" },
                    { 19, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "2.6 kg" },
                    { 20, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), null, "Adapter, power cord" },
                    { 1, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 1, null },
                    { 2, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "12 months" },
                    { 3, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 2, null },
                    { 4, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 11, null },
                    { 5, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 2, null },
                    { 6, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 1, null },
                    { 7, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "Apple M2 ( 8-Core CPU / 10-Core GPU )" },
                    { 8, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, null },
                    { 9, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 3, null },
                    { 10, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), 7, null },
                    { 11, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, null },
                    { 12, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "1 x HDMI" },
                    { 13, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "2 x Thunderbolt 3 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.0" },
                    { 15, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, null },
                    { 16, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "macOS" },
                    { 17, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "30.41 x 21.5 x 1.13 cm" },
                    { 18, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "53 Wh" },
                    { 19, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, "1.2 kg" },
                    { 20, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), null, null },
                    { 1, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 4, null },
                    { 2, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "12 months" },
                    { 3, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 7, null },
                    { 4, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 12, null },
                    { 5, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 5, null },
                    { 6, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 3, null },
                    { 7, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "Intel Core i3-1215U ( 1.2 GHz - 4.4 GHz / 10MB / 6 cores, 8 threads )" },
                    { 8, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "Onboard Intel UHD Graphics" },
                    { 9, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 2, null },
                    { 10, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), 12, null },
                    { 11, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "1 x HDMI" },
                    { 13, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "Windows 11 Home SL" },
                    { 17, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "1.8 kg" },
                    { 20, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), null, "Adapter, power cord" },
                    { 1, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 1, null },
                    { 2, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "12 months" },
                    { 3, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 1, null },
                    { 4, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 1, null },
                    { 5, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 1, null },
                    { 6, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 1, null },
                    { 7, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "Apple M2 Max ( 12-Core CPU / 64-Core GPU )" },
                    { 8, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, null },
                    { 9, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 6, null },
                    { 10, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), 13, null },
                    { 11, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, null },
                    { 12, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "1 x HDMI" },
                    { 13, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "3 x Thunderbolt 4 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.3" },
                    { 15, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, null },
                    { 16, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "macOS" },
                    { 17, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "1.68 x 35.57 x 24.81 cm" },
                    { 18, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "100 Wh" },
                    { 19, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, "2.1 kg" },
                    { 20, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), null, null },
                    { 1, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 1, null },
                    { 2, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "12 months" },
                    { 3, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 1, null },
                    { 4, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 1, null },
                    { 5, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 5, null },
                    { 6, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 1, null },
                    { 7, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "Apple M2 ( 8-Core CPU / 10-Core GPU )" },
                    { 8, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, null },
                    { 9, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 4, null },
                    { 10, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), 4, null },
                    { 11, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, null },
                    { 12, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "1 x HDMI" },
                    { 13, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "2 x Thunderbolt 3 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.0" },
                    { 15, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, null },
                    { 16, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "macOS" },
                    { 17, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "30.41 x 21.24 x 0.41–1.61 cm" },
                    { 18, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "53 Wh" },
                    { 19, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, "1.3 kg" },
                    { 20, new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), null, null },
                    { 1, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 3, null },
                    { 2, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "12 months" },
                    { 3, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 6, null },
                    { 4, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 1, null },
                    { 5, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 6, null },
                    { 6, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 4, null },
                    { 7, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "Intel Core i5-1335U ( 1.3 GHz – 4.6GHz / 12MB / 10 cores, 12 threads )" },
                    { 8, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "Onboard Intel UHD Graphics" },
                    { 9, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 2, null },
                    { 10, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), 12, null },
                    { 11, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "1 x HDMI" },
                    { 13, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "Windows 11 Home SL" },
                    { 17, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "1.8 kg" },
                    { 20, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), null, "Adapter, power cord" },
                    { 1, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 1, null },
                    { 2, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "12 months" },
                    { 3, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 2, null },
                    { 4, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 4, null },
                    { 5, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 1, null },
                    { 6, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 1, null },
                    { 7, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "Apple M2 ( 8-Core CPU / 10-Core GPU )" },
                    { 8, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, null },
                    { 9, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 2, null },
                    { 10, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), 11, null },
                    { 11, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, null },
                    { 12, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "1 x HDMI" },
                    { 13, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "2 x Thunderbolt 4 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.3" },
                    { 15, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, null },
                    { 16, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "macOS" },
                    { 17, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "1.15 x 34.04 x 23.76 cm" },
                    { 18, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "53 Wh" },
                    { 19, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, "1.5 kg" },
                    { 20, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), null, null },
                    { 1, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 1, null },
                    { 2, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "12 months" },
                    { 3, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 2, null },
                    { 4, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 2, null },
                    { 5, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 6, null },
                    { 6, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 1, null },
                    { 7, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "Apple M1 ( 8-Core CPU / 7-Core GPU )" },
                    { 8, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, null },
                    { 9, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 2, null },
                    { 10, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), 4, null },
                    { 11, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, null },
                    { 12, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "1 x HDMI" },
                    { 13, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "2 x Thunderbolt 3 , 1 x 3.5 mm , 1 x SDXC Card Slot" },
                    { 14, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.0" },
                    { 15, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, null },
                    { 16, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "macOS" },
                    { 17, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "30.41 x 21.24 x 0.41–1.61 cm" },
                    { 18, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "53 Wh" },
                    { 19, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, "1.3 kg" },
                    { 20, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), null, null },
                    { 1, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 2, null },
                    { 2, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "12 months" },
                    { 3, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 5, null },
                    { 4, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 13, null },
                    { 5, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 3, null },
                    { 6, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 10, null },
                    { 7, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "AMD Ryzen 5 7535HS ( 3.3 GHz - 4.5 GHz / 16MB / 6 cores, 12 threads )" },
                    { 8, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "RTX 4050 6GB GDDR6 / AMD Radeon 660M" },
                    { 9, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 2, null },
                    { 10, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), 13, null },
                    { 11, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "1 x HDMI" },
                    { 13, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "Windows 11 Home SL" },
                    { 17, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "4 cell 90 Wh , Built-in battery" },
                    { 19, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "2.6 kg" },
                    { 20, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), null, "Adapter, power cord" },
                    { 1, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 4, null },
                    { 2, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "12 months" },
                    { 3, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 7, null },
                    { 4, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 1, null },
                    { 5, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 1, null },
                    { 6, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 5, null },
                    { 7, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "Intel Core i7-1360P ( 2.2 GHz – 5.0 GHz / 12MB / 12 cores, 16 threads )" },
                    { 8, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "RTX 2050 4GB GDDR6 / Intel Iris Xe Graphics" },
                    { 9, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 3, null },
                    { 10, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), 13, null },
                    { 11, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "1 x HDMI" },
                    { 13, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "Windows 11 Home SL" },
                    { 17, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "1.8 kg" },
                    { 20, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), null, "Adapter, power cord" },
                    { 1, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 4, null },
                    { 2, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "12 months" },
                    { 3, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 7, null },
                    { 4, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 1, null },
                    { 5, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 1, null },
                    { 6, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 4, null },
                    { 7, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "Intel Core i5-1340P ( 1.9 GHz – 4.6 GHz / 12MB / 12 cores, 16 threads )" },
                    { 8, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "Onboard Intel UHD Graphics" },
                    { 9, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 2, null },
                    { 10, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), 12, null },
                    { 11, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "512GB M.2 NVMe SSD" },
                    { 12, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "1 x HDMI" },
                    { 13, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "2 x USB Type C , 2 x USB 3.2 , 1 x USB 2.0 , 1 x micro SD card slot , Audio combo , LAN 1 Gb/s" },
                    { 14, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "WiFi 802.11ax (Wifi 6) , Bluetooth 5.1" },
                    { 15, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "usually, with numeric keypad, RGB 4 zones" },
                    { 16, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "Windows 11 Home SL" },
                    { 17, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "360.1 x 279.9 x 25.9 - 27.9 mm" },
                    { 18, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "2 cell 37 Wh , Built-in battery" },
                    { 19, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "1.8 kg" },
                    { 20, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), null, "Adapter, power cord" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "ProductId" },
                values: new object[,]
                {
                    { "", new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02") },
                    { "https://drive.google.com/uc?export=view&id=1_8nLKemsZNH5ob80loz-Rjk46gIPCyAk", new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0") },
                    { "https://drive.google.com/uc?export=view&id=1_mXukBwuEtyZsG7bR_MDAO-d7PjMhP-w", new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02") },
                    { "https://drive.google.com/uc?export=view&id=13YRnumTXIikNyks6MMGS7IHy2XKsLcUG", new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0") },
                    { "https://drive.google.com/uc?export=view&id=17g-gOr-mKqeRCKmv3aLa7kNBIf8AMza2", new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02") },
                    { "https://drive.google.com/uc?export=view&id=18_VERsQCkR5top5RyAiyXBWoyQTVgYLU", new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0") },
                    { "https://drive.google.com/uc?export=view&id=19JhyKc7SDq8OS-FKWCEE1fHlB9zmlF4_", new Guid("9dcae431-305f-4212-a972-13cfab1906a9") },
                    { "https://drive.google.com/uc?export=view&id=1ANMv2MD1x9POXwFzqbtAFJaSVDsBygR_", new Guid("9dcae431-305f-4212-a972-13cfab1906a9") },
                    { "https://drive.google.com/uc?export=view&id=1AoKIxY1_KpVC--DBDv-5vkL7KRBETaTj", new Guid("9dcae431-305f-4212-a972-13cfab1906a9") },
                    { "https://drive.google.com/uc?export=view&id=1D6w59akVTqabNKBcaDFvZeGh0DHiPZNS", new Guid("9dcae431-305f-4212-a972-13cfab1906a9") },
                    { "https://drive.google.com/uc?export=view&id=1F2Z5C1km_4FvIa70xF0b8bL-OwsK07d6", new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208") },
                    { "https://drive.google.com/uc?export=view&id=1fXgj_qQJMKNQczOx0Kd_0foAVyiYcmb8", new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208") },
                    { "https://drive.google.com/uc?export=view&id=1gCSDRkYeTgsuklm4-ZUVKutTKTu6bsOW", new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0") },
                    { "https://drive.google.com/uc?export=view&id=1hcc5bb9xZwftkpNNLbNSdWO-OaglGEU-", new Guid("d96f4e47-b028-4b55-8fca-74205236a629") },
                    { "https://drive.google.com/uc?export=view&id=1IrnkUeFEoVdNEY-FMf0Y4i33tOEOh1l8", new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208") },
                    { "https://drive.google.com/uc?export=view&id=1jFJ0Dy7LgyF9l-bnF6VeOVpvbqDDXkgz", new Guid("9dcae431-305f-4212-a972-13cfab1906a9") },
                    { "https://drive.google.com/uc?export=view&id=1KAPyG_jY6xo0pp13IhGHq3HosAlc42hB", new Guid("b4477593-f779-4bf9-89d0-023882274f9d") },
                    { "https://drive.google.com/uc?export=view&id=1KGDOpVmwofx2viWcLPSdji5_dVz6IEYK", new Guid("d96f4e47-b028-4b55-8fca-74205236a629") },
                    { "https://drive.google.com/uc?export=view&id=1NB-4hrhVBTP0kRbx9VOMRxMEOIsuT0Dt", new Guid("d96f4e47-b028-4b55-8fca-74205236a629") },
                    { "https://drive.google.com/uc?export=view&id=1oA7zu7vf9vxdDzRUOfTShMTO9TMYB2t1", new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0") },
                    { "https://drive.google.com/uc?export=view&id=1p0Eq0ptA7J3g5mTUP9g131BgLb6XCiyI", new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208") },
                    { "https://drive.google.com/uc?export=view&id=1pmIx4SB6rmApjVB6YIm9rYmsn7C5GNua", new Guid("b4477593-f779-4bf9-89d0-023882274f9d") },
                    { "https://drive.google.com/uc?export=view&id=1pW-V7JEHlpOswTpw68p7GbAV_NV8i62S", new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02") },
                    { "https://drive.google.com/uc?export=view&id=1sf_iHr6KcO6Gl7oucfq46NirqaBERifh", new Guid("b4477593-f779-4bf9-89d0-023882274f9d") },
                    { "https://drive.google.com/uc?export=view&id=1sojVUeqtcf6kDA84Mdj73JcbipmW5HP0", new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02") },
                    { "https://drive.google.com/uc?export=view&id=1vpOJlcWyzrUGceYi-ilCZ4b3ufeMZapS", new Guid("b4477593-f779-4bf9-89d0-023882274f9d") }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "Id", "FromDate", "Price", "ProductId", "ToDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7716), 94690000.0, new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7730) },
                    { 2, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7734), 34790000.0, new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7735) },
                    { 3, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7736), 29990000.0, new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7737) },
                    { 4, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7738), 33290000.0, new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7738) },
                    { 5, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7739), 26590000.0, new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7740) },
                    { 6, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7741), 25990000.0, new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7742) },
                    { 7, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7742), 14990000.0, new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7743) },
                    { 8, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7744), 18990000.0, new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7744) },
                    { 9, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7802), 9490000.0, new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7802) },
                    { 10, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7804), 14990000.0, new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7804) },
                    { 11, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7805), 15690000.0, new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7806) },
                    { 12, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7806), 14390000.0, new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7807) },
                    { 13, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7808), 18590000.0, new Guid("160df69f-314c-4441-9415-3771c02be5ff"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7809) },
                    { 14, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7810), 27990000.0, new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7810) },
                    { 15, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7811), 28690000.0, new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7812) },
                    { 16, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7813), 24890000.0, new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7813) },
                    { 17, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7814), 30290000.0, new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7815) },
                    { 18, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7816), 39490000.0, new Guid("86446b09-6675-4c94-a8c9-44abad169e1f"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7816) },
                    { 19, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7817), 15990000.0, new Guid("ca568ebb-1eb3-4635-b65c-2d1fc2a17e5f"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7818) },
                    { 20, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7820), 29190000.0, new Guid("67a25c7b-6bd8-4c9f-af25-b607a399552e"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7820) },
                    { 21, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7821), 25190000.0, new Guid("4bbb500c-b891-4bc5-ae09-61181631eaed"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7821) },
                    { 22, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7822), 18790000.0, new Guid("e79b3817-a992-4439-b48b-379fc5e8582f"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7823) },
                    { 23, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7824), 2990000.0, new Guid("337e8f9b-fe09-4d5c-ba48-53d2514088ea"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7824) },
                    { 24, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7825), 2490000.0, new Guid("d4958a5d-b450-4f1a-a692-b1f5191c02a5"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7826) },
                    { 25, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7827), 19990000.0, new Guid("c7fac1ba-64b9-40d0-a4fb-31242e76ed68"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7827) },
                    { 26, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7828), 9390000.0, new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7829) },
                    { 27, new DateTime(2023, 11, 24, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7830), 21490000.0, new Guid("25a9275b-b220-4063-8b38-864efb9d08f2"), new DateTime(2023, 12, 4, 8, 43, 17, 185, DateTimeKind.Local).AddTicks(7831) }
                });

            migrationBuilder.InsertData(
                table: "SlugProducts",
                columns: new[] { "ProductId", "SlugId" },
                values: new object[,]
                {
                    { new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), "best-sale" },
                    { new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), "best-sale" },
                    { new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), "best-sale" },
                    { new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), "best-sale" },
                    { new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), "best-sale" },
                    { new Guid("c7fac1ba-64b9-40d0-a4fb-31242e76ed68"), "best-sale" },
                    { new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), "best-sale" },
                    { new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), "best-sale" },
                    { new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), "black-friday" },
                    { new Guid("25a9275b-b220-4063-8b38-864efb9d08f2"), "black-friday" },
                    { new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), "black-friday" },
                    { new Guid("86446b09-6675-4c94-a8c9-44abad169e1f"), "black-friday" },
                    { new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), "black-friday" },
                    { new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), "black-friday" },
                    { new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), "laptop" },
                    { new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), "laptop" },
                    { new Guid("160df69f-314c-4441-9415-3771c02be5ff"), "laptop" },
                    { new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), "laptop" },
                    { new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), "laptop" },
                    { new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), "laptop" },
                    { new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), "laptop" },
                    { new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), "laptop" },
                    { new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), "laptop" },
                    { new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), "laptop" },
                    { new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), "laptop" },
                    { new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), "laptop" },
                    { new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), "laptop" },
                    { new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), "laptop" },
                    { new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), "laptop" },
                    { new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), "laptop" },
                    { new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), "laptop" },
                    { new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), "laptop" },
                    { new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), "laptop-acer" },
                    { new Guid("85004628-55ed-4a78-ba10-0c49b41356e6"), "laptop-acer" },
                    { new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), "laptop-acer" },
                    { new Guid("73cd2063-5109-43dd-bc5b-7bdae33dfd02"), "laptop-apple-macbook" },
                    { new Guid("9dcae431-305f-4212-a972-13cfab1906a9"), "laptop-apple-macbook" },
                    { new Guid("a92a3cee-ba1b-405a-8dac-0fc1917d6208"), "laptop-apple-macbook" },
                    { new Guid("b4477593-f779-4bf9-89d0-023882274f9d"), "laptop-apple-macbook" },
                    { new Guid("d96f4e47-b028-4b55-8fca-74205236a629"), "laptop-apple-macbook" },
                    { new Guid("e75caffa-485b-448a-b863-3ccfcf6452b0"), "laptop-apple-macbook" },
                    { new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), "laptop-asus" },
                    { new Guid("7b7fabf2-052d-4e8b-befd-49006319faf2"), "laptop-asus" },
                    { new Guid("ceb1df46-fdaf-406d-9628-7592b9da7836"), "laptop-asus" },
                    { new Guid("08f432cd-e299-4689-a8b3-826aa3285579"), "laptop-dell" },
                    { new Guid("160df69f-314c-4441-9415-3771c02be5ff"), "laptop-dell" },
                    { new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), "laptop-dell" },
                    { new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), "laptop-dell" },
                    { new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), "laptop-dell" },
                    { new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), "laptop-dell" },
                    { new Guid("0b0d7a34-bbcf-4cf7-b6be-bedf4808c457"), "sale-laptop" },
                    { new Guid("160df69f-314c-4441-9415-3771c02be5ff"), "sale-laptop" },
                    { new Guid("1b6cbceb-fec4-45e9-a3cd-d3626002cfb7"), "sale-laptop" },
                    { new Guid("3bf9f598-4daf-41e8-ab8e-724a0ab58b8f"), "sale-laptop" },
                    { new Guid("a337e899-f8b1-445c-ba80-04ba9ccbe0cc"), "sale-laptop" },
                    { new Guid("e973bf90-1373-4240-81b2-8d6d1a1a8541"), "sale-laptop" },
                    { new Guid("eb62096e-adba-45b1-9fe6-7b575f445020"), "sale-laptop" },
                    { new Guid("f6cb2f2e-1293-4738-8cfd-f836cd2e68e7"), "sale-laptop" },
                    { new Guid("337e8f9b-fe09-4d5c-ba48-53d2514088ea"), "smartphone" },
                    { new Guid("4bbb500c-b891-4bc5-ae09-61181631eaed"), "smartphone" },
                    { new Guid("67a25c7b-6bd8-4c9f-af25-b607a399552e"), "smartphone" },
                    { new Guid("78e9f709-ee91-4f58-82e7-50edf62fd3bf"), "smartphone" },
                    { new Guid("86446b09-6675-4c94-a8c9-44abad169e1f"), "smartphone" },
                    { new Guid("ca568ebb-1eb3-4635-b65c-2d1fc2a17e5f"), "smartphone" },
                    { new Guid("d4958a5d-b450-4f1a-a692-b1f5191c02a5"), "smartphone" },
                    { new Guid("e79b3817-a992-4439-b48b-379fc5e8582f"), "smartphone" },
                    { new Guid("4bbb500c-b891-4bc5-ae09-61181631eaed"), "smartphone-iphone" },
                    { new Guid("67a25c7b-6bd8-4c9f-af25-b607a399552e"), "smartphone-iphone" },
                    { new Guid("78e9f709-ee91-4f58-82e7-50edf62fd3bf"), "smartphone-iphone" },
                    { new Guid("86446b09-6675-4c94-a8c9-44abad169e1f"), "smartphone-iphone" },
                    { new Guid("ca568ebb-1eb3-4635-b65c-2d1fc2a17e5f"), "smartphone-iphone" },
                    { new Guid("e79b3817-a992-4439-b48b-379fc5e8582f"), "smartphone-iphone" },
                    { new Guid("337e8f9b-fe09-4d5c-ba48-53d2514088ea"), "smartphone-samsung" },
                    { new Guid("d4958a5d-b450-4f1a-a692-b1f5191c02a5"), "smartphone-xiaomi" },
                    { new Guid("25a9275b-b220-4063-8b38-864efb9d08f2"), "smartwatch" },
                    { new Guid("25a9275b-b220-4063-8b38-864efb9d08f2"), "smartwatch-apple" },
                    { new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), "tablet" },
                    { new Guid("c7fac1ba-64b9-40d0-a4fb-31242e76ed68"), "tablet" },
                    { new Guid("c7fac1ba-64b9-40d0-a4fb-31242e76ed68"), "tablet-ipad" },
                    { new Guid("95eaffe2-60aa-4f38-ad0b-fb369ea94131"), "tablet-samsung" }
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
