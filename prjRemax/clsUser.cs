using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public  abstract class clsUser
    {
        private string vUser;
        private string vPassword;
        private string vEmail;
        public clsUser()
        {
            User = "Undefined";
            Password = "Undefined";
            Email = "Undefined";
        }
        public clsUser(string User, string Password, string Email)
        {
            this.User = User;
            this.Password = Password;
            this.Email = Email;
        }
        public string User { get => vUser; set => vUser = value; }
        public string Password { get => vPassword; set => vPassword = value; }
        public string Email { get => vEmail; set => vEmail = value; }
    }
}
