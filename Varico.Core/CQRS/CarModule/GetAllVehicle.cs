using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.EF.Models;

namespace Varico.Core.CQRS.CarModule
{
    public record GetAllVehicleQuery() : IRequest<IEnumerable<Vehicle>>;
    public class GetAllVehicleHandler : IRequestHandler<GetAllVehicleQuery, IEnumerable<Vehicle>>
    {
        private readonly VaricoDbContext _context;
        public GetAllVehicleHandler(VaricoDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Vehicle>> Handle(GetAllVehicleQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await _context.Vehicles.Where(x=>x.Availability == true).ToListAsync(cancellationToken);
            return vehicles;
        }
    }

    public class GetAllVehicleNotAvailableQuery : IRequest<IEnumerable<Vehicle>>
    {
        public int UserId { get; set; }
        public GetAllVehicleNotAvailableQuery(int userId)
        {
            UserId = userId;
        }
    }

    public class GetAllVehicleNotAvailableHandler : IRequestHandler<GetAllVehicleNotAvailableQuery, IEnumerable<Vehicle>>
    {
        private readonly VaricoDbContext _context;
        public GetAllVehicleNotAvailableHandler(VaricoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vehicle>> Handle(GetAllVehicleNotAvailableQuery request, CancellationToken cancellationToken)
        {
           
            var vehicles = await _context.Vehicles
                .Where(x => x.ReservedById == request.UserId && x.Availability == false)
                .ToListAsync(cancellationToken);
            return vehicles;
        }
    }
}
