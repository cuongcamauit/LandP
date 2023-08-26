using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addaddressid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("01e2bca8-c997-479e-9574-7a4f46f7a6bb"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("08ef779a-6973-433f-b5eb-5a2019052ab8"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("185fb4be-9567-4b37-ae05-8ce2bc231556"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("42b63337-f2a4-4cb5-b3a0-e7d96b053dda"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("54e1bcf8-23a5-4e7f-878e-6f7c99643c1b"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("74142fde-7978-40f1-8297-0e3d5a0ca045"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a119adb2-6ca1-494d-9b4d-467798e6a18b"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ab81574b-6ada-47ce-ba94-c61eecb731c1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("bf808701-18ec-4856-8f70-a28ff3b0493a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d4600ff5-349e-4c01-b983-387b7deb9d9e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ed4b656f-4383-40c0-a53d-a12860cf7b5c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f94edbe7-672a-4d63-9a1c-709d71934bcb"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fae61a7-7f44-4be0-a191-2b41a739006d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("138849be-7c2f-4c23-a567-4a86eea04813"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2612809f-70ab-4ea4-89ad-066403a05917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3507d9a5-0dcc-498f-96e7-338551ad818d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d532ad8-408e-476a-9605-63b6914e08c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("568d675a-8fb1-4935-9778-a32f2e24dac5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6545692b-3a84-468a-b500-333be60ce044"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70d36daa-5c04-4d57-a287-04d6af907a31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89844bb6-6375-4c77-85ea-1e5be395d6dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90a15482-fcfb-44e1-ae9a-62eb4926665c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91b5652c-e259-4c2d-bb8a-75e259f44704"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99785777-2267-4358-9bc9-07991ec7a5ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a180a599-1bd0-4075-aac4-309ebfea88d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc44cd5d-c05f-49b4-b1ba-2b4605a3ab5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2fc2ca8-4cae-4243-947d-fb65d3800e0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbb012fe-fdee-4d65-ba87-d50fa38e483a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3527709-84f4-48e2-8f83-a13ff370ba59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6079820-90eb-4588-b48b-81b36d96dcf5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd958fe4-473d-4ab8-8d38-e65d260f44a1"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"));

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0750d8d3-bfff-45f2-b081-2a86ffe91bfd"),
                columns: new[] { "DistrictId", "ProvinceId", "WardId" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"),
                columns: new[] { "DistrictId", "ProvinceId", "WardId" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a8ef199-2ed7-4546-859b-4925e3658d44", "AQAAAAEAACcQAAAAEBRGzOUTcQ3ezcCkFI8kOCSpqFOHtRmgZ/hjE2T3JORu8orFIRFDhYMp18Q2I1crSQ==", "c431d56a-d14e-4dd8-a162-8ab0a190eece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e6e95d-4aff-459c-9ac3-32127d7c4090", "AQAAAAEAACcQAAAAEAk3nyINVkNMuxktSMXqc+EYWScEv0FVQ8pFoWJKOR/2XmmnTZyTgtXCbTUZRzek5Q==", "35df6d12-e665-4747-952e-3194c75c5ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1133c9ee-15d2-4d2d-ad0e-49bda0c63b1e", "AQAAAAEAACcQAAAAEHnQiNkzuPSLvF8QGqUzzTwYoejIhYgUHuoGT4Gqq25jDxxgMRU9pvQRfl9rYwezjQ==", "aaeb7764-b65d-4e22-9a08-d47e19d1099d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17263ba-ebfc-432e-a978-63b792eea754", "AQAAAAEAACcQAAAAEN3UazZji2T+/MqvhzinA6I2GkhdaDVEBL8omvvXQISLlgcMnjxJVLIBzfgDjaUT2A==", "e8b7690a-7aa5-4837-9cf1-c6f92a046389" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("18e03742-c90a-4618-9b40-fe6041af3c98"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8674), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("4aaf3738-90b3-4802-a748-0363d16da064"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8685), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("5fb90b76-d276-49b7-9e8a-7e99fdd9890f"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8679), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("69f9f35f-6663-48bd-bb0c-3bc838160012"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8691), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("917f1eeb-747c-44a6-8ec8-2dc9c7a101dc"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8676), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("980252b0-7a82-45e1-986a-bc1e4166a83a"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8678), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("ce781f46-9cf5-48eb-ba83-4933326d5100"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8684), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("dc0d5ed5-462c-4d5e-bd54-6ab2f570894d"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8667), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("ec30e979-55f3-4bda-9287-2bcd122b3a2e"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8695), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("f45d1dae-f886-40e0-982b-6b28d1b80508"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8689), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("f65d37ef-94a1-4e3b-88c4-c54c8666883b"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8682), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("fd239b5e-9e21-4b86-848f-76b712d37182"), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8681), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8569), "Delivered", 7250000.0 },
                    { new Guid("249f05d9-7270-4767-9229-740c6b539296"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8567), "Delivered", 7250000.0 },
                    { new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8560), "Delivered", 7250000.0 },
                    { new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8564), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8565), "Delivered", 7250000.0 },
                    { new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8563), "Delivered", 7250000.0 },
                    { new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8573), "Delivered", 7250000.0 },
                    { new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8561), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8562), "Delivered", 7250000.0 },
                    { new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8571), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0486c5ef-3aed-489e-9a65-01444b7c5d8a"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("2610a47a-9200-4800-aa88-ee52b1640928"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("3eddee40-31f9-43e4-8848-aa56a445b334"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("50a7ba9d-bf53-4c29-ae38-8ef5a8579231"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("63af955c-ab4d-4cb9-88cf-3b0361c5e336"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("680884d7-4303-4620-bc5c-59036958f92e"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("6833e3dc-49db-4067-8126-60f5d78a3157"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("6d54ff72-7cb9-49c5-8d28-3f5bc809889e"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("706a5e37-e34e-46b7-b2c8-8fdef554fff5"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("7251bf91-cdc5-44b8-bb7e-c806ca6c2830"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("77b7cd0e-cca3-4125-8a40-f93b5eca39a2"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("7b4e94b6-d695-4266-80e4-89c7536776d8"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("7f9285e3-4db5-43ad-acee-ae1a62cb88d1"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("7ffd042f-3c08-4e5d-9712-002376d709f6"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("8c439492-49eb-408c-819e-9a4a743aeb73"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("8e9a8044-e48e-49f9-82ad-d56d08b251af"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("a1c8d9f9-8901-41df-bf1c-8ddbb763437c"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("b55293f8-f4aa-4d64-96c4-fd03d0d59036"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("f1feff70-583c-41d2-ad5d-9a96d3db04e5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("249f05d9-7270-4767-9229-740c6b539296"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8736), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8735), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8734), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("249f05d9-7270-4767-9229-740c6b539296"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8732), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8728), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8731), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8730), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 8, 4, 7, 40, 54, 446, DateTimeKind.Local).AddTicks(8729), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("18e03742-c90a-4618-9b40-fe6041af3c98"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4aaf3738-90b3-4802-a748-0363d16da064"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5fb90b76-d276-49b7-9e8a-7e99fdd9890f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("69f9f35f-6663-48bd-bb0c-3bc838160012"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("917f1eeb-747c-44a6-8ec8-2dc9c7a101dc"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("980252b0-7a82-45e1-986a-bc1e4166a83a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ce781f46-9cf5-48eb-ba83-4933326d5100"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dc0d5ed5-462c-4d5e-bd54-6ab2f570894d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ec30e979-55f3-4bda-9287-2bcd122b3a2e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f45d1dae-f886-40e0-982b-6b28d1b80508"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f65d37ef-94a1-4e3b-88c4-c54c8666883b"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fd239b5e-9e21-4b86-848f-76b712d37182"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("249f05d9-7270-4767-9229-740c6b539296"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0486c5ef-3aed-489e-9a65-01444b7c5d8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2610a47a-9200-4800-aa88-ee52b1640928"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3eddee40-31f9-43e4-8848-aa56a445b334"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50a7ba9d-bf53-4c29-ae38-8ef5a8579231"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63af955c-ab4d-4cb9-88cf-3b0361c5e336"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("680884d7-4303-4620-bc5c-59036958f92e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6833e3dc-49db-4067-8126-60f5d78a3157"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d54ff72-7cb9-49c5-8d28-3f5bc809889e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("706a5e37-e34e-46b7-b2c8-8fdef554fff5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7251bf91-cdc5-44b8-bb7e-c806ca6c2830"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77b7cd0e-cca3-4125-8a40-f93b5eca39a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b4e94b6-d695-4266-80e4-89c7536776d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f9285e3-4db5-43ad-acee-ae1a62cb88d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffd042f-3c08-4e5d-9712-002376d709f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c439492-49eb-408c-819e-9a4a743aeb73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e9a8044-e48e-49f9-82ad-d56d08b251af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1c8d9f9-8901-41df-bf1c-8ddbb763437c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b55293f8-f4aa-4d64-96c4-fd03d0d59036"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1feff70-583c-41d2-ad5d-9a96d3db04e5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("249f05d9-7270-4767-9229-740c6b539296"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d9b6f49-dad9-4516-97f9-f19acc0c68f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("249f05d9-7270-4767-9229-740c6b539296"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("36ab88c4-b48c-4a65-bfa9-69ecdfa36c2d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("831dfba4-bafb-410d-a197-5680832cc1d3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a5f62d8c-0ba7-46ba-94a7-66fe9940df8b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("aaafe884-1342-4a65-91cd-f744fc84d14d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d3d90fd8-9f25-4820-8d30-b6f5e9238e41"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fa7fed6c-62ac-43ad-b010-d35a0909d2f4"));

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde77fcd-ce84-403a-9c78-ad12d79ee323", "AQAAAAEAACcQAAAAEGZPnY8FHsZDThcYv8zwkZsKS+gyH0FSyUrRdbPo98V1PvlVWodjMXDIShPaSwmWtg==", "e850d44e-30a5-4d17-a182-97eff7ad3628" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1dffc11-da91-488e-bc4e-1220669d1e09", "AQAAAAEAACcQAAAAEKnzkQljfAieySU1PHFiEzIXmwHo3mydF/HBJoDfL+yfdP7UiZdJuGJihLlW5ob9Rw==", "af3e5101-f034-426d-905f-2d72514b71a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ae7ad86-888f-4931-8e61-d95bfc6bb553", "AQAAAAEAACcQAAAAEALoy9TL3GA8HnYzqaOlMN7t975jCBhstodbleNyHnALtwhXIzgf7P4GMW4IQzJquw==", "841a288f-9f97-4c72-b845-22ba55bad4c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbbf96d-f96b-4867-818c-e2dec7f48f5f", "AQAAAAEAACcQAAAAEMvNtRYEsXdwSUmHWdHfJMkWlzdLYIzHqetkr3fqydDdTHbPgveGd5ZGBRTJE7C2Wg==", "05fab263-0e0b-4fcf-896c-439e6ee21a41" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("01e2bca8-c997-479e-9574-7a4f46f7a6bb"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6824), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("08ef779a-6973-433f-b5eb-5a2019052ab8"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6816), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("185fb4be-9567-4b37-ae05-8ce2bc231556"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6806), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("42b63337-f2a4-4cb5-b3a0-e7d96b053dda"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6810), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("54e1bcf8-23a5-4e7f-878e-6f7c99643c1b"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6823), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("74142fde-7978-40f1-8297-0e3d5a0ca045"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6826), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("a119adb2-6ca1-494d-9b4d-467798e6a18b"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6815), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("ab81574b-6ada-47ce-ba94-c61eecb731c1"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6812), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("bf808701-18ec-4856-8f70-a28ff3b0493a"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6821), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("d4600ff5-349e-4c01-b983-387b7deb9d9e"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6829), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("ed4b656f-4383-40c0-a53d-a12860cf7b5c"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6828), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("f94edbe7-672a-4d63-9a1c-709d71934bcb"), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6813), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6741), "Delivered", 7250000.0 },
                    { new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6742), "Delivered", 7250000.0 },
                    { new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6737), "Delivered", 7250000.0 },
                    { new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6744), "Delivered", 7250000.0 },
                    { new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6732), "Delivered", 7250000.0 },
                    { new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6736), "Delivered", 7250000.0 },
                    { new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6734), "Delivered", 7250000.0 },
                    { new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6739), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0fae61a7-7f44-4be0-a191-2b41a739006d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("138849be-7c2f-4c23-a567-4a86eea04813"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("2612809f-70ab-4ea4-89ad-066403a05917"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("3507d9a5-0dcc-498f-96e7-338551ad818d"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("4d532ad8-408e-476a-9605-63b6914e08c6"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("568d675a-8fb1-4935-9778-a32f2e24dac5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("6545692b-3a84-468a-b500-333be60ce044"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("70d36daa-5c04-4d57-a287-04d6af907a31"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("89844bb6-6375-4c77-85ea-1e5be395d6dd"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("90a15482-fcfb-44e1-ae9a-62eb4926665c"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("91b5652c-e259-4c2d-bb8a-75e259f44704"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("99785777-2267-4358-9bc9-07991ec7a5ca"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("a180a599-1bd0-4075-aac4-309ebfea88d5"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("bc44cd5d-c05f-49b4-b1ba-2b4605a3ab5d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("c2fc2ca8-4cae-4243-947d-fb65d3800e0d"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("cbb012fe-fdee-4d65-ba87-d50fa38e483a"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("d3527709-84f4-48e2-8f83-a13ff370ba59"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("e6079820-90eb-4588-b48b-81b36d96dcf5"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("fd958fe4-473d-4ab8-8d38-e65d260f44a1"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("37fc5e01-ae72-45ed-9705-6ead885ad62e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6869), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9bc8f80b-c6ad-454b-9ce5-91fd4a93f325"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6870), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("232e2af2-ee72-4333-8026-1d606d82d8b0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6868), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("400d65bf-1ec3-4344-bc71-62bc0fa5fbe8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6866), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b1057919-37ad-458b-af54-09a5767f9fc2"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6862), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("bd8790fe-bcff-47d7-8e31-1bd235a45f83"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6864), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("e4611dcf-d5b7-454b-9a72-ba36b85871a0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6863), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("eb38d1d1-da25-4c82-8fe9-502940a2647f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 7, 27, 14, 59, 22, 599, DateTimeKind.Local).AddTicks(6867), 5 }
                });
        }
    }
}
