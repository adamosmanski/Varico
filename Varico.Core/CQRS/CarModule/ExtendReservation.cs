using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.EF.Models;

namespace Varico.Core.CQRS.CarModule
{
    public class ExtendReservationCommand : IRequest<bool>
    {
        public int VehicleId { get; set; }

        public ExtendReservationCommand(int vehicleId)
        {
            VehicleId = vehicleId;
        }
    }

    public class ExtendReservationCommandHandler : IRequestHandler<ExtendReservationCommand, bool>
    {
        private readonly VaricoDbContext _context;

        public ExtendReservationCommandHandler(VaricoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ExtendReservationCommand request, CancellationToken cancellationToken)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);

            var reservation = await _context.Vehicles
                .FirstOrDefaultAsync(r => r.Id == request.VehicleId && r.DateEnd >= today, cancellationToken);

            if (reservation == null)
            {

                return false;
            }

            reservation.DateEnd = reservation.DateEnd.Value.AddDays(7);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
