using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public class clsClient : clsUser
    {
        private string vRefClient;
        private string vType;
        private string vRefEmployee;
        private string vftName;
        private string vlstName;
        private string vPhone;
        public clsClient(string User, string Password, string Email,string RefClient, string Type, string Phone, string FtName, string LtName,string RefEmployee):
            base(User, Password,Email)
        {
            this.RefClient = RefClient;
            this.Type = Type;
            this.RefEmployee = RefEmployee;
            this.Phone = Phone;
            this.FtName = FtName;
            this.LstName = LtName;
        }
        public string RefClient { get => vRefClient; set => vRefClient = value; }
        public string Type { get => vType; set => vType = value; }
        public string RefEmployee { get => vRefEmployee; set => vRefEmployee = value; }
        public string FtName { get => vftName; set => vftName = value; }
        public string LstName { get => vlstName; set => vlstName = value; }
        public string Phone { get => vPhone; set => vPhone = value; }
    }
}
