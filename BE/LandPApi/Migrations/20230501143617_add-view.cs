using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b2cf83-d597-4964-b65b-84c9c09b3574", "AQAAAAEAACcQAAAAENo8SoMwhFOCh+VaOENsJVB1UMshQWMCkM4tfblJFEuvlpZfEAWy5Q0QTI+Uz2zxbw==", "b74e7226-51e7-4689-82c8-feed61033c14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e517687b-99d1-4771-80f9-bb4486fb4caf", "AQAAAAEAACcQAAAAEMZPrhHQZwf8e6EYkFhER4UTbVEudSaViWD8yH1XXKM91K+eKSGTbpk6zCEuCRpsJw==", "5e4e9d40-26b5-4e1c-8b24-156be2e5e9fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f19ce246-dfd0-4e26-a67e-bbc9e76f2049", "AQAAAAEAACcQAAAAENwRIhtuhWNMvabl71Bt4/wAhJwhtPLI6oRYv0SWqsEyGHQ461Wx53p8udV5bKE7qA==", "369e7459-d3ea-404e-ae2a-73ccc03fff99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab791eb-e17c-4282-9460-f80482731881", "AQAAAAEAACcQAAAAEFjFIl2vGEb/ZxuvkDYaiK9bVSBjwCyR2Hrva6slAhruJrOqLjDGiDDhQ4JB5Momxw==", "bd246bb7-f36d-423a-9712-f8dfaffb9cd3" });

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.InsertData(
                table: "Views",
                columns: new[] { "CustomerId", "ProductId", "Date" },
                values: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04"), new DateTime(2023, 5, 1, 21, 36, 17, 92, DateTimeKind.Local).AddTicks(8171) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("d01f7780-5cdd-4ff0-b6db-947a1f3d3f04") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04be0c35-571e-425c-992e-15a7227286de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da6556a-5778-4c3a-ae00-960ca521cffb", "AQAAAAEAACcQAAAAEJGoaDPpPhKjf42U0N6d9UwdFL4yU2N6NqgNFrck1PTkpKu1G7Z+trim97EkX8zkXA==", "b43638bf-a2ce-4a0d-b553-40a00fd5bc1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b0b163d-032f-4e19-9e64-d89bf02f1751",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1fdde2b-9795-47ce-a7ac-fda0cf1a6fa6", "AQAAAAEAACcQAAAAEO+77BNFXVNIkpSWvT3bzihS0/2AMZC6sWzl3+Dy0AJ9fREQoU3KU4qb1Z++aA1m5A==", "5db6b399-27dc-4265-95a5-cffab17096d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289f6c6a783e4d89b25c847d1ffa4833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ba8a3ff-9590-4cdc-b6b1-2cfdf0f591b0", "AQAAAAEAACcQAAAAEIwVkmJFIPNbqt/UX29lekU4dvunqfRF6Jmfg8MeA4Ampol1v/KEZwFyt67x5EGvIQ==", "4c8dcec3-2fbc-459f-bc7e-62410ed64b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd8d30-85af-4960-8a9f-d7f7eeeb8571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6bd232-26ae-4452-a17a-33da004c8ffa", "AQAAAAEAACcQAAAAECTDzCHU56rqsE9TmmRWGpUNdtPPHLVMiQAPRE1T7hzpNx2kYlYM4V/sh34ui+YMow==", "29faf268-ab00-49d1-9b4d-2f5221d4d61f" });

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 32, 25, 848, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "04be0c35-571e-425c-992e-15a7227286de", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 32, 25, 848, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("13c2386e-1348-42ef-8de1-46d7515eb3df") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 32, 25, 848, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("7d7b21dd-b2fe-4179-8238-e871f52fcb2a") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 32, 25, 848, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Views",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { "1b0b163d-032f-4e19-9e64-d89bf02f1751", new Guid("c2c75508-8eac-47de-a3fa-43c44ce8e917") },
                column: "Date",
                value: new DateTime(2023, 5, 1, 21, 32, 25, 848, DateTimeKind.Local).AddTicks(4556));
        }
    }
}
