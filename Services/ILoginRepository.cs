using FL.Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Login.Services
{
    public interface ILoginRepository
    {
        Task<UserInfo> Login(string EmailField, string PasswordField);
    }
}
