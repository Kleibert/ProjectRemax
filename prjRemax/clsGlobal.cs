using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace prjRemax
{
    static class clsGlobal
    {
        public static OleDbConnection myCon;
        public static clsListHouse houses;
        public static clsCompany Company;
        public static clsClient userClient = null;
        public static clsEmployee userEmployee=null;
        public static void CreatLists()
        {
            clsGlobal.Company = new clsCompany(clsDataSource.GetEmployee(), clsDataSource.GetClients(), clsDataSource.GetHouses());
        }
    }
}
