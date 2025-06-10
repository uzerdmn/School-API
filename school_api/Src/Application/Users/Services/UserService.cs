
using school_api.Src.Application.Common.Interfaces;
using school_api.Src.Application.Common.DTOs;
using school_api.Src.Application.Users.DTOs;
using school_api.Src.Core.Entities;

namespace school_api.Src.Application.Users.Services
{
    public class UserService
    {

        private readonly IPasswordHasherService _passwordHasher;

        public UserService(IPasswordHasherService passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }


        public async Task CreateStudent(RegisterStudentDTO student)
        {
            User user = new User
            {
                Name = student.Name,
                Surnames = student.Surnames,
                Email = student.Email,
                Enrollment = student.Enrollment,
                Password = student.Password,
            };

            HashResult hashResult = _passwordHasher.HashPassword(user.Password);
            user.PromoteToStudent(student.CareerId);
            user.SetHash(hashResult.Hash, hashResult.Salt);
        }
    }
}