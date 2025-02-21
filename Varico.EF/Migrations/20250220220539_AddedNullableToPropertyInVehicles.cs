using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedNullableToPropertyInVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "ReservedById",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles",
                column: "ReservedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "ReservedById",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles",
                column: "ReservedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
