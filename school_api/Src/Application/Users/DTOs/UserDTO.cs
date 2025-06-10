
using school_api.Src.Application.Common.DTOs;

namespace school_api.Src.Application.Users.DTOs
{


    public class RegisterStudentDTO : BaseUserDTO
    {
        public required int CareerId { get; set; }
    }


    public class RegisterTeacherDTO : BaseUserDTO
    {
        public required string Title { get; set; }
        public required string Speciality { get; set; }
    }


    
}