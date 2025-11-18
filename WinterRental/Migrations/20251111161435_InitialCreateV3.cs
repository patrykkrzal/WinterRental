using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinterRental.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalInfoId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RentalInfoId",
                table: "Orders",
                column: "RentalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_RentalInfo_RentalInfoId",
                table: "Orders",
                column: "RentalInfoId",
                principalTable: "RentalInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_RentalInfo_RentalInfoId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RentalInfoId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RentalInfoId",
                table: "Orders");
        }
    }
}
