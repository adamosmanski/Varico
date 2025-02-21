using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varico.EF.Models
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid,
        Gas
    }
    public enum VehicleType
    {
        Passenger,
        Truck,
        Motorcycle
    }

    public enum BodyType
    {
        SUV,
        HATCHBACK,
        SEDAN,
        KOMBI,
        ANOTHER
    }
    public enum TransmissionType
    {
        Manual,
        Automatic
    }
    public enum DrivetrainType
    {
        FWD,
        RWD,
        AWD //4x4
    }
}
