using MediatR;
using Microsoft.EntityFrameworkCore;
using Varico.EF.Models;

namespace Varico.Core.CQRS.UserModule
{
    public record GetUserByEmailQuery(string Email) : IRequest<Users>;
    public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailQuery, Users>
    {
        private readonly VaricoDbContext _context;
        public GetUserByEmailHandler(VaricoDbContext context)
        {
            _context = context;
        }
        public async Task<Users> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);
        }
    }
}
