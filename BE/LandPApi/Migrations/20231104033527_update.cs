using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slugs_Menus_Id",
                table: "Slugs");

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4a3496a8-5934-4381-ad36-cfea28de3dd9"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4e9b5a31-d9af-4482-81e6-87f88f60fb12"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("682898ac-9eaa-4a82-9357-1675b68c37f6"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7b3a4cf9-8a60-419a-a48f-c2e395a26b73"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8d234b8c-cfff-4f28-9526-7c220bcfd9ed"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a68e1cdb-40de-4b98-b25d-08d556694608"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a8e7599d-2d9e-46ac-a9b5-43a619fa7f7a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d7f9199c-606d-477b-ba02-9932edd28218"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dbe4561c-5aa5-4333-9180-672b4013b87c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dc3bd510-f14f-4d17-bb17-695adeac7552"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dc7b4732-f47b-4f94-af59-8bc4ff3898c4"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("eab0e88a-71c6-4129-8f7f-4254463110e9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9831392c-4186-4cf5-9766-a57a73198880"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("035c07d2-022c-4380-a5f0-7b58e72958eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03be55bc-c19a-47b6-a277-8540e7889a27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("045760f3-5857-49c0-b2d6-1a1bc1fd7816"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("122b7fc7-400c-40d3-aece-1f8245214fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15fc2610-4778-4b84-8dcf-5b3d88c0960b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176d6bf0-eba0-4513-943a-b8ed6de77150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c8e746-50cc-48b2-a73e-7bab297e91dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b385e33-a8cb-425d-9089-e520cd4c1a02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91d33c5c-0ef4-4055-8166-b12f784e3bdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99eccaca-283e-4eaf-b7b9-5cb575ffb3a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ba9a832-f9c0-429b-b682-5fd99978e86e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc5bbb1-3606-46ed-abbd-d4768a2473ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f0ef7f2-22e6-4505-a261-12f58e6e2d80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a91e4f96-c742-4050-ac14-a5d9480eaef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c80b5a1c-1166-46b1-ac4a-b8ae2720b837"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd14e76b-1370-46d2-83af-619b6bd3ab6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ea1001-4c54-491c-af2b-b4413c54a215"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e285dda6-a9a3-431e-82fd-4ec699a00156"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f13db822-f44e-42f3-bf2c-768605c2c4d2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("9831392c-4186-4cf5-9766-a57a73198880"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9831392c-4186-4cf5-9766-a57a73198880"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"));

            migrationBuilder.AddColumn<string>(
                name: "MenuId",
                table: "Slugs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80dea262-d0d1-4eb6-839f-15aea420909b", "AQAAAAEAACcQAAAAELEvRHqdcozEDLuGdo4pozxuFvf64nGH4zoUnj31SYpdm1BDLVWgAw0vZWx9ufThMg==", "83860c12-1fe3-4267-a0dc-d1081bb04d13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a4915bd-243d-4b02-9dbb-92882e99cb8a", "AQAAAAEAACcQAAAAEB0etoSeQiXlxSlDDRzCoEUPqe2IfFKQhZ4CLwEUZkkdMs3cFt6mFbCcJ46CsPd39w==", "09715180-8702-442a-bba4-626be852f922" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a4c3ee9-51a7-4464-aa60-866dd93540d2", "AQAAAAEAACcQAAAAEHPp7EzDfCTevzaaJazsn4cZGuun4X66J1mFaEd/icfcx5JPE8fmXx85wnuJRB1+kA==", "54d8f5cb-ddad-4e92-ad93-4c8f3ccf6708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcdc1aaa-7526-469a-97b8-d703851a5b6f", "AQAAAAEAACcQAAAAEJJNw6XpJDwv/8oMSouuG/i5AlyBimqygsDnZyhfmeOS7Qwq6dmv+Fa4Qk4sFN+i0g==", "388034a4-ff54-415b-8e8c-b282818cee8b" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("07237cf1-e7c0-4ca5-9650-bdb95134836e"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6993), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("12b05061-a0fe-46b2-bfc4-40766cfe28ae"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7005), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("42d4526b-d132-4df0-9691-58eb5df6c43d"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7001), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("5ad0c87d-b994-47ed-8ad7-8ea973db9b4a"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7006), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("5be37545-deb6-4c2d-b964-fe80d03cf3c1"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7003), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("80d73061-3525-4e56-82c1-367bf67e949a"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7004), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("97fcf217-9daa-47ae-90bb-9eb28c7161f7"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7000), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("9dbe897f-4e2d-4bfe-9779-1d2cd051676d"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7009), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("a44948f6-adab-40e1-a193-5df1853d2c38"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7008), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("c44e71cb-5ae8-48d1-b835-f125ca9cbc96"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6991), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("d71cb39e-0c3b-4225-b387-3d0c8d088cff"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6996), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("d7c0d6e8-fce1-4e7e-bafc-e466150f1527"), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6995), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("302a0083-226a-4bf8-b4df-673eef330daf"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6938), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6936), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6941), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("73238f1b-544e-490f-a340-92d33c7319f8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6936), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6937), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6943), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6939), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6940), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6944), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6945), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6941), new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6942), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("076881fb-21d9-4de8-a47f-4baf0045eb05"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("07e5712c-7997-416c-96ab-e4f0224c7c78"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("1b800890-a100-40dc-930e-0a8dca47f087"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("2151b268-96dc-4bff-959b-9bca62afc54a"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("26708574-8e14-4611-b609-aa73ccc63a00"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("26fc8062-1128-4bed-91ab-91629c6e25ad"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("2d267cfa-84ff-49d9-b129-d2ebf5785deb"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("33fde74c-57a8-4a42-b3a1-ff19b23be544"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("42d07a34-627b-407a-a994-eba240a6b492"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("522de0e9-5ed4-4ee2-9e30-2d0bfc3b6b94"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("5548105f-6859-42cf-926c-d097211da979"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("85e7dff1-a9cf-4a21-8a59-1009c9e46627"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("9c536096-ddb0-4521-b482-462e91af7db0"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("a63a1a99-eeac-4f97-9a44-b873315c950c"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("b94a88a0-8910-4eaf-b55a-28fe84092c15"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("bbad457b-10fe-437e-8630-e64b08e8afbe"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("bc5bb942-3fa5-4ac3-a353-5380fe8b7bf6"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("c5530597-7605-48c7-9cad-297d322068cd"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("df916018-15ce-49ba-b214-4f5ce1748599"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("302a0083-226a-4bf8-b4df-673eef330daf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("73238f1b-544e-490f-a340-92d33c7319f8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7225), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7225), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("302a0083-226a-4bf8-b4df-673eef330daf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7217), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7209), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7220), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("73238f1b-544e-490f-a340-92d33c7319f8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7209), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7218), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 11, 4, 10, 35, 27, 266, DateTimeKind.Local).AddTicks(7221), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slugs_MenuId",
                table: "Slugs",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Slugs_Menus_MenuId",
                table: "Slugs",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "slugId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slugs_Menus_MenuId",
                table: "Slugs");

            migrationBuilder.DropIndex(
                name: "IX_Slugs_MenuId",
                table: "Slugs");

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("07237cf1-e7c0-4ca5-9650-bdb95134836e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("12b05061-a0fe-46b2-bfc4-40766cfe28ae"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("42d4526b-d132-4df0-9691-58eb5df6c43d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5ad0c87d-b994-47ed-8ad7-8ea973db9b4a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5be37545-deb6-4c2d-b964-fe80d03cf3c1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("80d73061-3525-4e56-82c1-367bf67e949a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("97fcf217-9daa-47ae-90bb-9eb28c7161f7"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9dbe897f-4e2d-4bfe-9779-1d2cd051676d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a44948f6-adab-40e1-a193-5df1853d2c38"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c44e71cb-5ae8-48d1-b835-f125ca9cbc96"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d71cb39e-0c3b-4225-b387-3d0c8d088cff"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d7c0d6e8-fce1-4e7e-bafc-e466150f1527"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("302a0083-226a-4bf8-b4df-673eef330daf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("73238f1b-544e-490f-a340-92d33c7319f8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("076881fb-21d9-4de8-a47f-4baf0045eb05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07e5712c-7997-416c-96ab-e4f0224c7c78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b800890-a100-40dc-930e-0a8dca47f087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2151b268-96dc-4bff-959b-9bca62afc54a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26708574-8e14-4611-b609-aa73ccc63a00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fc8062-1128-4bed-91ab-91629c6e25ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d267cfa-84ff-49d9-b129-d2ebf5785deb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33fde74c-57a8-4a42-b3a1-ff19b23be544"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42d07a34-627b-407a-a994-eba240a6b492"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("522de0e9-5ed4-4ee2-9e30-2d0bfc3b6b94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5548105f-6859-42cf-926c-d097211da979"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85e7dff1-a9cf-4a21-8a59-1009c9e46627"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c536096-ddb0-4521-b482-462e91af7db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a63a1a99-eeac-4f97-9a44-b873315c950c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b94a88a0-8910-4eaf-b55a-28fe84092c15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbad457b-10fe-437e-8630-e64b08e8afbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc5bb942-3fa5-4ac3-a353-5380fe8b7bf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5530597-7605-48c7-9cad-297d322068cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df916018-15ce-49ba-b214-4f5ce1748599"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("302a0083-226a-4bf8-b4df-673eef330daf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("73238f1b-544e-490f-a340-92d33c7319f8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("302a0083-226a-4bf8-b4df-673eef330daf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("33769fcf-2d75-416f-89dd-2795fc8e96b5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("69e75682-3354-4dc7-b86f-5b9463128b92"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("73238f1b-544e-490f-a340-92d33c7319f8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("84cf2bcf-997e-471e-bca5-a7eebe6e2320"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("893f1e24-5296-425b-b2eb-ec3b40993460"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9cf6b839-5ed7-4f82-96b8-838befa8cc85"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b5ebbc42-1822-4c56-b5c9-301d62ba0c11"));

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Slugs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e999af98-c0e4-48fb-84b1-fb63814ff7e6", "AQAAAAEAACcQAAAAEFW6T1v7D/sbyL49S5b71A9sSn9h61WePxwOpLic/LBLGtG1z0sblxhPi4+CiXVmXQ==", "232d4782-5169-490f-bf79-eea862db3df1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbffa4b7-4789-40da-be82-0490e66be5f9", "AQAAAAEAACcQAAAAEF7w3lt1d4mKAGTrZqmLAmdoKTZ3ijlsWwEHXy7Fgta4Bwx6OiDMepgfKGsZ03u0qQ==", "a10f5932-5a99-4c71-b25e-36feceded514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f3ea40-68f9-4aba-ae00-21f9efbaca7b", "AQAAAAEAACcQAAAAEGya48nwxz2KVDt6460s3YXnknkjfohMbH1I0oi6Jzp4l+vSEgev2Ae6orQunSXzcg==", "e870e94f-1223-4cd3-b687-8ef28c3f763c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "487bb316-59f1-48f5-a031-45b1c9dec177", "AQAAAAEAACcQAAAAEPEJqeKkJ2OakKJdTM6l1Mqyya/1xcZGTKbEqn7bLnPuxV20gJyPPIIn82cEPDvhIA==", "d7cc578d-a165-46fd-a994-ba5a02c6bc3d" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("4a3496a8-5934-4381-ad36-cfea28de3dd9"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4290), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("4e9b5a31-d9af-4482-81e6-87f88f60fb12"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4296), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("682898ac-9eaa-4a82-9357-1675b68c37f6"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4353), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("7b3a4cf9-8a60-419a-a48f-c2e395a26b73"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4292), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("8d234b8c-cfff-4f28-9526-7c220bcfd9ed"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4302), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("a68e1cdb-40de-4b98-b25d-08d556694608"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4297), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("a8e7599d-2d9e-46ac-a9b5-43a619fa7f7a"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4351), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("d7f9199c-606d-477b-ba02-9932edd28218"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4304), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("dbe4561c-5aa5-4333-9180-672b4013b87c"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4294), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("dc3bd510-f14f-4d17-bb17-695adeac7552"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4295), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("dc7b4732-f47b-4f94-af59-8bc4ff3898c4"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4354), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("eab0e88a-71c6-4129-8f7f-4254463110e9"), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4299), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4235), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4230), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4236), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4238), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4239), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("9831392c-4186-4cf5-9766-a57a73198880"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4228), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4234), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4231), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("035c07d2-022c-4380-a5f0-7b58e72958eb"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("03be55bc-c19a-47b6-a277-8540e7889a27"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("045760f3-5857-49c0-b2d6-1a1bc1fd7816"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("122b7fc7-400c-40d3-aece-1f8245214fa9"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("15fc2610-4778-4b84-8dcf-5b3d88c0960b"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("176d6bf0-eba0-4513-943a-b8ed6de77150"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("65c8e746-50cc-48b2-a73e-7bab297e91dc"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("7b385e33-a8cb-425d-9089-e520cd4c1a02"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("91d33c5c-0ef4-4055-8166-b12f784e3bdf"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("99eccaca-283e-4eaf-b7b9-5cb575ffb3a0"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("9ba9a832-f9c0-429b-b682-5fd99978e86e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("9dc5bbb1-3606-46ed-abbd-d4768a2473ef"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("9f0ef7f2-22e6-4505-a261-12f58e6e2d80"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("a91e4f96-c742-4050-ac14-a5d9480eaef8"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("c80b5a1c-1166-46b1-ac4a-b8ae2720b837"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("cd14e76b-1370-46d2-83af-619b6bd3ab6e"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("d3ea1001-4c54-491c-af2b-b4413c54a215"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("e285dda6-a9a3-431e-82fd-4ec699a00156"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("f13db822-f44e-42f3-bf2c-768605c2c4d2"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("9831392c-4186-4cf5-9766-a57a73198880"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("53121e29-6211-49f2-adc2-60968d01a4a3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4397), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("7583ad9c-6fcd-478f-bfb0-f74f68cc390c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4398), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1ef9f80b-c07e-4888-b16a-ca1c5d4254a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4395), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("20da110d-a101-4d5a-97d9-de54539e7a6f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4393), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("51e9e7ad-96b5-4822-8854-94c245b7013e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4396), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("9831392c-4186-4cf5-9766-a57a73198880"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4392), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2ce6d32-d746-404d-8b66-f4e51f05f504"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4394), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d35dcd4f-df24-4dd8-9e19-f6f7c4ea4c01"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 11, 4, 10, 7, 48, 372, DateTimeKind.Local).AddTicks(4394), 5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Slugs_Menus_Id",
                table: "Slugs",
                column: "Id",
                principalTable: "Menus",
                principalColumn: "slugId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
