using MediatR;
using Microsoft.AspNetCore.Mvc;
using Varico.Core.CQRS.CarModule;

namespace Varico.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VehiclesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("getAllVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var vehicles = await _mediator.Send(new GetAllVehicleQuery());
            return Ok(vehicles);
        }
    }
}
