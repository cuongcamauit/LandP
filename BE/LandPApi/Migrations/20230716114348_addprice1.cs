using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addprice1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Products",
                newName: "IsDeleted");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aae89bf-73af-4035-857d-b79fa5c34756", "AQAAAAEAACcQAAAAEEQ/IJMNfwvOc5f5lG1f2cMw4zPsq+vuFzqLzOVQ1v9NsQTuzz5d0yZa1f33/OBU6g==", "ed49bfb3-33fb-422a-8f98-a85596394bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1360ea9c-685a-442b-b388-bfa68ea1baa0", "AQAAAAEAACcQAAAAELmxiRVzl/HFHDMXKtS5+2WtkG3NMFFL+bzzAQaAvedI9UaixsxH89kZmRbKbLKXUw==", "90ecb063-1f32-41ae-b97d-6bc03ff7d624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22581369-77e2-45de-bf71-a90b4e3c1390", "AQAAAAEAACcQAAAAEBzs3a0bzkssqurpIxXwDtDY+b+4mS5hxS7zZs0VWlyRaJTZHQXXjpYdIlDj8F4MHQ==", "3a694476-5295-4d2d-9a8c-e066450b7e8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ec96d27-3b3f-420e-8344-db1b8096e9f5", "AQAAAAEAACcQAAAAEJgGxvKTcS6X81yZHxFxJHY+pptKXrQNAoivY1VZN+W1arLRzS3ZFdtMlcE45NNKGg==", "fd18a094-256c-4620-98de-e0b5cc8b4871" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("07947be2-e9f9-42f3-986a-dac8395e3a17"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1967), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("5f734d7c-54d7-4f39-a28f-ccaa885767ba"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1964), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("6f6ab42b-9466-44f3-90d8-400069a9522c"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1968), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("72dbc48c-5eec-49bd-b041-cc8807a33aed"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1979), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("748c18d6-a946-4ab7-a41a-9ed0b928af21"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1981), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("7a747d18-f7c2-43f7-afde-f438ea79acfe"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1966), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("abb9f274-fb54-4a22-8914-97132145017e"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1978), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("b00b63eb-d6cc-44a0-a3bc-7574144ad86a"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1970), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("b878a9f0-779e-4f8c-a73b-3b2a371f28c8"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1976), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("bf1ec9ca-5834-4db8-a14e-ce122884b814"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1974), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("d7597ac1-4989-40ca-afe1-df5eef0b688a"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1977), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" },
                    { new Guid("fc147e7e-fbf4-42b7-8074-8793dca6f3bc"), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1961), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1893), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1889), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "Status", "Total" },
                values: new object[,]
                {
                    { new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1901), "Delivered", 7250000.0 },
                    { new Guid("31aed704-59a7-480d-9740-ea9b68782a58"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1898), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1899), "Delivered", 7250000.0 },
                    { new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1900), "Delivered", 7250000.0 },
                    { new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1903), "Delivered", 7250000.0 },
                    { new Guid("929251db-35e1-4710-94a3-34acc33c017a"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1908), "Delivered", 7250000.0 },
                    { new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1904), "Delivered", 7250000.0 },
                    { new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1905), "Delivered", 7250000.0 },
                    { new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1906), new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1907), "Delivered", 7250000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("2b8bed3b-ff79-452f-bc03-9606365232cd"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("30ce3114-c220-4c09-a2df-f1dddd7a3d10"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, " Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("36ffc8bb-dadd-4dc2-9d65-fbdbf021d1ec"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("4a3cd8cf-dcd8-433f-b7eb-cbaa3438dc35"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("54bfa29c-297b-426c-bf70-4efc68287cef"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("5d8c87d2-9ac7-44c7-ac4d-709fa287c40d"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "  iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("84738877-0cae-4a9b-a133-1f9044453db5"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("940c4190-728b-470a-aea3-49cef40b18e7"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, " Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("9527b2d6-f674-498d-a792-f291c6f0d797"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("9ac8d170-4287-4d99-bb47-db8d16b5a0a0"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("b741b1ea-32eb-4268-bb84-211bf1d8b2ec"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "  iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("cfbe15fd-b00d-47e7-a61b-1ea43f9cc0dc"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, " iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("d27a19f9-3298-456e-b0c5-e8c3aae8fff4"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("de9be4b4-5cc0-4cc7-9368-7d64787bd956"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, " Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("e5a0539d-6e36-463f-9736-259bf929d0fc"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, " iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" },
                    { new Guid("e82f9d59-c8b1-46a6-ba6a-700a3c4af131"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), " Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, " iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("e8751584-ea07-4722-a018-c76005382b09"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, " iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("f807ce3a-e9d3-48c0-a203-72e28f5d19e8"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("fb3a9db8-db20-4b5f-93c9-4c801f24a1d6"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), " Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, " Dell Inspiron 15 3511", 12690000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("31aed704-59a7-480d-9740-ea9b68782a58"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("929251db-35e1-4710-94a3-34acc33c017a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("929251db-35e1-4710-94a3-34acc33c017a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2071), 3 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2070), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2066), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("31aed704-59a7-480d-9740-ea9b68782a58"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2065), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2065), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2067), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2068), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 7, 16, 18, 43, 48, 159, DateTimeKind.Local).AddTicks(2069), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("07947be2-e9f9-42f3-986a-dac8395e3a17"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5f734d7c-54d7-4f39-a28f-ccaa885767ba"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6f6ab42b-9466-44f3-90d8-400069a9522c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("72dbc48c-5eec-49bd-b041-cc8807a33aed"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("748c18d6-a946-4ab7-a41a-9ed0b928af21"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7a747d18-f7c2-43f7-afde-f438ea79acfe"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("abb9f274-fb54-4a22-8914-97132145017e"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b00b63eb-d6cc-44a0-a3bc-7574144ad86a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b878a9f0-779e-4f8c-a73b-3b2a371f28c8"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("bf1ec9ca-5834-4db8-a14e-ce122884b814"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d7597ac1-4989-40ca-afe1-df5eef0b688a"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fc147e7e-fbf4-42b7-8074-8793dca6f3bc"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("31aed704-59a7-480d-9740-ea9b68782a58"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("929251db-35e1-4710-94a3-34acc33c017a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b8bed3b-ff79-452f-bc03-9606365232cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30ce3114-c220-4c09-a2df-f1dddd7a3d10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36ffc8bb-dadd-4dc2-9d65-fbdbf021d1ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a3cd8cf-dcd8-433f-b7eb-cbaa3438dc35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54bfa29c-297b-426c-bf70-4efc68287cef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d8c87d2-9ac7-44c7-ac4d-709fa287c40d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84738877-0cae-4a9b-a133-1f9044453db5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("940c4190-728b-470a-aea3-49cef40b18e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9527b2d6-f674-498d-a792-f291c6f0d797"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ac8d170-4287-4d99-bb47-db8d16b5a0a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b741b1ea-32eb-4268-bb84-211bf1d8b2ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfbe15fd-b00d-47e7-a61b-1ea43f9cc0dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d27a19f9-3298-456e-b0c5-e8c3aae8fff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de9be4b4-5cc0-4cc7-9368-7d64787bd956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5a0539d-6e36-463f-9736-259bf929d0fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e82f9d59-c8b1-46a6-ba6a-700a3c4af131"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8751584-ea07-4722-a018-c76005382b09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f807ce3a-e9d3-48c0-a203-72e28f5d19e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb3a9db8-db20-4b5f-93c9-4c801f24a1d6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("929251db-35e1-4710-94a3-34acc33c017a"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("31aed704-59a7-480d-9740-ea9b68782a58"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c49a469-94ed-45ed-bef1-746dcb3872fb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("31aed704-59a7-480d-9740-ea9b68782a58"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("59eb3694-039b-4ac8-a922-0c5e086f04ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("71db0a45-74b1-48ac-9639-059be7c2aada"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("929251db-35e1-4710-94a3-34acc33c017a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c91e8b25-f0e3-49ad-99ea-6661cb9db860"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8060746-939d-4dd6-b6cc-019e37091edc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f9c4d07f-79da-46cf-858e-97a89a10c468"));

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Products",
                newName: "isDeleted");

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
    }
}
