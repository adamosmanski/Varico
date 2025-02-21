using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTablesCarsForVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_ReservedById",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cars_CarId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ReservedById",
                table: "Vehicles",
                newName: "IX_Vehicles_ReservedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Vehicles_CarId",
                table: "Users",
                column: "CarId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles",
                column: "ReservedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Vehicles_CarId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_ReservedById",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ReservedById",
                table: "Cars",
                newName: "IX_Cars_ReservedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_ReservedById",
                table: "Cars",
                column: "ReservedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cars_CarId",
                table: "Users",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
