using Microsoft.EntityFrameworkCore;
using System;

namespace Varico.EF.Models
{
    public class VaricoDbContext : DbContext
    {
        public VaricoDbContext(DbContextOptions<VaricoDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }


        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cars = new List<Vehicle>
            {
                new Vehicle
                {
                    Id = 1,
                    Brand = "BMW",
                    Model = "Seria 5",
                    ProductionYear = 2020,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.SEDAN,
                    Availability = true,
                    ReservedById = 0,
                    PictureURL = "https://superauto.wpcdn.pl/offer_photos/thumb/767x511_fit_in_27184e1f028225b5d6a8330cad59d18d.jpg"
                },
                new Vehicle
                {
                    Id = 2,
                    Brand = "Jaecoo 7",
                    Model = "1.6 T-GDI Urban DCT",
                    ProductionYear = 2015,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.HATCHBACK,
                    Availability = true,
                    ReservedById = 0,
                    PictureURL = "https://superauto.wpcdn.pl/offer_photos/thumb/767x511_fit_in_c8af3789e35cfe931acb4dc341a879d8.jpg"
                },
                new Vehicle
                {
                    Id = 3,
                    Brand = "MG 3",
                    Model = "A3",
                    ProductionYear = 2024,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.HATCHBACK,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511"
                },
                new Vehicle
                {
                    Id = 4,
                    Brand = "Renault Trafic",
                    Model = "Kombi L2H1",
                    ProductionYear = 2025,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.KOMBI,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.superauto.pl/file/2611717/3bbd42a17213074b29b6018891029b448b4a8aff-2-767x511"
                },
                new Vehicle
                {
                    Id = 5,
                    Brand = "Mercedes GLC",
                    Model = "300 e 4-Matic AMG Line",
                    ProductionYear = 2025,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.SUV,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.superauto.pl/file/2610911/7ac4af13e602fb674531f7a8580ea8899e02f1e0-2-767x511"
                },
                new Vehicle
                {
                    Id = 6,
                    Brand = "Ford Kuga",
                    Model = "2.5 FHEV FWD Titanium",
                    ProductionYear = 2024,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.SEDAN,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.superauto.pl/file/2415504/5f0f81a650763a1f3b22267f36c7a8f6bb52d1bb-2-767x511"
                },
                new Vehicle
                {
                    Id = 7,
                    Brand = "Hyundai I30",
                    Model = "1.0 T-GDI Smart",
                    ProductionYear = 2019,
                    VehicleType = VehicleType.Passenger,
                    BodyType = BodyType.KOMBI,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.superauto.pl/file/2582987/ccd85d30c20bf1eae1f47a1e8ba097e40dde6524-2-767x511"
                },
                new Vehicle
                {
                    Id = 8,
                    Brand = "CBR1000RR-R Fireblade",
                    Model = " SP 2024 (model 2024)",
                    ProductionYear = 2024,
                    VehicleType = VehicleType.Motorcycle,
                    BodyType = BodyType.ANOTHER,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/supersports/cbr1000rr-r/cbr1000rr-r_sp_2024/r-380_grandprixred/24YM_CBR1000RR-R_FIREBLADE_Studio_GRAND_PRIX_RED_SP_RHS.png/jcr:content/renditions/fb_r_w.webp"
                },
                new Vehicle
                {
                    Id = 9,
                    Brand = "CBR1000RR-R Fireblade",
                    Model = " SP Carbon Edition",
                    ProductionYear = 2025,
                    VehicleType = VehicleType.Motorcycle,
                    BodyType = BodyType.ANOTHER,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/supersports/cbr1000rr-r/cbr1000rr-r_sp_carbon_2024/nh-c33p_mattepearlmorionblack/24YM_CBR1000RR-R_FIREBLADE_Studio_MAT_PEARL_MORION_BLACK_SP_Carbon_Edition_RHS.png/jcr:content/renditions/fb_r_w.webp"
                },
                new Vehicle
                {
                    Id = 10,
                    Brand = "CRF450R",
                    Model = "2025",
                    ProductionYear = 2025,
                    VehicleType = VehicleType.Motorcycle,
                    BodyType = BodyType.ANOTHER,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp"
                },
                new Vehicle
                {
                    Id = 11,
                    Brand = "CRF450R",
                    Model = "2024",
                    ProductionYear = 2025,
                    VehicleType = VehicleType.Motorcycle,
                    BodyType = BodyType.ANOTHER,
                    Availability = true,
                    ReservedById = 0, 
                    PictureURL = "https://www.honda.pl/content/dam/central/motorcycles/colour-picker/off-road/crf450r/crf450r_2023/r-292r_extreme_red/crf450r_2023_r-292r_extreme_red.png/jcr:content/renditions/fb_r_w.webp"
                },
            };
            modelBuilder.Entity<Vehicle>().HasData(cars);
            modelBuilder.Entity<Vehicle>()
                .HasOne(c => c.ReservedBy)
                .WithMany()
                .HasForeignKey(c => c.ReservedById);

            base.OnModelCreating(modelBuilder);
        }
    }
}