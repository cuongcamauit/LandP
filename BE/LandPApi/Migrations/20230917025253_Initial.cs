﻿using System;
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
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<int>(type: "int", nullable: false),
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
                name: "AttributeSpecs",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeSpecs", x => new { x.ProductId, x.AttributeId });
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
                    { "04be0c35-571e-425c-992e-15a7227286de", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a76acc98-1c60-4965-92cc-ac1ae630e96e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com", true, false, null, "User", "landpuserdemo@gmail.com", null, "AQAAAAEAACcQAAAAEC7iO7yYSsARJgnXjJMdwqqAETaxznRY7g2F3cyZ7APd2BwOPs8GUcTnKLyFMrz55g==", null, false, "4b0afa7f-cabe-4314-8469-acaef4bf9a07", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo@gmail.com" },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7685e18c-bb31-49c3-84ed-283e093dafd0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com", true, false, null, "User1", "landpuserdemo1@gmail.com", null, "AQAAAAEAACcQAAAAEHZl1Lf59LfOWnl61xYAxGeayMSmYYFaZaCHL/oaUOuN6OMILVn1qRm0j/jXOoozig==", null, false, "7d3bce8d-abb9-46b7-8ad6-2b702e1181f3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpuserdemo1@gmail.com" },
                    { "289f6c6a783e4d89b25c847d1ffa4833", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "090271d1-df29-45fb-99fa-1e31b52dcd60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com", true, false, null, "Super Admin", "landpsupadmika@gmail.com", null, "AQAAAAEAACcQAAAAEFbvfbhZpRUeo8SI3SNnWrXOxqgiKHXkEQApjW57kcyHlEr+V6tSVcS6HVhwdnhdaw==", null, false, "c99d2257-2122-49bc-acb0-7c1d94efa8d8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpsupadmika@gmail.com" },
                    { "43bd8d30-85af-4960-8a9f-d7f7eeeb8571", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "472216b4-8021-49e8-b1ff-32dc4701f0ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com", true, false, null, "Admin", "landpadmika@gmail.com", null, "AQAAAAEAACcQAAAAEF0sYEkShYdIfvyB2c9h6wTWCC80l7swpIJhYynPn6B2NmrK+H0DlKTMTE7STdHmxg==", null, false, "b9a0bec7-88d0-44c7-9714-5505b2c1a493", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "landpadmika@gmail.com" }
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
                columns: new[] { "Id", "CustomerId", "Detail", "District", "DistrictId", "Province", "ProvinceId", "Ward", "WardId" },
                values: new object[,]
                {
                    { new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", "5", "Thành phố Cà Mau", 0, "Cà Mau", 0, "8", 0 },
                    { new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", "Tô Ký", "12", 0, "Thành phố Hồ Chí Minh", 0, "Tân Chánh Hiệp", 0 }
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
                    { new Guid("0dc89c59-833c-4493-ba06-dd080f63bb11"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau khi trình làng hàng loạt mẫu iPhone vào tháng 09/2022 thì Apple cũng đã tiếp tục giới thiệu series iPad mới cho năm 2022. Trong đó iPad 10 WiFi 64GB là cái tên được hãng chú trọng khá nhiều về việc tối ưu giá thành nhằm giúp người dùng có thể dễ dàng tiếp cận. Máy hỗ trợ hệ điều hành iPadOS 16 cùng con chip Apple A14 Bionic giúp mang lại hiệu năng vượt trội.", "18kx0xh8gVJAJllf-4ZVeFZFfkJHI1zkX", "https://drive.google.com/uc?export=view&id=1PjgSj70e2Oc1GC-DJBiVkzs77mAdEokF", false, "iPad 10", 11190000.0, 10, "Unit" },
                    { new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi Redmi Note 12 Pro 5G là mẫu điện thoại thuộc dòng Redmi Note được chính thức ra mắt trong năm 2023, máy mang trên mình những cải tiến vượt trội về thiết kế, camera và hiệu năng, đáp ứng mượt mà hầu hết các nhu cầu khác nhau của người dùng.", "1gBdpMXybH0HOxSKI6g9AdmisL9IUMfPq", "https://drive.google.com/uc?export=view&id=190zjmRvUnsTZdB4iDizNBjqKI_fk5L3a", false, "Xiaomi Redmi Note 12 Pro 5G", 9960000.0, 50, "Unit" },
                    { new Guid("16713a23-cf80-45a9-b34d-8a89e487cf1c"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("1ea31e09-ed8c-4ee6-9327-cfe43694a5f5"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n2 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A14 Bionic\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n2815 mAh20 W", "1b9JWfgUruHr6j3U3XalWbAD2UO329_6X", "https://drive.google.com/uc?export=view&id=1yAleLMwDTEfXJNZF_eM8s4vkU8TFm9By", false, "Iphone 12", 15590000.0, 50, "Unit" },
                    { new Guid("3e9d9046-0534-44cf-a0fa-746a31acad9f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2"), "Sau thành công của iPad 8, Apple cho đã cho ra mắt máy tính bảng iPad 9 WiFi 64GB - phiên bản tiếp theo của dòng iPad 10.2 inch, về cơ bản nó kế thừa những điểm mạnh từ các phiên bản trước đó và được cải tiến thêm hiệu suất, trải nghiệm người dùng nhằm giúp nhu cầu sử dụng giải trí và làm việc tiện lợi, linh hoạt hơn", "1SZ3o96HmpNycsXIeOzuXBDF3dgh6v85o", "https://drive.google.com/uc?export=view&id=1IK5bpXd3iGWJbMDOS5c_zG5Zk5th3hhl", false, "iPad 9", 7990000.0, 10, "Unit" },
                    { new Guid("49deec94-1759-41b9-b2f1-bffc9a3a604c"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("592541ec-29d6-4a0b-b18e-8b6eeb64cf90"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("5cfb178c-9c9d-418e-8304-27e38b727082"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("5d7784a8-25d1-43e2-9f71-b4a83b16c51f"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("5d7beeaf-f51e-44bb-ae26-aadb1bdc0276"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nếu bạn đang tìm kiếm một chiếc laptop gaming nhưng vẫn sở hữu một mức giá phải chăng thì laptop Asus TUF Gaming F15 FX506LHB i5 (HN188W) sẽ là sự lựa chọn đáng cân nhắc với card đồ họa rời NVIDIA GeForce GTX mạnh mẽ cùng phong cách thiết kế cứng cáp, độc đáo. ", "1504cqv26tU1E4JAWix9Ajxwh3XCH8tOv", "https://drive.google.com/uc?export=view&id=1s_UzQewLQ4zb7cX25cwUYAlVa3CpuCP9", false, "TUF Gaming F15", 16990000.0, 50, "Unit" },
                    { new Guid("61a1dce1-164c-4a2f-a6e1-6397c5033bfb"), new Guid("fc1a0ff3-92d8-4a16-adb5-8c901bbe48f2"), new Guid("76f4c144-6e3f-44bf-a292-8dd21a461b5d"), "Chuột Không dây Bluetooth Silent Logitech Signature M650 sở hữu kiểu dáng công thái học cùng độ phân giải lớn, đáp ứng tốt gần như mọi nhu cầu từ sử dụng cơ bản tới những tác vụ chuyên nghiệp của người dùng.", "1M0-dUHbo7g_pkLPbQu9NMTPc9tnGkwr7", "https://drive.google.com/uc?export=view&id=1ukyWOlXUIJzxVzjmNN5hPlrnHN0yET7b", false, "Bluetooth Silent Logitech Signature M650", 765000.0, 10, "Unit" },
                    { new Guid("684d2e36-764f-4db0-ba9b-f3f320fe8c8b"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("71958b1f-de92-4e11-a27b-95149787e0cb"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("777ffbe5-1f43-4b6c-80d3-6b3cffbcb721"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Sau thành công của dòng Galaxy Watch4, tháng 8/2022 ông lớn công nghệ Samsung đã cho ra mắt thế hệ smartwatch tiếp theo của hãng mang tên Samsung Galaxy Watch5 40 mm.", "1v5XPVE3A_7XnX4yUf8OekLE54mHXr_CZ", "https://drive.google.com/uc?export=view&id=17uBw10YiFMD2ET9pw_wiXkznPsQrAhr0", false, "Samsung Galaxy Watch5", 5490000.0, 10, "Unit" },
                    { new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new Guid("2d750aa2-ea06-47ea-916c-abb6661f9781"), new Guid("3649b208-05c6-4129-86bd-df77801d3d39"), "Đồng hồ thông minh Suunto 7 Dây silicone phiên bản màu đen trang bị mặt kính cường lực chống va đập, màn hình AMOLED 1.97 inch (454 x 454 pixels) cùng độ sáng lên tới 1000 nits, vì thế có thể hiển thị sắc nét ngay cả khi ở điều kiện có ánh sáng mặt trời. Đặc biệt, với thiết kế dây đeo silicone tạo cảm giác mềm mại và dễ chịu khi đeo trong thời gian dài.", "15B4NY2lAFY9DXr1Z40hwoQNjI5ZjnpZ4", "https://drive.google.com/uc?export=view&id=1-nQviihO_G_HGipaWd72aRUURK4zkm6S", false, "Suunto 7", 7250000.0, 5, "Unit" },
                    { new Guid("7dfa6373-fc86-4be7-aa8b-2d646a58faba"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("84a52395-2fbc-4a7d-b9aa-16ad074fc25d"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("9a16f43f-6cd9-446c-bafa-e3ffd9605c1a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("a1c274df-61ec-482f-815c-84710ad6302e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("b3bc26e8-5559-4cb8-bb55-27c06d99da60"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("c05fe18e-ffad-4052-b125-364b676a23e2"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new Guid("32a244dc-528a-402a-b8e0-d86b31f0b8cb"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Xiaomi 12T series đã ra mắt trong sự kiện của Xiaomi vào ngày 4/10, trong đó có Xiaomi 12T 5G 128GB - máy sở hữu nhiều công nghệ hàng đầu trong giới smartphone tiêu biểu như: Chipset mạnh mẽ đến từ MediaTek, camera 108 MP sắc nét cùng khả năng sạc 120 W siêu nhanh.", "1RvQvCVJ2wk72oMqDuYfeuTBHSIHNhplS", "https://drive.google.com/uc?export=view&id=165CbvBDjo8PPjxn2MPHVe2YrZPZ1oCwd", false, "Xiaomi 12T 5G 128GB", 9890000.0, 3, "Unit" },
                    { new Guid("cc438279-65a4-46c0-ac7f-0e3ddc496998"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new Guid("2ef43281-9c42-466e-ad66-483ff6f46326"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Màn hình:\r\n\r\nPLS TFT LCD6.6\"Full HD+\r\nHệ điều hành:\r\n\r\nAndroid 12\r\nCamera sau:\r\n\r\nChính 50 MP & Phụ 5 MP, 2 MP, 2 MP\r\nCamera trước:\r\n\r\n8 MP\r\nChip:\r\n\r\nSnapdragon 680\r\nRAM:\r\n\r\n4 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n2 Nano SIMHỗ trợ 4G\r\nPin, Sạc:\r\n\r\n5000 mAh25 W", "12oUrvgsYTJhM4WkmXuWd1f8NmbvOe9Gn", "https://drive.google.com/uc?export=view&id=1k0K8y37j9HLnI8C7qYy92mjOzgnY4kSL", false, "Samsung Galaxy A23", 4990000.0, 100, "Unit" },
                    { new Guid("d5682976-7d8c-4549-884c-e85f73ddbed3"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Vostro 3510 i5 (P112F002BBL) sở hữu cấu hình mạnh mẽ, đa nhiệm mượt mà trên sức mạnh của bộ vi xử lý Intel thế hệ 11, cùng một thiết kế đơn giản mà sang đẹp, sẽ là lựa chọn đắt giá đáp ứng nhu cầu học tập, làm việc hay giải trí của bạn.", "1R9qzBw6zNwBARHF8aGu2_qJYlil161yl", "https://drive.google.com/uc?export=view&id=1ELd9fd2dk2meSyxz-hVnsIp8_gFrnHxp", false, "Dell Vostro 3510", 17990000.0, 10, "Unit" },
                    { new Guid("dae66463-647c-45b2-9a29-8e212d60b20a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("e8a24205-db82-4325-b7da-62c52b4f648d"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("fef3acae-7188-49d0-a00b-aaa8aa967577"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" }
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
                    { new Guid("3d723f96-5664-43fa-ae12-ee29b31cbd29"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2035), "Delivered", 7250000.0 },
                    { new Guid("51a73710-71ce-40b5-87ab-1ca7f8f713b9"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2032), "Delivered", 7250000.0 },
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2027), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2028), "Delivered", 58364800.0 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2025), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2026), "Delivered", 56154400.0 },
                    { new Guid("70c67ef5-fd8d-48dc-bd75-f634b3fe6d3c"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2040), "Delivered", 7250000.0 },
                    { new Guid("86609ee8-8a73-43aa-a6ce-f520cc3d0c08"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2037), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2038), "Delivered", 7250000.0 },
                    { new Guid("b836e848-9e83-48ff-af12-9eff988bfd4b"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2029), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2029), "Delivered", 7250000.0 },
                    { new Guid("bd96e1bb-a303-4117-b03b-2fa5d20e9ef8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2031), "Delivered", 7250000.0 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2021), "Delivered", 67640200.0 },
                    { new Guid("ce8a2bc5-3d94-4c20-8275-d309439c743d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2036), "Delivered", 7250000.0 },
                    { new Guid("f8cfebdc-33ab-40e4-8b38-cdaa1df4fec7"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2041), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Views",
                columns: new[] { "CustomerId", "ProductId", "Date", "Quantity" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1920), 1 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1904), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1976), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1977), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1921), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(1978), 1 }
                });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("688aa620-3bf7-464f-b7c3-0ff942a5ab94"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2103), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("6fa53916-795d-4836-ab4d-80ef69dd3541"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2098), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("88a1d60b-86a4-4c4c-8f1a-646209b5cdf0"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2116), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("9654ec37-9119-406a-bdf5-3c518c3ab03d"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2115), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("9e0ce468-7439-42ed-94b5-f44bd7c6a36f"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2108), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("a4a5ac60-90cc-49a4-934c-f5cacfc8cdc0"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2101), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("ccc74b65-5b00-4e3d-b1aa-2aece1fa37d3"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2104), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("eedbf585-abbc-4bbb-bbb4-6874b1d1d320"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2119), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("f21cc47d-610e-43ed-94e1-9c2e2d07c272"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2122), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("f57ac89b-5815-4dd6-a397-04365d645e7a"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2110), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("f9bc245c-33e9-417f-bb73-9b9802eb622f"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2121), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("fe6c71f1-e82b-4d2d-a6b7-da81bce1dfad"), new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2117), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("3d723f96-5664-43fa-ae12-ee29b31cbd29"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("51a73710-71ce-40b5-87ab-1ca7f8f713b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 4 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 2 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 15590000.0, 1 },
                    { new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 3 },
                    { new Guid("70c67ef5-fd8d-48dc-bd75-f634b3fe6d3c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("86609ee8-8a73-43aa-a6ce-f520cc3d0c08"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b836e848-9e83-48ff-af12-9eff988bfd4b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("bd96e1bb-a303-4117-b03b-2fa5d20e9ef8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), 11190000.0, 1 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), 15590000.0, 2 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 3 },
                    { new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), 4990000.0, 2 },
                    { new Guid("ce8a2bc5-3d94-4c20-8275-d309439c743d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f8cfebdc-33ab-40e4-8b38-cdaa1df4fec7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2152), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"), "More than expected!", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2149), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2153), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"), "Ok", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2151), 4 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2152), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("70c67ef5-fd8d-48dc-bd75-f634b3fe6d3c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2161), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2150), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("f8cfebdc-33ab-40e4-8b38-cdaa1df4fec7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2162), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), "Good", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2146), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("3d723f96-5664-43fa-ae12-ee29b31cbd29"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2158), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("51a73710-71ce-40b5-87ab-1ca7f8f713b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2157), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ổn trong tầm giá", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2154), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("86609ee8-8a73-43aa-a6ce-f520cc3d0c08"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2160), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b836e848-9e83-48ff-af12-9eff988bfd4b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2155), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("bd96e1bb-a303-4117-b03b-2fa5d20e9ef8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2156), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("ce8a2bc5-3d94-4c20-8275-d309439c743d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 9, 17, 9, 52, 53, 256, DateTimeKind.Local).AddTicks(2159), 5 }
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
                name: "IX_AttributeSpecs_AttributeId",
                table: "AttributeSpecs",
                column: "AttributeId");

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
                name: "Views");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Attributes");

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