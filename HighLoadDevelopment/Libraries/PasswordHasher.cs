using HighLoadDevelopment.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HighLoadDevelopment.Libraries
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password) // 123, 321123
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA384);
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword, BCrypt.Net.HashType.SHA384);
        }
    }
}
