using MediatR;
using Varico.Core.Services.PasswordService;
using Varico.EF.Models;

namespace Varico.Core.CQRS.UserModule
{
    public record CreateUserCommand(
        string FirstName,
        string LastName,
        string Email,
        string Password,
        string Phone,
        string Street,
        string City,
        string PostalCode,
        string Country
    ) : IRequest<Users>;

    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Users>
    {
        private readonly VaricoDbContext _context;
        private readonly IPasswordService _passwordService;

        public CreateUserHandler(VaricoDbContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<Users> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Users
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Street = request.Street,
                City = request.City,
                PostalCode = request.PostalCode,
                Country = request.Country,
                Password = _passwordService.HashPassword(request.Password),
                Car = null
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}
