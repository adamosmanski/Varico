namespace Varico.Core.Services.PasswordService
{
    public interface IPasswordService
    {
        public bool VerifyPassword(string password, string hash);
        public string HashPassword(string password);
    }
}
