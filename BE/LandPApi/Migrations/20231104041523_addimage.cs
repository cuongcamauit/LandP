using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Slugs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90246d83-28b8-4663-81ad-98d87ea4b1b3", "AQAAAAEAACcQAAAAEDhgvo1zn+rgAU7m6n75Ub6Y1aYdQBNbNcO4FRauHvfjXn1WVMLWQ7Ou31a1VCMJpQ==", "b9ad72f6-ceab-4baf-b79d-04a8739ce54e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "905c8b73-f72a-4088-809d-273e02311875", "AQAAAAEAACcQAAAAENrNVxR+A0t8eLv+6YR1qXzTSY55i9UEsJvQ0pph05UwpGwujVkPkP8CcHcz6loKYQ==", "6302c931-cf96-40b0-9197-c0e386647f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c851476-6d98-4641-a736-1a7f7d1d0ea9", "AQAAAAEAACcQAAAAEHgg+oS+15zOOtSi960jfoi6tZGtdUvzj5SEOhZeEx8QcOKocvGWv1WER1VGPgX1gQ==", "4498cb01-514c-4e20-9755-26b03fa885bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad3de3cc-e9fd-46f9-972c-afddc57032c3", "AQAAAAEAACcQAAAAEF5Zy3jGB8rCjJAWPThX9nPk4wZUa1vHgerqIsZPeRnytjOGYzxAvZDUvbaL5XRIRQ==", "bc3f0ea0-948a-4882-909b-ab5f4ed516e1" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("1c60abb7-e489-4b53-9229-d1d0ead666bc"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1610), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("246e1b5c-7959-404f-a023-846d5ba8762f"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1608), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("304681fc-b38a-4e8e-afa7-88e30871871d"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1603), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("51cdce07-954f-4b36-9dfd-19ea1d593b7f"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1545), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("53ea0fe5-52fc-4703-8e05-dc5ffff22191"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1512), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("6625d5ca-8564-423b-b435-49b69599c4e9"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1607), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("7ba88e96-a25a-4a02-b41d-a23f104426c8"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1538), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("8d127f26-4b8b-44aa-bd1a-05ac332ad263"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1546), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("accc500d-dc10-45c3-bf19-82e459e246ed"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1612), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("be63a838-028b-4408-a8f4-62fc62865140"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1606), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("c1911d45-13d0-4bf9-a97f-1c15b3f33928"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1543), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("e18b5b4f-0853-41b3-9672-cc2d247fb073"), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1527), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1448), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1457), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1455), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1451), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("858f6524-f190-4886-a795-4dac7545286f"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1453), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1446), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1454), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1450), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("12c0f733-4296-4475-a66a-b9803a7e23dc"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("1be9d69b-9354-49d9-b833-e7745fc36a4a"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("36da8cb1-fe33-4d24-847f-3df2c40fdb93"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("389dc0cc-9fd6-4d1c-891d-41f300794baa"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("423f622f-e3b6-41d7-ae83-67894c7a156a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("486d8afc-7ddb-441d-9eb8-cfac3f2370ae"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("63db754c-1fc4-4d55-ad02-e9870603cdd9"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("6b5a7b1c-945a-4b69-9551-79035a11e4ad"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("6dee4296-08f4-4178-b13d-0fc2621992b3"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("6ec266d7-dec0-4d77-9b5a-e125c7271832"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("763fd94f-aab3-4fd6-a94b-01c26bbf558d"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("7e65ced7-19bf-4311-8a07-95397e8801c7"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("82606502-83da-48db-80e3-686f13e2718e"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("982bcb01-0e68-472a-82c7-b61637d3c354"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("d03adc32-267f-4f36-bf45-15818394f0b7"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("d6070058-a7ab-4a9d-8a0c-105395cdf379"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("e88a5226-9248-4e6a-9561-4de9e5c0cd0a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("eba1755c-5afd-414e-bd7f-0df330f09858"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("efaa48ef-1255-4e56-a763-fe5ee6f88b1d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("858f6524-f190-4886-a795-4dac7545286f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1666), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1665), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1661), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1663), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("858f6524-f190-4886-a795-4dac7545286f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1664), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1660), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1664), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 11, 4, 11, 15, 22, 778, DateTimeKind.Local).AddTicks(1662), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1c60abb7-e489-4b53-9229-d1d0ead666bc"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("246e1b5c-7959-404f-a023-846d5ba8762f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("304681fc-b38a-4e8e-afa7-88e30871871d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("51cdce07-954f-4b36-9dfd-19ea1d593b7f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("53ea0fe5-52fc-4703-8e05-dc5ffff22191"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6625d5ca-8564-423b-b435-49b69599c4e9"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7ba88e96-a25a-4a02-b41d-a23f104426c8"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8d127f26-4b8b-44aa-bd1a-05ac332ad263"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("accc500d-dc10-45c3-bf19-82e459e246ed"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("be63a838-028b-4408-a8f4-62fc62865140"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c1911d45-13d0-4bf9-a97f-1c15b3f33928"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e18b5b4f-0853-41b3-9672-cc2d247fb073"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("858f6524-f190-4886-a795-4dac7545286f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c0f733-4296-4475-a66a-b9803a7e23dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1be9d69b-9354-49d9-b833-e7745fc36a4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36da8cb1-fe33-4d24-847f-3df2c40fdb93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("389dc0cc-9fd6-4d1c-891d-41f300794baa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("423f622f-e3b6-41d7-ae83-67894c7a156a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("486d8afc-7ddb-441d-9eb8-cfac3f2370ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63db754c-1fc4-4d55-ad02-e9870603cdd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b5a7b1c-945a-4b69-9551-79035a11e4ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dee4296-08f4-4178-b13d-0fc2621992b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec266d7-dec0-4d77-9b5a-e125c7271832"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("763fd94f-aab3-4fd6-a94b-01c26bbf558d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e65ced7-19bf-4311-8a07-95397e8801c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82606502-83da-48db-80e3-686f13e2718e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("982bcb01-0e68-472a-82c7-b61637d3c354"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03adc32-267f-4f36-bf45-15818394f0b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6070058-a7ab-4a9d-8a0c-105395cdf379"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e88a5226-9248-4e6a-9561-4de9e5c0cd0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eba1755c-5afd-414e-bd7f-0df330f09858"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efaa48ef-1255-4e56-a763-fe5ee6f88b1d"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("858f6524-f190-4886-a795-4dac7545286f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("09447cb3-f049-45c0-bd8a-3da9ee690e86"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2ba30203-c1d5-4727-a671-a3fe2f2fe939"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("728acc44-2f1f-4732-8099-7ee7b5c44db8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("824314f7-cabf-46c8-bfc0-00ca1a920ed5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("858f6524-f190-4886-a795-4dac7545286f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a0cac85b-7078-43b2-9e71-5480fe5ef89d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e149089f-7688-4c6d-bfbb-0ca867ac1ed9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e80c85cd-1a3c-4a47-830f-219e640a0305"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Slugs");

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
        }
    }
}
