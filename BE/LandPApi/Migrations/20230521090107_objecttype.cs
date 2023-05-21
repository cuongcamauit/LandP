using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class objecttype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("000637f7-a0e2-41b3-998f-8cd8c381188a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2189dbfc-f824-496c-9d58-acb2b5140e0d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("351c6d06-e832-43c6-9200-93b9b94b2f8a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("394133db-01dd-4428-bfef-b1ef39f030cb"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("55b639f4-64de-40f6-91fa-3eb375f82622"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5bd950f2-e696-442d-a0aa-a1b06d3f4687"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("65904eb1-5a05-413d-b8fc-0f406292a040"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7b2accd0-ca0e-4d48-913d-e0a1edd751e6"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c492ac7e-537f-4755-95f8-fa9239aaa1f2"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("cc697362-5be8-472f-bdb7-a9e144ceab6e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef8a95d9-0d91-4719-9ccb-3c31cd55bc23"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f873a7b3-67e0-4b62-9892-14b42e05beba"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("206d5576-07b4-419c-a7b3-05ff872df741"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00299adc-c2df-4b47-a8d5-cddb5fdaa9e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00e5add9-01e4-4438-9c23-7b646f5f026b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15411cf1-40bf-4ba6-931b-c05e1813dbff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bb86ddb-3953-4c9c-89f1-ab5ac22e3d27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d8f8548-9802-4378-9541-7d32bc886b74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21e26f4b-415b-4c1e-8446-7660a10d8b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2545adc3-a049-4260-a594-3139405dc3ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cfaad77-5a2c-408b-895c-4209e9abc101"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5698d8be-bcc4-493a-980f-cc02a2eb943d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("569df2fe-d9e3-4173-80a8-4ffe9d778482"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5af0197f-67ff-4db6-a2cd-dc6409cdeb5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67acbe03-88d9-4feb-b1b4-15249e4dd290"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fa8d3d5-812d-4d93-9bd6-3bd19025c2c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70264915-ef45-4f90-8911-2a6850e09be1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1c80d6d-0cbc-419e-91c6-b7441d86dcb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4859e52-c50b-4f0a-a14a-9e44bed20b54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b89ed5de-c2ed-4499-9a7f-5ce05ac37ab4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba7231ee-9bfa-4004-b33d-a6437483ee57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f02ab865-66f0-45f6-80c8-476e003b9356"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("206d5576-07b4-419c-a7b3-05ff872df741"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("206d5576-07b4-419c-a7b3-05ff872df741"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"));

            migrationBuilder.CreateTable(
                name: "ObjectModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    demo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectModels", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7122b621-2958-407e-8da9-bed1bd0e1453", "AQAAAAEAACcQAAAAEKL0MU5b17CgOTVXBee+k8IR264jC7636rlbY0YyutlCCuQZa4AzBBxA760JYHqSSQ==", "13a9bd37-1e4f-4ab6-9015-07296338ba96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a9ce64a-4841-4cbd-a85e-6233f06bf40c", "AQAAAAEAACcQAAAAELbqNOZdRGvHFJAUO19lGj33WwrUMmicXpS+kXU1O1cyYvY97IcX+x3mtycbAf9dMA==", "c50cc5b4-5f70-4fb8-9e1c-0cf3ef87974f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a3e9eeb-62ae-40d0-a226-2f999e4db47d", "AQAAAAEAACcQAAAAELuN7TQM3JwIJHdave77Doe/g63DWmug+IpjZVYp6ByK+ntDbFg77ER2KAwiimXGAw==", "8cd8f8c0-a763-43d3-ba7e-91aee9c00f25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e59ae572-bc4b-489b-8558-9ac05602bbd5", "AQAAAAEAACcQAAAAEP8WcMsLjxqGhQbQyhav/2cWSNa6/cCg3+HE5Iqa24rmgjNJ8fQDW6Fbh++Uwv3OGg==", "d29dc847-5ebe-4a86-ba9a-efd3691b679f" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("45c29629-14b5-406f-992b-4db53be60f20"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7550), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("57c8443d-77ce-4d98-b27c-efbc0ae7370b"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7560), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("80c4fe40-a676-4c5e-acc9-ea0ea708793d"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7552), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("8622c1ad-e759-435f-a5ac-1d384a48a99b"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7554), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("8d834ead-619c-4358-ae59-61cbec397282"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7559), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("9cfe09a8-108e-4d93-9866-1bb86fc8d413"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7564), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("a7af8a80-5be0-4fc9-a289-01667a9d12c0"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7561), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("ba0a1a4e-4cf1-42e3-817b-6fb8ae2125b1"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7544), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("be4d4533-e160-4be2-99fb-b05267bb88de"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7548), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("c7b98686-8110-4dbe-9b88-d7cb4257c7eb"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7563), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("f2937b7a-9b7d-45c1-ae54-38365df4d709"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7551), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("feeb3ad8-4808-4e7c-940f-b5336a8070aa"), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7555), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7488), "Delivered", 7250000.0 },
                    { new Guid("339880ba-001d-49d5-9101-89bec455e5c1"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7478), "Delivered", 7250000.0 },
                    { new Guid("77d09f94-364e-47bf-9def-da459ad913b8"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7475), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7475), "Delivered", 7250000.0 },
                    { new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7481), "Delivered", 7250000.0 },
                    { new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7486), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7486), "Delivered", 7250000.0 },
                    { new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7484), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7485), "Delivered", 7250000.0 },
                    { new Guid("d137fc00-4aca-4b29-8378-503f68575bab"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7477), "Delivered", 7250000.0 },
                    { new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7483), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "Name", "PercentSale", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("009e9864-f1ce-4e7b-8aee-5cee8ecfd60b"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", "  iPhone 14 Pro Max", 15.0, 27990000.0, 20, "Unit" },
                    { new Guid("0de6ae68-bb68-422f-b27b-8dbf654ef404"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", "Asus Gaming ROG Strix SCAR 17 G733PZ ", 10.0, 84000000.0, 10, "Unit" },
                    { new Guid("1c3e3d7c-8aa4-4ed4-8fac-d13f5eb248b1"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", " iPhone 14 Pro", 13.0, 24990000.0, 10, "Unit" },
                    { new Guid("2b0f13df-8633-4f9b-aa8f-e831b13e5b9b"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", " Dell Inspiron 15 5515", 3.0, 17990000.0, 10, "Unit" },
                    { new Guid("2bb7a788-17be-461a-b5a2-2eafde12ff06"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", "Asus Gaming ROG Strix SCAR 15 G533ZM ", 20.0, 37490000.0, 40, "Unit" },
                    { new Guid("32209e8e-da1e-4a7f-a612-6509ea545bb5"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", " iPhone 14 ", 5.0, 19990000.0, 10, "Unit" },
                    { new Guid("48fc52df-abf9-461d-ae62-8bb94e0436fc"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", " iPhone 14 Pro Max 1TB", 20.0, 51990000.0, 10, "Unit" },
                    { new Guid("5bbb36e6-b3ab-4063-9268-ea37bf809384"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", "  iPhone 14 Plus", 5.0, 21890000.0, 15, "Unit" },
                    { new Guid("5e9733a1-59c2-4a3f-98ca-a9b49172d67e"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", "Asus Vivobook S 14 Flip TP3402VA ", 5.0, 20990000.0, 20, "Unit" },
                    { new Guid("618b0b26-6798-4c09-967a-99bd819d16b5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("62539ccb-21dc-464e-94a0-9d736af61faf"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", "Dell Gaming Alienware m15 R6 ", 10.0, 47490000.0, 20, "Unit" },
                    { new Guid("67af5066-dc8c-4999-8022-68da1eef35af"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("6c7521b9-541e-498f-902a-c3e4020beff4"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", "Dell Gaming G15 5511 ", 2.0, 21990000.0, 30, "Unit" },
                    { new Guid("7c9d7796-0d1b-4ad3-b535-8ee2d8287eb5"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", "Asus Zenbook 14 Flip OLED UP3404VA ", 5.0, 31990000.0, 10, "Unit" },
                    { new Guid("80c34cb0-48ae-48ea-a187-399a8b0ae2f4"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", " Dell Inspiron 15 3520", 5.0, 16990000.0, 30, "Unit" },
                    { new Guid("8d866a36-3a30-4cf2-8bf6-2162e563ffec"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", " iPhone 13 ", 20.0, 17000000.0, 25, "Unit" },
                    { new Guid("c735cd12-4e17-40a4-9c56-2e78eaf9f91d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("f3ea5d4b-97c1-4ecf-a9fd-ab9351513aa0"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", "Laptop Asus Gaming ROG Strix G15", 10.0, 22990000.0, 50, "Unit" },
                    { new Guid("fcd7a8e7-353a-4a9c-9d1d-dc1b487bd346"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", " Dell Inspiron 16 5620", 5.0, 21990000.0, 20, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "PercentSale", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("339880ba-001d-49d5-9101-89bec455e5c1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("77d09f94-364e-47bf-9def-da459ad913b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("d137fc00-4aca-4b29-8378-503f68575bab"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7602), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7601), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("339880ba-001d-49d5-9101-89bec455e5c1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7597), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("77d09f94-364e-47bf-9def-da459ad913b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7596), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7598), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7600), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d137fc00-4aca-4b29-8378-503f68575bab"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7597), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 5, 21, 16, 1, 6, 788, DateTimeKind.Local).AddTicks(7599), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObjectModels");

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("45c29629-14b5-406f-992b-4db53be60f20"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("57c8443d-77ce-4d98-b27c-efbc0ae7370b"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("80c4fe40-a676-4c5e-acc9-ea0ea708793d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8622c1ad-e759-435f-a5ac-1d384a48a99b"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8d834ead-619c-4358-ae59-61cbec397282"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9cfe09a8-108e-4d93-9866-1bb86fc8d413"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a7af8a80-5be0-4fc9-a289-01667a9d12c0"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ba0a1a4e-4cf1-42e3-817b-6fb8ae2125b1"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("be4d4533-e160-4be2-99fb-b05267bb88de"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c7b98686-8110-4dbe-9b88-d7cb4257c7eb"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f2937b7a-9b7d-45c1-ae54-38365df4d709"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("feeb3ad8-4808-4e7c-940f-b5336a8070aa"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("339880ba-001d-49d5-9101-89bec455e5c1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("77d09f94-364e-47bf-9def-da459ad913b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d137fc00-4aca-4b29-8378-503f68575bab"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("009e9864-f1ce-4e7b-8aee-5cee8ecfd60b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0de6ae68-bb68-422f-b27b-8dbf654ef404"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c3e3d7c-8aa4-4ed4-8fac-d13f5eb248b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b0f13df-8633-4f9b-aa8f-e831b13e5b9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bb7a788-17be-461a-b5a2-2eafde12ff06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32209e8e-da1e-4a7f-a612-6509ea545bb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48fc52df-abf9-461d-ae62-8bb94e0436fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bbb36e6-b3ab-4063-9268-ea37bf809384"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e9733a1-59c2-4a3f-98ca-a9b49172d67e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("618b0b26-6798-4c09-967a-99bd819d16b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62539ccb-21dc-464e-94a0-9d736af61faf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67af5066-dc8c-4999-8022-68da1eef35af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c7521b9-541e-498f-902a-c3e4020beff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c9d7796-0d1b-4ad3-b535-8ee2d8287eb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80c34cb0-48ae-48ea-a187-399a8b0ae2f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d866a36-3a30-4cf2-8bf6-2162e563ffec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c735cd12-4e17-40a4-9c56-2e78eaf9f91d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3ea5d4b-97c1-4ecf-a9fd-ab9351513aa0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcd7a8e7-353a-4a9c-9d1d-dc1b487bd346"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("339880ba-001d-49d5-9101-89bec455e5c1"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("77d09f94-364e-47bf-9def-da459ad913b8"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d137fc00-4aca-4b29-8378-503f68575bab"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("188bc079-8d42-47d8-9c09-2e4a8b54cbea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("339880ba-001d-49d5-9101-89bec455e5c1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("77d09f94-364e-47bf-9def-da459ad913b8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8590649c-b1a4-49df-8ddc-3addd9825996"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ae4ce67a-942e-4c94-99b9-4e7b22270bda"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c65cd538-9d3d-4297-b5e1-ea6a087ef578"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d137fc00-4aca-4b29-8378-503f68575bab"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d9b2b162-bd45-484d-9af2-de3faf9ad640"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcdbcba-3767-4b13-b426-569762845aeb", "AQAAAAEAACcQAAAAEKN3eZUtm2pYyLLBbFxYgLS3g0Ux705/5fvfQJ3LZ7BO8/DxlUpSGiXFp9MHQkoh9A==", "d7e50778-acdd-4f2a-9d1a-0bd531b2c96b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f51ed803-1bf5-4a2b-adb4-8235280a29be", "AQAAAAEAACcQAAAAEHuED6XkLYv+Y+3yzHTqbbwYV3nJRxw4RxWrD7NLRWZ32N95cMIkcQdsRl8rqACpbg==", "c13dae62-d2ee-4796-bcec-bc319d8c3a50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ab77a60-4b46-4697-8820-a0da0ae2505e", "AQAAAAEAACcQAAAAELerE8srIsfDaKs+WbSR01yH+X5hFB7XDILyrnfdoI+sbBE7cL7rxOp3Dn2ZuLGYsw==", "bca8ac99-d278-4228-aa54-204721d54037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a80186-412d-4c61-8747-7e6495dde1bd", "AQAAAAEAACcQAAAAEK7n3LxuYXe8jAeEFGcMHIlDFBS6e0epKLOFsctVvbui63DAaKP0aI22s9oypKs3Zg==", "673c22ef-505b-42f3-bf6e-8eaaf3d2e51a" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("000637f7-a0e2-41b3-998f-8cd8c381188a"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5089), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("2189dbfc-f824-496c-9d58-acb2b5140e0d"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5096), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("351c6d06-e832-43c6-9200-93b9b94b2f8a"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5080), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("394133db-01dd-4428-bfef-b1ef39f030cb"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5095), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("55b639f4-64de-40f6-91fa-3eb375f82622"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5081), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("5bd950f2-e696-442d-a0aa-a1b06d3f4687"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5083), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("65904eb1-5a05-413d-b8fc-0f406292a040"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5087), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("7b2accd0-ca0e-4d48-913d-e0a1edd751e6"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5084), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("c492ac7e-537f-4755-95f8-fa9239aaa1f2"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5078), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("cc697362-5be8-472f-bdb7-a9e144ceab6e"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5086), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("ef8a95d9-0d91-4719-9ccb-3c31cd55bc23"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5072), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("f873a7b3-67e0-4b62-9892-14b42e05beba"), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5093), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("206d5576-07b4-419c-a7b3-05ff872df741"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4996), "Delivered", 7250000.0 },
                    { new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5000), "Delivered", 7250000.0 },
                    { new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5003), "Delivered", 7250000.0 },
                    { new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4999), "Delivered", 7250000.0 },
                    { new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5001), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5002), "Delivered", 7250000.0 },
                    { new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5004), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5005), "Delivered", 7250000.0 },
                    { new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4997), "Delivered", 7250000.0 },
                    { new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4994), new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4995), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "Name", "PercentSale", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("00299adc-c2df-4b47-a8d5-cddb5fdaa9e9"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", "  iPhone 14 Plus", 5.0, 21890000.0, 15, "Unit" },
                    { new Guid("00e5add9-01e4-4438-9c23-7b646f5f026b"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("15411cf1-40bf-4ba6-931b-c05e1813dbff"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", " Dell Inspiron 15 5515", 3.0, 17990000.0, 10, "Unit" },
                    { new Guid("1bb86ddb-3953-4c9c-89f1-ab5ac22e3d27"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", " Dell Inspiron 15 3520", 5.0, 16990000.0, 30, "Unit" },
                    { new Guid("1d8f8548-9802-4378-9541-7d32bc886b74"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("21e26f4b-415b-4c1e-8446-7660a10d8b05"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", "Dell Gaming Alienware m15 R6 ", 10.0, 47490000.0, 20, "Unit" },
                    { new Guid("2545adc3-a049-4260-a594-3139405dc3ac"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", "Laptop Asus Gaming ROG Strix G15", 10.0, 22990000.0, 50, "Unit" },
                    { new Guid("3cfaad77-5a2c-408b-895c-4209e9abc101"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", " iPhone 14 Pro Max 1TB", 20.0, 51990000.0, 10, "Unit" },
                    { new Guid("5698d8be-bcc4-493a-980f-cc02a2eb943d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", " Dell Inspiron 15 3511", 5.0, 12690000.0, 10, "Unit" },
                    { new Guid("569df2fe-d9e3-4173-80a8-4ffe9d778482"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", "Asus Gaming ROG Strix SCAR 15 G533ZM ", 20.0, 37490000.0, 40, "Unit" },
                    { new Guid("5af0197f-67ff-4db6-a2cd-dc6409cdeb5c"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", "Asus Zenbook 14 Flip OLED UP3404VA ", 5.0, 31990000.0, 10, "Unit" },
                    { new Guid("67acbe03-88d9-4feb-b1b4-15249e4dd290"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", "Asus Vivobook S 14 Flip TP3402VA ", 5.0, 20990000.0, 20, "Unit" },
                    { new Guid("6fa8d3d5-812d-4d93-9bd6-3bd19025c2c2"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", "Asus Gaming ROG Strix SCAR 17 G733PZ ", 10.0, 84000000.0, 10, "Unit" },
                    { new Guid("70264915-ef45-4f90-8911-2a6850e09be1"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", " iPhone 14 ", 5.0, 19990000.0, 10, "Unit" },
                    { new Guid("a1c80d6d-0cbc-419e-91c6-b7441d86dcb5"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", " iPhone 13 ", 20.0, 17000000.0, 25, "Unit" },
                    { new Guid("b4859e52-c50b-4f0a-a14a-9e44bed20b54"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", "  iPhone 14 Pro Max", 15.0, 27990000.0, 20, "Unit" },
                    { new Guid("b89ed5de-c2ed-4499-9a7f-5ce05ac37ab4"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", " iPhone 14 Pro", 13.0, 24990000.0, 10, "Unit" },
                    { new Guid("ba7231ee-9bfa-4004-b33d-a6437483ee57"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", "Dell Gaming G15 5511 ", 2.0, 21990000.0, 30, "Unit" },
                    { new Guid("f02ab865-66f0-45f6-80c8-476e003b9356"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", " Dell Inspiron 16 5620", 5.0, 21990000.0, 20, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "PercentSale", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("206d5576-07b4-419c-a7b3-05ff872df741"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 },
                    { new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 0.0, 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("4ebdc77f-3337-435a-9d58-c123c72f36fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5137), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("b3f1de97-852e-40ab-b96d-44390b772f0d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5140), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("206d5576-07b4-419c-a7b3-05ff872df741"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5131), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("3f6547b5-7b32-4cd7-a7fb-3c481e6cc83d"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5134), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("83d554d9-0292-477f-83c3-d3b3614c3208"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5133), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("9c89b456-55d2-47cb-9a5d-027d388c9951"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5136), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d5db2f5f-dcd8-49e6-b1b4-8efa6905b388"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5132), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("db452e29-30d8-4684-a07f-7c55863b4b66"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 5, 4, 17, 23, 59, 502, DateTimeKind.Local).AddTicks(5130), 5 }
                });
        }
    }
}
