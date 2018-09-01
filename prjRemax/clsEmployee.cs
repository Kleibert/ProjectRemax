using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
    public class clsEmployee : clsUser
    {
        private string vRefEmployee;
        private string vRefCompany;
        private string vPhone;
        private string vPoste;
        private string vftName;
        private string vlstName;
        public clsEmployee():base()
         {
            RefEmployee = "Undefined";
            Poste = "Undefined";
            RefCompany = "Undefined";
            Phone = "Undefined";
            FtName = "Undefined";
            LstName = "Undefined";
        }
        public clsEmployee(string User, string Password, string Email,
            string RefEmployee, string Poste, string Company, string Phone, string FtName,string LtName ) : base(User, Password,Email)
        {
            this.RefEmployee = RefEmployee;
            this.Poste = Poste;
            this.RefCompany = Company;
            this.Phone = Phone;
            this.FtName = FtName;
            this.LstName = LtName;
        }
        public string RefEmployee { get => vRefEmployee; set => vRefEmployee = value; }
        public string RefCompany { get => vRefCompany; set => vRefCompany = value; }
        public string Phone { get => vPhone; set => vPhone = value; }
        public string Poste { get => vPoste; set => vPoste = value; }
        public string FtName { get => vftName; set => vftName = value; }
        public string LstName { get => vlstName; set => vlstName = value; }
    }
}
