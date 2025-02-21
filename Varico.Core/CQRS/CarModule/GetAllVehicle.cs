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
            var vehicles = await _context.Vehicles.ToListAsync(cancellationToken);
            return vehicles;
        }
    }
}
