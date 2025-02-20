using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Varico.Core.CQRS.UserModule;
using Varico.Core.Services.PasswordService;
using Varico.EF.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        var user = await _mediator.Send(command);
        return Ok(new { message = "Użytkownik zarejestrowany pomyślnie!", user });
    }

    [HttpGet("getUser/{email}")]
    public async Task<IActionResult> GetUserByMail(string email)
    {
        var user = await _mediator.Send(new GetUserByEmailQuery(email));
        if (user == null)
        {
            return NotFound(new { message = "Użytkownik nie znaleziony" });
        }
        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
    {
        var isValidUser = await _mediator.Send(command);

        if (!isValidUser)
        {
            return Unauthorized(new { message = "Nieprawidłowy email lub hasło." });
        }

        return Ok(new { message = "Zalogowano pomyślnie." });
    }
}
