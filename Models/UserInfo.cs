using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Login.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string EmailField { get; set; }
        public string PasswordField { get; set; }
        public string NameField { get; set; }
        public int AgeField { get; set; }
        public string CreationDate { get; set; }
    }
}
