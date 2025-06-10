
using school_api.Src.Application.Common.DTOs;

namespace school_api.Src.Application.Common.Interfaces
{
    public interface IPasswordHasherService
    {
        byte[] GenerateSalt();
        HashResult HashPassword(string password);
        bool Verify(VerifyHash verify);
    }
}