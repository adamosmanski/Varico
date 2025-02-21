using MediatR;
using Varico.EF.Models;

namespace Varico.Core.CQRS.CarModule
{
    public class ReturnVehicleCommand : IRequest<Unit>
    {
        public int VehicleId { get; set; }

        public ReturnVehicleCommand(int vehicleId)
        {
            VehicleId = vehicleId;
        }
    }

    public class ReturnVehicleHandler : IRequestHandler<ReturnVehicleCommand, Unit>
    {
        private readonly VaricoDbContext _context;

        public ReturnVehicleHandler(VaricoDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ReturnVehicleCommand request, CancellationToken cancellationToken)
        {
            var vehicle = await _context.Vehicles.FindAsync(request.VehicleId);
            if (vehicle == null)
            {
                throw new KeyNotFoundException("Pojazd nie został znaleziony.");
            }
            vehicle.Availability = true;
            vehicle.DateStart = null;
            vehicle.DateEnd = null;
            vehicle.ReservedById = null;
            vehicle.ReservedBy = null;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
