using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces
{
    public interface IAuthService
    {
        bool Register(UserRegisterDTO dto);
        bool Login(UserLoginDTO dto);
    }
}
