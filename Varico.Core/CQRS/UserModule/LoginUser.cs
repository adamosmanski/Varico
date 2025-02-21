using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.Core.Services.PasswordService;
using Varico.EF.Models;

namespace Varico.Core.CQRS.UserModule
{
    public class LoginUserCommand : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
    public class LoginResponse
    {
        public bool IsValid { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
    }
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, LoginResponse>
    {
        private readonly VaricoDbContext _context;
        private readonly IPasswordService _passwordService;

        public LoginUserHandler(VaricoDbContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<LoginResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);

            if (user == null)
            {
                return new LoginResponse
                {
                    IsValid = false,
                    Message = "Nieprawidłowy email lub hasło."
                };
            }

            var isPasswordValid = _passwordService.VerifyPassword(request.Password, user.Password);

            if (!isPasswordValid)
            {
                return new LoginResponse
                {
                    IsValid = false,
                    Message = "Nieprawidłowy email lub hasło."
                };
            }

            return new LoginResponse
            {
                IsValid = true,
                UserId = user.Id,
                Message = "Zalogowano pomyślnie."
            };
        }
    }

}
