using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addisdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("06fef3a8-2b02-40cd-9d39-7d523294388e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("155a5893-7639-4ef7-99eb-ee6fde3cbe2a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("189e8a73-3a6e-4e1a-8222-2a4f713b6cc5"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("3ed6e7b0-3645-477d-9c7d-cc62dd278ed4"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("47bb7706-cac8-47c5-954c-4aa82ddd92be"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("504376cb-de74-4ff3-9cbd-f4924bb62e87"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6481b3df-1346-4c09-9938-c68a53ad7ce8"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d28ec27e-ca82-4129-bbd3-a350ab185905"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("efc8969c-7f6f-492d-9319-a43fa7c93b3c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f4360fda-f692-4bad-904c-95a9865eedfa"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f6fc9f91-5d7e-4078-85a1-a87dedf1fa97"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f96be364-1e3c-44bc-a610-e965fe75fb1f"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0db095b8-44cd-44c9-83ea-972e9bcab8ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("189afc29-0b6b-47d9-97d5-3817981de219"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2993cd58-6143-49e8-9e81-cc015a4e6ba5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31f77632-5325-4cc4-b9a7-c697aac4934c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e2f1b88-e387-4b04-8ffa-ddb7bf95e5db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60e86660-1f20-4293-845e-5a281cc1fd8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b3e14f1-75bf-4252-8c29-94d8234d9526"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("868a801c-b740-4251-993b-324523183d81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88cda6d8-38b2-48a6-8402-bf2ef353dda6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3a896d3-2b13-4844-93a9-ef07de44ee6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4bdc80c-6098-45e4-ac5b-1eb413b7a017"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf2fd44c-6b6f-4867-9fe6-081b6ff9a0a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9f0357c-f34e-455c-9385-22433a252bff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccd1ef5d-336c-45c3-a731-97937f47090b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb92bbc5-7f5a-4899-8b36-064cb3dc0ef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee0efcc5-a9ad-4067-83ae-8e46b9983ae6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eea95125-336e-4e76-86d5-2e3c00fdd99f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3c3fe4a-10ed-424d-8bf0-ad409e4b717a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f739b736-86fe-457c-83e0-9063cdde8b9f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Slugs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84d2e5af-7dd7-4358-a5f2-c8f53fdc3f40", "AQAAAAEAACcQAAAAEPPulTF/AkkWlzfotTTWtSLCINpFxkGSa+1ElBd0keeD9mwV/j5JQsQmQobGK64BIw==", "5901597c-9215-4528-92b8-fc2547eb7cb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b520d9-772b-4070-8928-440d9a1d657a", "AQAAAAEAACcQAAAAEDLYOMwukj2NNImeANJzjBI8gxxS3Ds040sw51TIZTRVsbtbb7m6EleVbXuFoGpZKQ==", "38705d53-60a9-4d4e-881a-dec572ae98f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36f31de9-767e-49db-9dd4-a0b3a7e1f99d", "AQAAAAEAACcQAAAAEI+/DS1fDOArbUNhWKZo3lUs8MPiVV6IAHYWp2L0XOyNIn+RipBRDlVI9tZ3R4T5KQ==", "9a26ead6-fa74-41cf-a1a2-a0dc5563dd9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73264c1-3d8d-49bc-8696-854f74db15b2", "AQAAAAEAACcQAAAAECqHlrsHgDGo9MRQmTXA0OMJ+xHQsRrsIS+ja3ke4mEybh4hskU5ekd7psK8rO1qiw==", "c012439a-c14f-41cf-ae0c-768dc7cc94ea" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("1ae78db4-b14b-4283-806f-7b93781c7b2d"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4739), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("1fe3bd33-cea3-4f14-905d-26020234e184"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4766), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("2947f37c-087c-48f8-938c-7a631eb03028"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4754), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("75dcc4ac-6586-4185-a6da-25c6e36003e1"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4734), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("7f21ed24-054a-4ad1-bbc1-dc3173d0e187"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4741), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("8194d6f2-d9ca-43e8-8eb3-ead18b6bed26"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4759), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("8cd3e207-a183-43a8-a47d-6376c39902c8"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4763), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("95917a7b-2c02-4e38-aed0-a2eed32effc7"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4757), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("b208d76d-2aca-4aa3-8251-d9b31541bc5d"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4761), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("d3d3a3ba-7248-4fcf-8dc4-3ff18d9f4ce6"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4748), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("f26b3822-78b2-478c-8516-e70bd67353bd"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4744), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("ff9a312f-16aa-4e9b-9839-c3089d140a7a"), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4746), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4573), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4560), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("40019694-8456-4025-a270-4d74eb0cc482"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4567), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("485e694e-143d-4fdb-8051-f85095d4383c"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4565), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4563), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4569), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4576), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4571), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0df251f2-3fd4-42dd-b145-c50e72d1c98e"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("3588172a-3613-4abf-88cd-305123d78f25"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("44fb866e-2bef-496e-bc9b-daeb2b28cb8c"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("4694b092-dde8-41bd-b178-a4dfb495fb2e"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("4a670206-46b2-4b43-9906-265039f9ba30"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("4b5f02a3-fa7b-4865-bb43-7e262be75e26"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("57e7cc98-6ef9-4c16-a5ee-3fc945a184a5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("6d9dd76a-6e9b-4ed7-a828-29c20aba9edc"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("73183add-ae39-48a6-be13-c798b73163c0"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("804c26ac-adb6-4be8-b071-0b48e3e78004"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("80b1d54e-3cac-4676-9750-c1af4f8df460"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("98c5e9b6-016a-41d5-8d6b-8796b5e0bd7e"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("bb38c710-4ea8-4337-a6fc-0555ba84553a"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("cca79e08-f792-4827-9be7-1e859fc60901"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("d7905e1c-c3b5-468a-814b-2d154366c0d0"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("da2bb625-bbf7-4d0b-b6ad-9640ba17d6ba"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("dc514693-2c46-4c26-ae35-4b3c4ef936ff"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("e8616637-428f-4cce-9445-f19219ae780e"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("fe2db9e8-de15-4d2d-bc0c-3fc14b3c2113"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("40019694-8456-4025-a270-4d74eb0cc482"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("485e694e-143d-4fdb-8051-f85095d4383c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4833), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4834), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4824), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("40019694-8456-4025-a270-4d74eb0cc482"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4829), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("485e694e-143d-4fdb-8051-f85095d4383c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4827), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4826), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4830), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 10, 19, 9, 36, 53, 586, DateTimeKind.Local).AddTicks(4831), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1ae78db4-b14b-4283-806f-7b93781c7b2d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1fe3bd33-cea3-4f14-905d-26020234e184"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2947f37c-087c-48f8-938c-7a631eb03028"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("75dcc4ac-6586-4185-a6da-25c6e36003e1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7f21ed24-054a-4ad1-bbc1-dc3173d0e187"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8194d6f2-d9ca-43e8-8eb3-ead18b6bed26"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8cd3e207-a183-43a8-a47d-6376c39902c8"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("95917a7b-2c02-4e38-aed0-a2eed32effc7"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b208d76d-2aca-4aa3-8251-d9b31541bc5d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d3d3a3ba-7248-4fcf-8dc4-3ff18d9f4ce6"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f26b3822-78b2-478c-8516-e70bd67353bd"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ff9a312f-16aa-4e9b-9839-c3089d140a7a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("40019694-8456-4025-a270-4d74eb0cc482"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("485e694e-143d-4fdb-8051-f85095d4383c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0df251f2-3fd4-42dd-b145-c50e72d1c98e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3588172a-3613-4abf-88cd-305123d78f25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44fb866e-2bef-496e-bc9b-daeb2b28cb8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4694b092-dde8-41bd-b178-a4dfb495fb2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a670206-46b2-4b43-9906-265039f9ba30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b5f02a3-fa7b-4865-bb43-7e262be75e26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57e7cc98-6ef9-4c16-a5ee-3fc945a184a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d9dd76a-6e9b-4ed7-a828-29c20aba9edc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73183add-ae39-48a6-be13-c798b73163c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("804c26ac-adb6-4be8-b071-0b48e3e78004"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80b1d54e-3cac-4676-9750-c1af4f8df460"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98c5e9b6-016a-41d5-8d6b-8796b5e0bd7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb38c710-4ea8-4337-a6fc-0555ba84553a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cca79e08-f792-4827-9be7-1e859fc60901"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7905e1c-c3b5-468a-814b-2d154366c0d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da2bb625-bbf7-4d0b-b6ad-9640ba17d6ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc514693-2c46-4c26-ae35-4b3c4ef936ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8616637-428f-4cce-9445-f19219ae780e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe2db9e8-de15-4d2d-bc0c-3fc14b3c2113"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("40019694-8456-4025-a270-4d74eb0cc482"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("485e694e-143d-4fdb-8051-f85095d4383c"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1e91ec1a-c9e9-48da-a974-85ac561529b5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2eab3b7e-2142-4798-b606-57a24dfff112"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("40019694-8456-4025-a270-4d74eb0cc482"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("485e694e-143d-4fdb-8051-f85095d4383c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("769e49ff-145d-43c2-98b2-24aacc2dada5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d0fa622b-fc95-4f0d-b960-f44d00c8dfc8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("df812822-7202-4ed9-b40f-84e54e2724bd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5feeb4c-d8f3-4c19-80c6-7a3dcf6813ef"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Slugs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f5877a0-9ec5-4f0d-bb12-7699774b44c1", "AQAAAAEAACcQAAAAECcdxyrS1MNAIz9X7QSzznzb+gSKTxVSOrhUS/rfxxnGa/ggfB122sppJz2ihw8DKA==", "8c53f326-7bc0-4780-adb4-6aacc5ef2fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc6c7e9-2f81-47f0-b9de-8f821dfcbb7b", "AQAAAAEAACcQAAAAEOTp0daNy7hlDjemkZp6xGmCTNlBKDP1DrzTLjOixvZHx7jc09BQiaMmanwZWk+Xgg==", "8c01e5a2-c995-44ac-aa2a-34920914ce41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f44120-9670-4b18-bb61-53f962663d33", "AQAAAAEAACcQAAAAENFXvtxdTLPUoDGLNBQafYfrA+5bFQefh5RmWUqGwF+tHST6EbWCqHwpLFjSlXMlAA==", "19190001-225e-4f37-98e6-48ed08957f6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9886f0-772c-46f3-9faf-ee497ba9301d", "AQAAAAEAACcQAAAAEOVKXfeV+kvtFMo6t6WBk7v/ocrGsIO/Bor4KW8CfUlyR2deTiQJrRLJw3H1k8IKKQ==", "f0a73abe-c6f7-420f-a801-adc483aabde2" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("06fef3a8-2b02-40cd-9d39-7d523294388e"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9525), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("155a5893-7639-4ef7-99eb-ee6fde3cbe2a"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9519), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("189e8a73-3a6e-4e1a-8222-2a4f713b6cc5"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9532), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("3ed6e7b0-3645-477d-9c7d-cc62dd278ed4"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9538), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("47bb7706-cac8-47c5-954c-4aa82ddd92be"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9528), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("504376cb-de74-4ff3-9cbd-f4924bb62e87"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9534), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("6481b3df-1346-4c09-9938-c68a53ad7ce8"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9542), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("d28ec27e-ca82-4129-bbd3-a350ab185905"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9526), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("efc8969c-7f6f-492d-9319-a43fa7c93b3c"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9537), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("f4360fda-f692-4bad-904c-95a9865eedfa"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9523), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("f6fc9f91-5d7e-4078-85a1-a87dedf1fa97"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9536), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("f96be364-1e3c-44bc-a610-e965fe75fb1f"), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9540), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9449), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9460), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9461), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9453), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9454), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9466), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9463), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9464), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9453), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9458), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9456), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0db095b8-44cd-44c9-83ea-972e9bcab8ab"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("189afc29-0b6b-47d9-97d5-3817981de219"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("2993cd58-6143-49e8-9e81-cc015a4e6ba5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("31f77632-5325-4cc4-b9a7-c697aac4934c"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("3e2f1b88-e387-4b04-8ffa-ddb7bf95e5db"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("60e86660-1f20-4293-845e-5a281cc1fd8f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("7b3e14f1-75bf-4252-8c29-94d8234d9526"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("868a801c-b740-4251-993b-324523183d81"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("88cda6d8-38b2-48a6-8402-bf2ef353dda6"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("b3a896d3-2b13-4844-93a9-ef07de44ee6c"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("b4bdc80c-6098-45e4-ac5b-1eb413b7a017"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("bf2fd44c-6b6f-4867-9fe6-081b6ff9a0a4"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("c9f0357c-f34e-455c-9385-22433a252bff"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("ccd1ef5d-336c-45c3-a731-97937f47090b"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("eb92bbc5-7f5a-4899-8b36-064cb3dc0ef8"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("ee0efcc5-a9ad-4067-83ae-8e46b9983ae6"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("eea95125-336e-4e76-86d5-2e3c00fdd99f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("f3c3fe4a-10ed-424d-8bf0-ad409e4b717a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("f739b736-86fe-457c-83e0-9063cdde8b9f"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6ce8fd61-c1a4-4797-b98e-e3d177e59744"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9629), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9610ec05-fbb9-44f4-916e-23e7c2dc3def"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9628), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("056ff686-8bb6-4e32-8dec-fe3f6b3490b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9626), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("1c089fc6-766e-4fac-a451-954afbe10dbb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9627), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5f2bd8c7-9178-40c7-a7bd-df2f80006989"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9623), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a7cda8ae-9e86-4d7d-be07-2821bd604bb9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9573), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d990e45b-8dcb-4825-9c95-cff56b424e5d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9625), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("f92e5e48-044e-4964-b8f9-5610ebbd1134"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 10, 19, 9, 13, 9, 505, DateTimeKind.Local).AddTicks(9624), 5 }
                });
        }
    }
}
