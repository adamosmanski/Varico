using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.EF.Models;

namespace Varico.Core.CQRS.CarModule
{
    public class SearchVehiclesQuery : IRequest<List<Vehicle>>
    {
        public string Brand { get; set; }
    }
    public class SearchVehiclesQueryHandler : IRequestHandler<SearchVehiclesQuery, List<Vehicle>>
    {
        private readonly VaricoDbContext _context;

        public SearchVehiclesQueryHandler(VaricoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vehicle>> Handle(SearchVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.Brand.Contains(request.Brand))
                .ToListAsync(cancellationToken);

            return vehicles;
        }
    }
}
