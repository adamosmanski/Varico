using MediatR;
using Varico.Core.CQRS.UserModule;
using Varico.EF.Models;

namespace Varico.Core.CQRS.UserModule
{
    public class VehicleReservationRequest : IRequest<Result>
    {
        public int VehicleId { get; set; }
        public string ReservedFrom { get; set; }
        public string ReservedTo { get; set; }
        public int UserId { get; set; }
    }
}
public class Result
{
    public bool Success { get; set; }
    public string Message { get; set; }
}

public class ReserveVehicleHandler : IRequestHandler<VehicleReservationRequest, Result>
{
    private readonly VaricoDbContext _context;

    public ReserveVehicleHandler(VaricoDbContext context)
    {
        _context = context;
    }

    public async Task<Result> Handle(VehicleReservationRequest request, CancellationToken cancellationToken)
    {
        var vehicle = await _context.Vehicles.FindAsync(request.VehicleId);

        if (vehicle == null)
        {
            return new Result
            {
                Success = false,
                Message = "Pojazd nie znaleziony."
            };
        }

        if (vehicle.Availability == false)
        {
            return new Result
            {
                Success = false,
                Message = "Pojazd jest już zarezerwowany."
            };
        }

        vehicle.DateStart = DateOnly.Parse(request.ReservedFrom);
        vehicle.DateEnd = DateOnly.Parse(request.ReservedTo);
        vehicle.ReservedById = request.UserId;
        vehicle.Availability = false;

        _context.Vehicles.Update(vehicle);
        await _context.SaveChangesAsync();

        return new Result
        {
            Success = true,
            Message = "Pojazd zarezerwowany pomyślnie."
        };
    }
}