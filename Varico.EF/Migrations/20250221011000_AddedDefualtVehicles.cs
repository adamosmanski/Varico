using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefualtVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 6.5, 2.0, 240.0, 12000.0, 150000m, null, 1, 480.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acceleration", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 9.1999999999999993, 1.6000000000000001, 1, 210.0, 75000.0, 45000m, null, 370.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 7.0, 1.5, 220.0, 120000m, null, 1, 300.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 9.5, 1, 2.2999999999999998, 1, 190.0, 15000.0, 220000m, null, 1200.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "MaxSpeed", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 6.0, 2, 2.0, 240.0, 250000m, null, 1, 550.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Acceleration", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 7.7999999999999998, 2.5, 3, 200.0, 5000.0, 180000m, null, 1, 450.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 9.9000000000000004, 1.0, 205.0, 65000.0, 47000m, null, 370.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 2.7999999999999998, 1.0, 300.0, 5000.0, 23000m, null, 30.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 2.6000000000000001, 1.0, 310.0, 3500.0, 25000m, null, 30.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Acceleration", "Brand", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Model", "PictureURL", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 2.6000000000000001, "CBR1000RR-R Fireblade", 2.0, 4, 450.0, 100.0, " SP Carbon Edition", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/supersports/cbr1000rr-r/cbr1000rr-r_sp_carbon_2024/nh-c33p_mattepearlmorionblack/24YM_CBR1000RR-R_FIREBLADE_Studio_MAT_PEARL_MORION_BLACK_SP_Carbon_Edition_RHS.png/jcr:content/renditions/fb_r_w.webp", 25000m, null, 45.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Acceleration", "BodyType", "Brand", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Model", "PictureURL", "Price", "ProductionYear", "ReservedById", "Transmission", "TrunkCapacity", "VehicleType" },
                values: new object[] { 8.1999999999999993, 2, "Toyota", 1.8, 3, 200.0, 10000.0, "Corolla", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 90000m, 2023, null, 1, 470.0, 0 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Acceleration", "Availability", "BodyType", "Brand", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Model", "PictureURL", "Price", "ProductionYear", "ReservedById", "Transmission", "TrunkCapacity", "VehicleType" },
                values: new object[,]
                {
                    { 12, 9.0, true, 1, "Volkswagen", 0, 1.5, 0, 210.0, 20000.0, "Golf", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 80000m, 2022, null, 0, 380.0, 0 },
                    { 13, 7.5, true, 2, "Audi", 2, 2.0, 1, 240.0, 15000.0, "A4", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 170000m, 2021, null, 1, 480.0, 0 },
                    { 14, 8.8000000000000007, true, 3, "Skoda", 0, 1.6000000000000001, 0, 220.0, 5000.0, "Octavia", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 95000m, 2024, null, 1, 600.0, 0 },
                    { 15, 9.5, true, 1, "Peugeot", 0, 1.2, 0, 205.0, 12000.0, "308", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 70000m, 2023, null, 0, 340.0, 0 },
                    { 16, 9.0, true, 0, "Kia", 2, 1.6000000000000001, 1, 210.0, 8000.0, "Sportage", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 130000m, 2024, null, 1, 520.0, 0 },
                    { 17, 6.7999999999999998, true, 0, "Volvo", 2, 2.0, 0, 230.0, 0.0, "XC60", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 240000m, 2025, null, 1, 505.0, 0 },
                    { 18, 8.1999999999999993, true, 0, "Mazda", 2, 2.5, 0, 220.0, 10000.0, "CX-5", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 140000m, 2023, null, 1, 510.0, 0 },
                    { 19, 9.5, true, 0, "Nissan", 0, 1.3, 0, 210.0, 5000.0, "Qashqai", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 110000m, 2024, null, 1, 430.0, 0 },
                    { 20, 8.5, true, 0, "Hyundai", 2, 1.6000000000000001, 3, 220.0, 0.0, "Tucson", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 150000m, 2025, null, 1, 540.0, 0 },
                    { 21, 4.5, true, 3, "Ford", 1, 5.0, 0, 250.0, 0.0, "Mustang", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 300000m, 2024, null, 1, 380.0, 0 },
                    { 22, 4.2000000000000002, true, 1, "Chevrolet", 1, 6.2000000000000002, 0, 260.0, 5000.0, "Camaro", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 280000m, 2023, null, 1, 340.0, 0 },
                    { 23, 3.1000000000000001, true, 2, "Tesla", 2, 0.0, 2, 260.0, 0.0, "Model 3", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 220000m, 2024, null, 1, 425.0, 0 },
                    { 24, 3.5, true, 1, "Porsche", 1, 3.0, 0, 300.0, 0.0, "911", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 500000m, 2025, null, 1, 280.0, 0 },
                    { 25, 12.0, true, 1, "Fiat", 0, 1.2, 0, 180.0, 15000.0, "500", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 60000m, 2023, null, 0, 185.0, 0 },
                    { 26, 8.0, true, 0, "Jeep", 2, 2.0, 0, 200.0, 0.0, "Wrangler", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 200000m, 2024, null, 1, 270.0, 0 },
                    { 27, 6.5, true, 0, "Land Rover", 2, 3.0, 1, 220.0, 0.0, "Defender", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 350000m, 2025, null, 1, 550.0, 0 },
                    { 28, 8.0, true, 3, "Subaru", 2, 2.5, 0, 210.0, 5000.0, "Outback", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 160000m, 2024, null, 1, 580.0, 0 },
                    { 29, 7.0, true, 0, "Lexus", 2, 3.5, 3, 230.0, 0.0, "RX", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 300000m, 2025, null, 1, 520.0, 0 },
                    { 30, 8.0, true, 2, "Honda", 0, 1.5, 0, 210.0, 0.0, "Civic", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 100000m, 2024, null, 1, 420.0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0m, 0, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acceleration", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0.0, 0m, 0, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acceleration", "Drivetrain", "EngineCapacity", "MaxSpeed", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0, 0.0, 0.0, 0m, 0, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Acceleration", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Price", "ReservedById", "Transmission", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0, 0.0, 0.0, 0m, 0, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Acceleration", "EngineCapacity", "MaxSpeed", "Mileage", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Acceleration", "Brand", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Model", "PictureURL", "Price", "ReservedById", "TrunkCapacity" },
                values: new object[] { 0.0, "CRF450R", 0.0, 0, 0.0, 0.0, "2025", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp", 0m, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Acceleration", "BodyType", "Brand", "EngineCapacity", "FuelType", "MaxSpeed", "Mileage", "Model", "PictureURL", "Price", "ProductionYear", "ReservedById", "Transmission", "TrunkCapacity", "VehicleType" },
                values: new object[] { 0.0, 4, "CRF450R", 0.0, 0, 0.0, 0.0, "2024", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp", 0m, 2025, 0, 0, 0.0, 2 });
        }
    }
}
