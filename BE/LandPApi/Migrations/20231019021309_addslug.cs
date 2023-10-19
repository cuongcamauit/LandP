using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addslug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("26f28182-9d97-4a50-8eab-a9611b94299d"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("28477e07-09f0-4d53-8d61-aecf11022e1f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("40770e24-8da8-4e49-aa5e-87d240f27b2f"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("48ee39b3-e6a6-4890-b6b2-7b5d3bf550bc"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8ec50629-2f61-45d1-b97d-a6d7ad7afef9"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9049d2b3-017f-411f-8da5-45bbfc17cdcb"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9e8ca374-6a7f-4a7d-b25e-939a8a7c3597"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a912f5a0-7cdb-4ccd-8b57-ba211fc472af"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c0c8f942-438d-4189-bc9f-151251cbefd5"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c675a8e8-2f5d-42a5-a8dc-d91b58226899"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e8f1a1de-4ee6-4b8e-9946-2ab966c5867c"));

            migrationBuilder.DeleteData(
                table: "HistoryStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fb047786-f956-4f37-8c4e-a81c993df286"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("58c8e760-f204-4f54-a816-3fe049318279"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("fdb603af-9227-4df0-8139-fea9d1031854"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c04b7c-b30d-438a-af55-986e3218b97c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b558925-330b-4d3f-b02a-83cc536c7788"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff59b6f-2202-4f0c-b4f3-b42eb989c8b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17a69b59-643e-4b30-97a8-e190e7315564"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2118348f-c762-41cc-a41b-3f8fee66719f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("269e6a61-a918-474f-af20-660ab3d1f017"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fcd35c8-606f-467b-b512-033120c44c06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56510997-8731-4a7a-9542-566baf23d5ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("571e031d-fa7e-4fad-9cca-0606bd0347b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e115ba0-6993-4fbb-9e4c-494bea33023c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("966c81bc-ae3e-4c5e-a400-bd0db956a47a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af4d081e-6fba-4585-9cc0-9852ce9a7a51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b09edc12-eb17-4a71-b776-208e5d84e4b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b962d70a-9d84-4527-91ed-aafd817ddaba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cddf4632-ecb0-4344-8b4c-f61838dad0bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2df3866-7a99-4b44-ba3c-471209927aee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5945a9f-3470-4650-9308-6a31dfbceb3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daf7c53b-bc42-4b85-9dbd-9aaa1b849907"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dee5ae9f-6286-470e-8303-e446bf4b5fb6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("58c8e760-f204-4f54-a816-3fe049318279"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("fdb603af-9227-4df0-8139-fea9d1031854"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("58c8e760-f204-4f54-a816-3fe049318279"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fdb603af-9227-4df0-8139-fea9d1031854"));

            migrationBuilder.CreateTable(
                name: "Slugs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slugs", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_SlugProducts_ProductId",
                table: "SlugProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SlugProducts");

            migrationBuilder.DropTable(
                name: "Slugs");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f777ea-6043-4ca4-bb5a-623852d35503", "AQAAAAEAACcQAAAAEM5pjFpV9aEObRPpxKHqlOaZPt7zR858+UHcfyuSrXmzy27P6yhripHePETtMlry4Q==", "7d5f57c1-69e3-468e-b92e-fb5c83ca75e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72b6c6ee-bc41-44f3-b4fd-971b6ddf3845", "AQAAAAEAACcQAAAAEG1i45iU6JrwK223HRc8mLSyK2arNPG4pdJ/wz5mXQNFxoQarfgDyMgIauyQGJLb2A==", "31f1765f-16b6-4e56-a8f3-a292aad54c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2c45459-2784-476c-acd2-9221d82b01d5", "AQAAAAEAACcQAAAAEBYx3BXMkcZsPlt3vIS5V44QlUz99Kqeli4Te4tUXl9SOc7dADf63xN8XF/i0RDlVA==", "14eb70df-17d8-4b6a-93a7-6c5900dab9d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "414bb196-f053-420b-a27c-0d96bf5e14f5", "AQAAAAEAACcQAAAAEE8LqCelAComhPCp9C8Ii18tFI8Y6IedMl0OchiMlUeVGqTMTYwx2k6JFiC6XLzJOw==", "7c456e07-ed35-4c7f-b570-88a725152e95" });

            migrationBuilder.InsertData(
                table: "HistoryStatuses",
                columns: new[] { "Id", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { new Guid("26f28182-9d97-4a50-8eab-a9611b94299d"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7143), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Shipping" },
                    { new Guid("28477e07-09f0-4d53-8d61-aecf11022e1f"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7265), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Delivered" },
                    { new Guid("40770e24-8da8-4e49-aa5e-87d240f27b2f"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7164), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Shipping" },
                    { new Guid("48ee39b3-e6a6-4890-b6b2-7b5d3bf550bc"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7160), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Processing" },
                    { new Guid("8ec50629-2f61-45d1-b97d-a6d7ad7afef9"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7256), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Processing" },
                    { new Guid("9049d2b3-017f-411f-8da5-45bbfc17cdcb"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7139), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Processing" },
                    { new Guid("9e8ca374-6a7f-4a7d-b25e-939a8a7c3597"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7168), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "Delivered" },
                    { new Guid("a912f5a0-7cdb-4ccd-8b57-ba211fc472af"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7132), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "New" },
                    { new Guid("c0c8f942-438d-4189-bc9f-151251cbefd5"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7148), new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), "Delivered" },
                    { new Guid("c675a8e8-2f5d-42a5-a8dc-d91b58226899"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7155), new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), "New" },
                    { new Guid("e8f1a1de-4ee6-4b8e-9946-2ab966c5867c"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7261), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "Shipping" },
                    { new Guid("fb047786-f956-4f37-8c4e-a81c993df286"), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7172), new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), "New" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7013), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7009), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"),
                columns: new[] { "Date", "PaidAt" },
                values: new object[] { new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6996), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CustomerId", "Date", "PaidAt", "ShippingFee", "ShippingFeeVoucher", "ShopVoucher", "Status", "SubTotal" },
                values: new object[,]
                {
                    { new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7019), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("58c8e760-f204-4f54-a816-3fe049318279"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7038), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7040), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7025), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7027), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7023), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7045), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7031), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "04be0c35-571e-425c-992e-15a7227286de", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7046), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7049), 0.0, 0.0, 0.0, "Delivered", 0.0 },
                    { new Guid("fdb603af-9227-4df0-8139-fea9d1031854"), new Guid("3fd64b58-5ded-40ed-876c-027bcc759a75"), "1b0b163d-032f-4e19-9e64-d89bf02f1751", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7036), 0.0, 0.0, 0.0, "Delivered", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "FolderId", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("08c04b7c-b30d-438a-af55-986e3218b97c"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 15 G533ZM i7 (LN2210W) chinh phục mọi chiến trường ảo với bộ vi xử lý Intel Core i7 thế hệ 12 cùng đồ hoạ NVIDIA GeForce RTX 3060. Giảm tối đa thời gian chờ đợi nhờ ổ SSD PCIe thế hệ 4 và bộ nhớ RAM DDR5 tốc độ cao, luôn sẵn sàng cùng bạn chiến thắng trong mọi cuộc chiến.", null, "https://cdn.tgdd.vn/Products/Images/44/299060/Slider/vi-vn-asus-rog-strix-scar-15-g533z-i7-ln2210w-ac-1.jpg", false, "Asus Gaming ROG Strix SCAR 15 G533ZM ", 37490000.0, 40, "Unit" },
                    { new Guid("0b558925-330b-4d3f-b02a-83cc536c7788"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3520 i5 1235U (i5U085W11BLU) là phiên bản laptop học tập - văn phòng của nhà Dell khi sở hữu phong cách thiết kế tối giản nhưng không kém phần trẻ trung, bộ vi xử lý Intel Gen 12 và bộ Office bản quyền vĩnh viễn đáp ứng đầy đủ mọi nhu cầu học tập, văn phòng của người dùng.", null, "https://cdn.tgdd.vn/Products/Images/44/296921/Slider/vi-vn-dell-inspiron-15-3520-i5u085w11blu-1.jpg", false, "Dell Inspiron 15 3520", 16990000.0, 30, "Unit" },
                    { new Guid("0ff59b6f-2202-4f0c-b4f3-b42eb989c8b0"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Thêm một siêu phẩm được trang bị bộ vi xử lý Intel thế hệ 13 hoàn toàn mới có mặt tại Thế Giới Di Động đó chính là laptop Asus Zenbook 14 Flip OLED UP3404VA i7 (KN039W) với những thông số hết sức ấn tượng.                   ", null, "https://cdn.tgdd.vn/Products/Images/44/304259/asus-zenbook-14-flip-oled-up3404va-i7-kn039w-ab-glr-15.jpg", false, "Asus Zenbook 14 Flip OLED UP3404VA ", 31990000.0, 10, "Unit" },
                    { new Guid("17a69b59-643e-4b30-97a8-e190e7315564"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix SCAR 17 G733PZ R9 7945HX (LL980W) được thiết kế để mang đến trải nghiệm chơi game tốt nhất, cung cấp hiệu suất mạnh mẽ với cấu hình ấn tượng, chắc chắn sẽ làm hài lòng những game thủ khó tính nhất.", null, "https://cdn.tgdd.vn/Products/Images/44/305745/asus-gaming-rog-strix-scar-17-g733pz-r9-ll980w-5.jpg", false, "Asus Gaming ROG Strix SCAR 17 G733PZ ", 84000000.0, 10, "Unit" },
                    { new Guid("2118348f-c762-41cc-a41b-3f8fee66719f"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Vivobook S 14 Flip TP3402VA i5 (LZ031W) được thiết kế với sự cân bằng tuyệt vời giữa sức mạnh và tính di động, một chiếc laptop cao cấp được tích hợp nhiều tính năng và cấu hình tiên tiến, sẵn sàng đáp ứng mọi nhu cầu sử dụng của bạn.", null, "https://cdn.tgdd.vn/Products/Images/44/304869/Slider/vi-vn-asus-vivobook-s-14-flip-tp3402va-i5-lz031w--(3).jpg", false, "Asus Vivobook S 14 Flip TP3402VA ", 20990000.0, 20, "Unit" },
                    { new Guid("269e6a61-a918-474f-af20-660ab3d1f017"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.", null, "https://cdn.tgdd.vn/Products/Images/42/245545/iphone-14-plus-ti-1.jpg", false, "iPhone 14 Plus", 21890000.0, 15, "Unit" },
                    { new Guid("4fcd35c8-606f-467b-b512-033120c44c06"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro 128GB - Mẫu smartphone đến từ nhà Apple được mong đợi nhất năm 2022, lần này nhà Táo mang đến cho chúng ta một phiên bản với kiểu thiết kế hình notch mới, cấu hình mạnh mẽ nhờ con chip Apple A16 Bionic và cụm camera có độ phân giải được nâng cấp lên đến 48 MP.", null, "https://cdn.tgdd.vn/Products/Images/42/247508/Slider/iphone-14-pro-up-3-new-1933x982.jpg", false, "iPhone 14 Pro", 24990000.0, 10, "Unit" },
                    { new Guid("56510997-8731-4a7a-9542-566baf23d5ab"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("571e031d-fa7e-4fad-9cca-0606bd0347b0"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.", null, "https://cdn.tgdd.vn/Products/Images/42/251192/Slider/iphone-14-pro-max-tong-quan-1020x570.jpg", false, "iPhone 14 Pro Max", 27990000.0, 20, "Unit" },
                    { new Guid("5e115ba0-6993-4fbb-9e4c-494bea33023c"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("966c81bc-ae3e-4c5e-a400-bd0db956a47a"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 128GB được xem là mẫu smartphone bùng nổ của nhà táo trong năm 2022, ấn tượng với ngoại hình trẻ trung, màn hình chất lượng đi kèm với những cải tiến về hệ điều hành và thuật toán xử lý hình ảnh, giúp máy trở thành cái tên thu hút được đông đảo người dùng quan tâm tại thời điểm ra mắt.", null, "https://cdn.tgdd.vn/Products/Images/42/240259/iphone-14-xanh-1.jpg", false, "iPhone 14 ", 19990000.0, 10, "Unit" },
                    { new Guid("af4d081e-6fba-4585-9cc0-9852ce9a7a51"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 5515 R7 (N5R75700U104W1) sẽ là một ứng cử viên sáng giá trong phân khúc laptop học tập - văn phòng bởi lối thiết kế tao nhã, tối giản cùng những thông số kỹ thuật ấn tượng, đáp ứng tốt mọi nhu cầu cơ bản hằng ngày phục vụ cho mọi đối tượng người dùng đặc biệt là học sinh, sinh viên và dân văn phòng.", null, "https://cdn.tgdd.vn/Products/Images/44/267558/Slider/vi-vn-dell-inspiron-15-5515-r7-n5r75700u104w1-1.jpg", false, "Dell Inspiron 15 5515", 17990000.0, 10, "Unit" },
                    { new Guid("b09edc12-eb17-4a71-b776-208e5d84e4b7"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Dell Inspiron 15 3511 i3 (P112F001CBL) sở hữu thiết kế sang trọng, thanh lịch với sức mạnh hiệu năng đến từ dòng chip Intel thế hệ thứ 11 đáp ứng tốt các tác vụ học tập, văn phòng và giải trí cơ bản của người dùng học sinh, sinh viên.", null, "https://cdn.tgdd.vn/Products/Images/44/264370/Slider/vi-vn-dell-inspiron-15-3511-i3-p112f001cbl-1.jpg", false, "Dell Inspiron 15 3511", 12690000.0, 10, "Unit" },
                    { new Guid("b962d70a-9d84-4527-91ed-aafd817ddaba"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Không những mang đến cho người dùng hiệu năng ấn tượng nhờ con chip Intel thế hệ 11 tân tiến cùng card rời RTX 30 series, laptop Dell Gaming G15 5511 i5 11400H (70266676) còn sở hữu thiết kế thời thượng, lôi cuốn, hứa hẹn sẽ là người cộng sự lý tưởng cùng bạn chinh phục mọi chiến trường.", null, "https://cdn.tgdd.vn/Products/Images/44/264354/Slider/dell-gaming-g15-5511-i5-70266676-fix-ab-01-1020x570-2.jpg", false, "Dell Gaming G15 5511 ", 21990000.0, 30, "Unit" },
                    { new Guid("cddf4632-ecb0-4344-8b4c-f61838dad0bd"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "Trong khi sức hút đến từ bộ 4 phiên bản iPhone 12 vẫn chưa nguội đi, thì hãng điện thoại Apple đã mang đến cho người dùng một siêu phẩm mới iPhone 13 với nhiều cải tiến thú vị sẽ mang lại những trải nghiệm hấp dẫn nhất cho người dùng.", null, "https://cdn.tgdd.vn/Products/Images/42/223602/iphone-13-xanh-1.jpg", false, "iPhone 13 ", 17000000.0, 25, "Unit" },
                    { new Guid("d2df3866-7a99-4b44-ba3c-471209927aee"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.", null, "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg", false, "Dell Gaming Alienware m15 R6 ", 47490000.0, 20, "Unit" },
                    { new Guid("d5945a9f-3470-4650-9308-6a31dfbceb3d"), new Guid("04d63fc1-582a-4ad3-9132-b531101220ca"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Khi nhắc đến dòng laptop học tập - văn phòng thì bạn không thể nào bỏ qua laptop Dell Inspiron 16 5620 i7 (N6I7110W1) với hiệu năng vượt trội, thiết kế hiện đại và gọn nhẹ phù hợp với nhu cầu sử dụng của sinh viên và nhân viên văn phòng cần phải di chuyển thường xuyên.", null, "https://cdn.tgdd.vn/Products/Images/44/292396/Slider/vi-vn-dell-inspiron-16-5620-i7-n6i7110w1-1.jpg", false, "Dell Inspiron 16 5620", 21990000.0, 20, "Unit" },
                    { new Guid("daf7c53b-bc42-4b85-9dbd-9aaa1b849907"), new Guid("71d6e1f9-8c22-43e8-ad37-1609dd7bc61e"), new Guid("3f8d98cb-a695-4334-bec2-09008670c39a"), "Laptop Asus Gaming ROG Strix G15 G513IH R7 (HN015W) là một trợ thủ đắc lực cho mọi game thủ chuyên nghiệp với phong cách thiết kế vô cùng độc đáo, ấn tượng chuẩn gaming cùng bộ cấu hình đầy mạnh mẽ. ", null, "https://cdn.tgdd.vn/Products/Images/44/270031/Slider/vi-vn-asus-rog-strix-gaming-g513ih-r7-hn015w-1.jpg", false, "Laptop Asus Gaming ROG Strix G15", 22990000.0, 50, "Unit" },
                    { new Guid("dee5ae9f-6286-470e-8303-e446bf4b5fb6"), new Guid("36326612-2d44-446f-87cd-d060d14237a6"), new Guid("bc17dda5-9e53-434d-ab30-32452bfc7d35"), "iPhone 14 Pro Max 1TB là phiên bản điện thoại cao cấp nhất mà Apple đã cho ra mắt tại sự kiện giới thiệu sản phẩm mới cho năm 2022. Được thừa hưởng mọi công nghệ hàng đầu thế giới nên máy hứa hẹn sẽ mang lại trải nghiệm sử dụng tốt nhất từ chơi game cho tới chụp ảnh, xứng đáng là chiếc điện thoại đáng mua nhất trên thị trường hiện tại.", null, "https://cdn.tgdd.vn/Products/Images/42/289705/iphone-14-pro-max-vang-1.jpg", false, "iPhone 14 Pro Max 1TB", 51990000.0, 10, "Unit" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("13461ff9-0374-4101-a88e-a01dff5f1d8e") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("257c3301-487b-4c18-bc3d-21ffb71a4d43") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("6925f34b-4021-4fe9-9155-88b9e0df0678"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("cd9218db-08c0-4af8-9058-0ac6cf7d58b9"), new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "CustomerId", "OrderId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("5470e410-d659-4cdc-b84b-bb174a67a2bf"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") },
                column: "Date",
                value: new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("58c8e760-f204-4f54-a816-3fe049318279"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 },
                    { new Guid("fdb603af-9227-4df0-8139-fea9d1031854"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), 7250000.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "CustomerId", "OrderId", "ProductId", "Comment", "Date", "Rating" },
                values: new object[,]
                {
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("9ce948f7-9651-4b98-b653-1fc9f17a3bd0"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Product beauty", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7353), 5 },
                    { "04be0c35-571e-425c-992e-15a7227286de", new Guid("f6969601-3fbd-4cd5-b293-7cece012dd26"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "More than expected", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7354), 3 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("352ea23b-fb51-42a1-902d-2742906dcefd"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Wonderful", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7347), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("58c8e760-f204-4f54-a816-3fe049318279"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Comfortable", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7352), 4 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("59c8b598-18a6-4fef-9e84-609ed0b6d65f"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "No problem", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7349), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("90bec7c0-9ccd-40e0-8bff-3d468eca012e"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "Ok", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7348), 5 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("b5efe47f-4e33-43c0-8aea-cc31a15923b7"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "So expensive", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7350), 1 },
                    { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("fdb603af-9227-4df0-8139-fea9d1031854"), new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a"), "worth the money", new DateTime(2023, 9, 25, 14, 31, 26, 926, DateTimeKind.Local).AddTicks(7351), 5 }
                });
        }
    }
}
