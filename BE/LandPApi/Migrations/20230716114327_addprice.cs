using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("120ed597-e345-47eb-b3e9-2c051435ddce"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4b9523d3-4047-45ac-b504-4d5b138936b1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("55def3f3-4c02-4daf-8a53-1f30abe9264c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7bde1789-c3a5-439c-aae2-21d7d5811728"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8420c23f-d155-494a-b494-adc91e9451ad"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b405de6f-9499-4612-921c-35120aecd542"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c063c62f-d880-4ce8-8995-63671c7da4cf"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c532fa3c-fc68-4660-aa8e-fb01874674b6"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d264e688-0bf0-4056-8649-426395259c9f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ecc597f5-0a35-4a6b-b98a-5c1b4e273af6"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ed1f3449-046b-4e4e-9d0f-b0c09485fa59"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef5bfb48-3836-4b12-90f9-e8f6882791a3"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("1c181d41-41aa-4644-add1-00d824630303"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06372b83-bc61-4c2f-aeef-86963bce17de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09555795-7f6f-4a58-bcda-b36788ebdb0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09a4988d-8bd5-4251-805d-b15975a08523"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e6d6d7b-a387-4694-b938-e641e25102a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33adfa82-b8ab-448a-b605-390765204217"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("378d9467-bdac-47aa-9d98-a71c6a42032f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("460b59f7-24b8-4c75-b79b-38fa07094c70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4947ce92-52c7-4c4b-baf2-71280976dcfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f2d34a8-4d20-4666-aaed-0964c3b5d0b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a81cdac-a9f0-4a95-b990-718970caf802"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d9e296c-56f6-485e-bd33-e560855f8ab5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8be61b16-5528-4222-a8ef-e34bd2807007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd629c5-4985-40aa-9407-1f4ba93d2cfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbb78299-6a9c-4855-a7a9-49b08e44f293"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf65a752-e27f-4b16-8339-3a889a1e498f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cab27e1f-ecf9-452b-abaa-a9de956c6e07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddfc4769-d54e-4c1f-8bc8-9c13a657c5e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de6142d6-1411-461e-b498-315d8b355a0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcaa7b19-f351-44f2-aae1-71a24691ed91"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1c181d41-41aa-4644-add1-00d824630303"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1c181d41-41aa-4644-add1-00d824630303"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => new { x.ProductId, x.FromDate });
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed873f15-09ea-4e91-9173-751e8b02f35f", "AQAAAAEAACcQAAAAEEs9nB7iIMxrmnu6g4ZhUZTBgvJTJIs4+Bj4Df6W0hJkXxZsaRh8urzfcGO8zRvA7g==", "a97281ee-fe5e-46ec-8856-8a8e4c822afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3aaf33a-4042-4b05-9da0-239b2a98e626", "AQAAAAEAACcQAAAAEI4j1LRz3WBc3SNNu1/F5zeKZ8B8QXkvZGfyFf9KN5UwKh9OT/wQ+iwpt7/uyDAUGw==", "6a123299-646b-4bba-a663-ac5666133128" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "405d34c2-b2e7-4c63-b705-95c135a28329", "AQAAAAEAACcQAAAAEMAdBb0/nVUgD7mtkuQeHQnsRDY/b63+sE6lMuyZUJKMoQQ6OaZc/lgJQZAULhf59g==", "69eaff30-43d5-4341-bea8-556eaf0f809a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46398522-d6b3-450a-b179-2036f4d2ceea", "AQAAAAEAACcQAAAAEMOcVm+5RI7ax02tc3j9eHPos6eZyQCIXWYQOAEBaEVUZL0TPqMJayH6L89IpTBwTw==", "0a34ab4b-973e-458c-beb7-8d1319df4b95" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("15c61fe5-891b-46cb-9645-5fb1dd926ae3"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(533), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("1d0c4eae-13b1-4fff-8bb0-84196aad217a"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(543), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("1d0f8e32-00bf-4bea-9852-308ea1b874da"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(520), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("31eae502-651e-4109-a162-2965842887a1"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(531), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("380cda58-eccf-4d91-ae2f-857ce0f35f21"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(541), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("7f126aa8-f64e-4577-bfa8-c89affc7cafa"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(538), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("9fdf28c5-34db-4902-a3eb-88ca3316dbdb"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(530), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("c16b2f35-b2f8-46f1-9c7f-19d324ab83c3"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(528), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("d422a794-f161-4cd2-a37b-c9b7a6a32a5e"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(535), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("d99a22c3-4d97-4e90-a5fe-e2deb516cbc7"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(536), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("de4d5cb7-986f-459f-ac1f-0439638f07bd"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(522), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("e0ab456e-ad15-43d3-8359-b3c3c936393d"), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(527), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(456), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(457), "Delivered", 7250000.0 },
                    { new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(470), "Delivered", 7250000.0 },
                    { new Guid("448461b7-685f-404a-970d-b510399597d6"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(467), "Delivered", 7250000.0 },
                    { new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(461), "Delivered", 7250000.0 },
                    { new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(469), "Delivered", 7250000.0 },
                    { new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(471), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(471), "Delivered", 7250000.0 },
                    { new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(460), "Delivered", 7250000.0 },
                    { new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(458), "Delivered", 7250000.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e9d9046-0534-44cf-a0fa-746a31acad9f"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d7beeaf-f51e-44bb-ae26-aadb1bdc0276"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61a1dce1-164c-4a2f-a6e1-6397c5033bfb"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("777ffbe5-1f43-4b6c-80d3-6b3cffbcb721"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"),
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5682976-7d8c-4549-884c-e85f73ddbed3"),
                column: "isDeleted",
                value: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "Name", "Price", "Quantity", "Unit", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("174c4a98-b5f5-4809-90cb-0c4939701dd2"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", " iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit", false },
                    { new Guid("1a552b4d-c299-429d-bb4f-5296fca3e719"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit", false },
                    { new Guid("1c0aa1a5-2fed-477b-a419-dd1266843293"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", " iPhone 13 ", 17000000.0, 25, "Unit", false },
                    { new Guid("1c6c82eb-55c0-4793-b245-61036ef5113b"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", " iPhone 14 ", 19990000.0, 10, "Unit", false },
                    { new Guid("1cea1259-fdcd-4b39-8b9b-d189fa719f90"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit", false },
                    { new Guid("3423625a-bfa7-47f8-af6c-5a5b9a9858e0"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit", false },
                    { new Guid("37728e12-0994-4989-8af3-abb63bc5d633"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit", false },
                    { new Guid("4790e9f4-b757-45e5-b25f-3b02fd24ef36"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", " Dell Inspiron 16 5620", 21990000.0, 20, "Unit", false },
                    { new Guid("4d798c35-f948-4f46-bc59-efef5ec8432b"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit", false },
                    { new Guid("55f5fdd0-a140-4725-84b7-02cc9bf617de"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", " iPhone 14 Pro", 24990000.0, 10, "Unit", false },
                    { new Guid("605c2b62-fa89-458f-8743-7e8d6ce68f34"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit", false },
                    { new Guid("7b0556e9-c31f-45cb-b5ce-91c29ab428e0"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit", false },
                    { new Guid("8170eb78-3b4c-40b0-b64e-e881ece3f59d"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit", false },
                    { new Guid("91ec5a1f-d29c-4389-8d2d-5e4eb7af95b7"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", "  iPhone 14 Pro Max", 27990000.0, 20, "Unit", false },
                    { new Guid("aeaa4083-4c91-40c0-a095-57ad3306bfcf"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", " Dell Inspiron 15 5515", 17990000.0, 10, "Unit", false },
                    { new Guid("e1900807-2564-42b8-a4de-eee17cb6c8f6"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit", false },
                    { new Guid("e29e165f-7e0b-46c8-b3d8-80f1403510a4"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", " Dell Inspiron 15 3520", 16990000.0, 30, "Unit", false },
                    { new Guid("ed39b558-6926-4edc-9c2e-2c5ce1800761"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit", false },
                    { new Guid("eed7f851-f01a-4a76-b047-e21928d7bf3b"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", "  iPhone 14 Plus", 21890000.0, 15, "Unit", false }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("448461b7-685f-404a-970d-b510399597d6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(635), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(636), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(630), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("448461b7-685f-404a-970d-b510399597d6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(633), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(632), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(634), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(631), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 7, 16, 18, 43, 27, 100, DateTimeKind.Local).AddTicks(631), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("15c61fe5-891b-46cb-9645-5fb1dd926ae3"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1d0c4eae-13b1-4fff-8bb0-84196aad217a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1d0f8e32-00bf-4bea-9852-308ea1b874da"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("31eae502-651e-4109-a162-2965842887a1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("380cda58-eccf-4d91-ae2f-857ce0f35f21"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7f126aa8-f64e-4577-bfa8-c89affc7cafa"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9fdf28c5-34db-4902-a3eb-88ca3316dbdb"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c16b2f35-b2f8-46f1-9c7f-19d324ab83c3"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d422a794-f161-4cd2-a37b-c9b7a6a32a5e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d99a22c3-4d97-4e90-a5fe-e2deb516cbc7"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("de4d5cb7-986f-459f-ac1f-0439638f07bd"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e0ab456e-ad15-43d3-8359-b3c3c936393d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("448461b7-685f-404a-970d-b510399597d6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("174c4a98-b5f5-4809-90cb-0c4939701dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a552b4d-c299-429d-bb4f-5296fca3e719"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c0aa1a5-2fed-477b-a419-dd1266843293"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c6c82eb-55c0-4793-b245-61036ef5113b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cea1259-fdcd-4b39-8b9b-d189fa719f90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3423625a-bfa7-47f8-af6c-5a5b9a9858e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37728e12-0994-4989-8af3-abb63bc5d633"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4790e9f4-b757-45e5-b25f-3b02fd24ef36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d798c35-f948-4f46-bc59-efef5ec8432b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55f5fdd0-a140-4725-84b7-02cc9bf617de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("605c2b62-fa89-458f-8743-7e8d6ce68f34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b0556e9-c31f-45cb-b5ce-91c29ab428e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8170eb78-3b4c-40b0-b64e-e881ece3f59d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91ec5a1f-d29c-4389-8d2d-5e4eb7af95b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeaa4083-4c91-40c0-a095-57ad3306bfcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1900807-2564-42b8-a4de-eee17cb6c8f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e29e165f-7e0b-46c8-b3d8-80f1403510a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed39b558-6926-4edc-9c2e-2c5ce1800761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eed7f851-f01a-4a76-b047-e21928d7bf3b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("448461b7-685f-404a-970d-b510399597d6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3694efa2-818a-4fe4-9196-80b97c741a25"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3bdfe616-bfe4-4a7c-9aa7-7211022668bb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("448461b7-685f-404a-970d-b510399597d6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7f8e4bad-6b8e-4e5c-9fa7-12cd25502ec6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a324c24e-e0d0-4f0f-b81a-f7e21dafb5dc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a92b4096-3626-461b-9dd3-fc520dc46722"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d6d1f5cc-1f8c-47b1-bbbf-45827a05f8d4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f3828a60-6253-434a-a7aa-f4d5a3cec8f1"));

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89e75315-e8d2-4757-a28d-23b2222badc0", "AQAAAAEAACcQAAAAEEjAoeFP5/hmTop1BwBXiCx5jFwqZgcYS2HPA5LrULMUP+uaLA28UDD1FcPhHlL/eA==", "559046c6-f322-4777-8866-88e6fce6bb04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b2c3dc7-ca72-4ebe-a727-705a10b881b4", "AQAAAAEAACcQAAAAEKBdxqyokbS/rFQsieBXAFvju1va2K1Ds06Ypw5ZvCzqZ7qLwf8fk1C5cOVSHhjpkQ==", "08f480ce-226b-4768-926a-e114d07c1621" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fae7d04-9aed-4494-9c78-335d43246a91", "AQAAAAEAACcQAAAAEBCoeoOzRAWy3ZXURL6CLYNn+x++hHVtGCn053YlGeecXU52Hb+ogM9iMCPEyxXZ1w==", "53962ea6-406c-40e5-9e40-838c6b26433b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33881177-d46a-44a2-a862-17ea7c8f9fe0", "AQAAAAEAACcQAAAAEAPr8qnaws7/wkXY5Zau6Ox+a0VH59xBVeKZDmgB6DoTBub40aVXJ2VXx7H4UoiuTg==", "9ec42a10-c317-47f6-9b0a-dc9855bf0fa6" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("120ed597-e345-47eb-b3e9-2c051435ddce"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6488), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("4b9523d3-4047-45ac-b504-4d5b138936b1"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6496), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("55def3f3-4c02-4daf-8a53-1f30abe9264c"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6498), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("7bde1789-c3a5-439c-aae2-21d7d5811728"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6502), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("8420c23f-d155-494a-b494-adc91e9451ad"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6495), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("b405de6f-9499-4612-921c-35120aecd542"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6494), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("c063c62f-d880-4ce8-8995-63671c7da4cf"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6501), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("c532fa3c-fc68-4660-aa8e-fb01874674b6"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6486), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("d264e688-0bf0-4056-8649-426395259c9f"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6489), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("ecc597f5-0a35-4a6b-b98a-5c1b4e273af6"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6471), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("ed1f3449-046b-4e4e-9d0f-b0c09485fa59"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6499), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("ef5bfb48-3836-4b12-90f9-e8f6882791a3"), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6463), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6366), "Delivered", 7250000.0 },
                    { new Guid("1c181d41-41aa-4644-add1-00d824630303"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6357), "Delivered", 7250000.0 },
                    { new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6379), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6381), "Delivered", 7250000.0 },
                    { new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6369), "Delivered", 7250000.0 },
                    { new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6359), "Delivered", 7250000.0 },
                    { new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6365), "Delivered", 7250000.0 },
                    { new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6362), "Delivered", 7250000.0 },
                    { new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6367), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("06372b83-bc61-4c2f-aeef-86963bce17de"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("09555795-7f6f-4a58-bcda-b36788ebdb0b"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", "  iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("09a4988d-8bd5-4251-805d-b15975a08523"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("1e6d6d7b-a387-4694-b938-e641e25102a1"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", " iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("33adfa82-b8ab-448a-b605-390765204217"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", "  iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("378d9467-bdac-47aa-9d98-a71c6a42032f"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("460b59f7-24b8-4c75-b79b-38fa07094c70"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("4947ce92-52c7-4c4b-baf2-71280976dcfb"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", " iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("4f2d34a8-4d20-4666-aaed-0964c3b5d0b8"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("5a81cdac-a9f0-4a95-b990-718970caf802"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", " Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("7d9e296c-56f6-485e-bd33-e560855f8ab5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("8be61b16-5528-4222-a8ef-e34bd2807007"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("9fd629c5-4985-40aa-9407-1f4ba93d2cfd"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", " Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("bbb78299-6a9c-4855-a7a9-49b08e44f293"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("bf65a752-e27f-4b16-8339-3a889a1e498f"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", " Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("cab27e1f-ecf9-452b-abaa-a9de956c6e07"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("ddfc4769-d54e-4c1f-8bc8-9c13a657c5e9"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", " iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("de6142d6-1411-461e-b498-315d8b355a0e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", " iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("fcaa7b19-f351-44f2-aae1-71a24691ed91"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("1c181d41-41aa-4644-add1-00d824630303"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("518ad1c5-8317-469f-af83-c5f3e524214c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6603), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("5ac06ad1-dbfa-4a62-96e7-47a774441c8a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6603), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("078746ca-2441-41fd-bd81-9bdb6488ecf8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6601), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1c181d41-41aa-4644-add1-00d824630303"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6597), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5ec424b4-9ddf-482f-ac1a-447bef4d203b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6598), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("94a11726-d82d-4a8e-868f-f061ef0c7e11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6600), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b29c344c-cac0-4e40-8828-b16d03f22752"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6599), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("bcacef4f-b91b-45c9-b327-e1d18b1bf3a2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 7, 16, 11, 42, 50, 216, DateTimeKind.Local).AddTicks(6602), 4 }
                });
        }
    }
}
