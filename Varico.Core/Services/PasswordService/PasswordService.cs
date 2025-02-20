using Varico.Core.Services.PasswordService;

namespace Varico.Core.Services.PasswordService
{
    public class PasswordService : IPasswordService
    {
        public string HashPassword(string  password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
