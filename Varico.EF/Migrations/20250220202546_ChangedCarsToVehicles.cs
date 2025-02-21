using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCarsToVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReservedById",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Availability", "BodyType", "Brand", "Model", "PictureURL", "ProductionYear", "ReservedById", "VehicleType" },
                values: new object[,]
                {
            { 1, true, 2, "BMW", "Seria 5", "https://superauto.wpcdn.pl/offer_photos/thumb/767x511_fit_in_27184e1f028225b5d6a8330cad59d18d.jpg", 2020, null, 0 },
            { 2, true, 1, "Jaecoo 7", "1.6 T-GDI Urban DCT", "https://superauto.wpcdn.pl/offer_photos/thumb/767x511_fit_in_c8af3789e35cfe931acb4dc341a879d8.jpg", 2015, null, 0 },
            { 3, true, 1, "MG 3", "A3", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 2024, null, 0 },
            { 4, true, 3, "Renault Trafic", "Kombi L2H1", "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511", 2025, null, 0 },
            { 5, true, 0, "Mercedes GLC", "300 e 4-Matic AMG Line", "https://www.superauto.pl/file/2610911/7ac4af13e602fb674531f7a8580ea8899e02f1e0-2-767x511", 2025, null, 0 },
            { 6, true, 2, "Ford Kuga", "2.5 FHEV FWD Titanium", "https://www.superauto.pl/file/2415504/5f0f81a650763a1f3b22267f36c7a8f6bb52d1bb-2-767x511", 2024, null, 0 },
            { 7, true, 3, "Hyundai I30", "1.0 T-GDI Smart", "https://www.superauto.pl/file/2582987/ccd85d30c20bf1eae1f47a1e8ba097e40dde6524-2-767x511", 2019, null, 0 },
            { 8, true, 4, "CBR1000RR-R Fireblade", " SP 2024 (model 2024)", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/supersports/cbr1000rr-r/cbr1000rr-r_sp_2024/r-380_grandprixred/24YM_CBR1000RR-R_FIREBLADE_Studio_GRAND_PRIX_RED_SP_RHS.png/jcr:content/renditions/fb_r_w.webp", 2024, null, 2 },
            { 9, true, 4, "CBR1000RR-R Fireblade", " SP Carbon Edition", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/supersports/cbr1000rr-r/cbr1000rr-r_sp_carbon_2024/nh-c33p_mattepearlmorionblack/24YM_CBR1000RR-R_FIREBLADE_Studio_MAT_PEARL_MORION_BLACK_SP_Carbon_Edition_RHS.png/jcr:content/renditions/fb_r_w.webp", 2025, null, 2 },
            { 10, true, 4, "CRF450R", "2025", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp", 2025, null, 2 },
            { 11, true, 4, "CRF450R", "2024", "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp", 2025, null, 2 }
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
