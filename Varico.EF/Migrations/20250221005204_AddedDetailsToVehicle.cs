using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedDetailsToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Acceleration",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Drivetrain",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "EngineCapacity",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "FuelType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MaxSpeed",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Mileage",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Transmission",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TrunkCapacity",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acceleration",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Drivetrain",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MaxSpeed",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TrunkCapacity",
                table: "Vehicles");
        }
    }
}
