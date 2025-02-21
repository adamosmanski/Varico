using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Varico.Core.CQRS.CarModule;
using Varico.Core.CQRS.UserModule;
using Varico.EF.Models;

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
        [HttpPost("reserveVehicle")]
        public async Task<IActionResult> ReserveVehicle([FromBody] VehicleReservationRequest request)
        {
            var result = await _mediator.Send(request);

            if (result.Success)
            {
                return Ok(new { message = result.Message });
            }

            return BadRequest(new { message = result.Message });
        }
        [HttpGet("reserved")]
        public async Task<IActionResult> GetReservedVehicles([FromQuery] int userId)
        {
            var query = new GetAllVehicleNotAvailableQuery(userId);
            var vehicles = await _mediator.Send(query);
            return Ok(vehicles);
        }
        [HttpPatch("returnReservedVehicle")]
        public async Task<IActionResult> ReturnReservedVehicle([FromBody] ReturnVehicleCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpGet("search")]
        public async Task<ActionResult<List<Vehicle>>> SearchVehicles([FromQuery] string Brand)
        {
            var vehicles = await _mediator.Send(new SearchVehiclesQuery { Brand = Brand });
            return Ok(vehicles);
        }
    }
}