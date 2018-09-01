using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public class clsCompany
    {
        
        private clsListEmployee vEmployee;
        private clsListClient vCliente;
        private clsListHouse vHouse;

        public clsCompany(clsListEmployee Employee,clsListClient Client, clsListHouse House)
        {
            this.VEmployee = Employee;
            this.Cliente = Client;
            this.House = House;
        }
       public clsListEmployee VEmployee { get => vEmployee; set => vEmployee = value; }
        public clsListClient Cliente { get => vCliente; set => vCliente = value; }
        public clsListHouse House { get => vHouse; set => vHouse = value; }
    }
}
