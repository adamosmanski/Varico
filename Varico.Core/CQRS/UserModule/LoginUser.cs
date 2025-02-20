using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.Core.Services.PasswordService;
using Varico.EF.Models;

namespace Varico.Core.CQRS.UserModule
{
    public class LoginUserCommand : IRequest<bool>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }

    public class LoginUserHandler : IRequestHandler<LoginUserCommand, bool>
    {
        private readonly VaricoDbContext _context;
        private readonly IPasswordService _passwordService;

        public LoginUserHandler(VaricoDbContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<bool> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);
            if (user == null) return false;

            return _passwordService.VerifyPassword(request.Password, user.Password);
        }
    }
}
