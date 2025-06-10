
namespace school_api.Src.Application.Common.DTOs
{


    public class HashResult
    {
        public required byte[] Hash { get; set; }
        public required byte[] Salt { get; set; }
    }


    public class VerifyHash
    {
        public required string Password { get; set; }
        public required byte[] Hash { get; set; }
        public required byte[] Salt { get; set; }
    }
}