
using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;
using school_api.Src.Application.Common.DTOs;
using school_api.Src.Application.Common.Interfaces;


namespace school_api.Src.Application.Common.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {

        private const int _SaltSize = 16;
        private const int _HashSize = 32;
        private const int _MemorySize = 1024 * 1024;


        public byte[] GenerateSalt()
        {
            byte[] salt = RandomNumberGenerator.GetBytes(_SaltSize);
            return salt;
        }


        private byte[] HashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                MemorySize = _MemorySize,
            };

            return argon2.GetBytes(_HashSize);
        }


        public HashResult HashPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] hash = HashPassword(password, salt);

            return new HashResult { Salt = salt, Hash = hash };
        }


        public bool Verify(VerifyHash verify)
        {
            byte[] newHash = HashPassword(verify.Password, verify.Salt);

            return CryptographicOperations.FixedTimeEquals(newHash, verify.Hash);
        }
        

    }
}