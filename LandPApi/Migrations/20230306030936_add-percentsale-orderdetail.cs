using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandPApi.Migrations
{
    /// <inheritdoc />
    public partial class addpercentsaleorderdetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PercentSale",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentSale",
                table: "OrderDetails");
        }
    }
}
