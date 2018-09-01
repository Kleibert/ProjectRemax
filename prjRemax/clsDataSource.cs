using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace prjRemax
{
    public static class clsDataSource
    {
        public static clsListHouse GetHouses()
        {
            //Liste temporaire
            clsListHouse tmpList = new clsListHouse();

            //Connection a la BDD
            //OleDbConnection myCon = new OleDbConnection(); //connection
            //myCon.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\pc\Documents\Visual Studio 2015\Projects\prjCSWinADONET\prjCSWinADONET\bin\Debug\data\Sport.mdb";
            //myCon.Open();

            //Commande + Requete SQL
            OleDbCommand cmd = new OleDbCommand(); //commande
            cmd.Connection = clsGlobal.myCon;
            cmd.CommandText = "SELECT * FROM Houses";
            OleDbDataReader rdHouse = cmd.ExecuteReader();

            while (rdHouse.Read())
            {
                clsAddress ad = new clsAddress(rdHouse["Region"].ToString(), rdHouse["City"].ToString(), rdHouse["Province"].ToString(), rdHouse["StreetAddress"].ToString(), rdHouse["PostalCode"].ToString(),Convert.ToInt32(rdHouse["aptnumber"]));
                clsHouse eq = new clsHouse(rdHouse["RefHouse"].ToString(), rdHouse["Type"].ToString(), ad, Convert.ToInt32(rdHouse["NbRooms"]), Convert.ToInt32(rdHouse["NbBathroom"]), rdHouse["Size"].ToString(), rdHouse["YearBuilt"].ToString(), Convert.ToDecimal(rdHouse["Price"]), rdHouse["Description"].ToString(), rdHouse["RefEmployee"].ToString(), rdHouse["RefClient"].ToString());
                tmpList.Ajouter(eq);
                eq = null;
            }
            //fermer le reader
            rdHouse.Close();
            //fermer la connection
            // myCon.Close();
            //retourne la valeur tmpList
            return tmpList;
        }
            public static clsListEmployee GetEmployee()
            {
                //Liste temporaire
                clsListEmployee tmpListEmployee = new clsListEmployee();

                //Connection a la BDD
                //OleDbConnection myCon = new OleDbConnection(); //connection
                //myCon.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\pc\Documents\Visual Studio 2015\Projects\prjCSWinADONET\prjCSWinADONET\bin\Debug\data\Sport.mdb";
                //myCon.Open();

                //Commande + Requete SQL
                OleDbCommand cmd = new OleDbCommand(); //commande
                cmd.Connection = clsGlobal.myCon;
                cmd.CommandText = "SELECT * FROM Employees";
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    clsEmployee eq = new clsEmployee(rd["User"].ToString(),
                        rd["Password"].ToString(),rd["Email"].ToString(),
                        rd["RefEmployee"].ToString(), rd["Poste"].ToString(), 
                        rd["RefCompany"].ToString(), rd["Phone"].ToString(),
                        rd["FirstName"].ToString(),rd["LastName"].ToString());
                    tmpListEmployee.Ajouter(eq);
                    eq = null;
                }
                //fermer le reader
                rd.Close();
                //fermer la connection
                // myCon.Close();
                //retourne la valeur tmpList
                return tmpListEmployee;
            }


        public static clsListClient GetClients()
        {
            //Liste temporaire
            clsListClient tmpList = new clsListClient();

            //Commande + Requete SQL
            OleDbCommand cmd = new OleDbCommand(); //commande
            cmd.Connection = clsGlobal.myCon;
            cmd.CommandText = "SELECT * FROM Clients";
            OleDbDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                clsClient cl = new clsClient(rd["User"].ToString(), rd["Password"].ToString(),
                    rd["Email"].ToString(), rd["RefClient"].ToString(),
                    rd["Type"].ToString(), rd["Phone"].ToString(),
                        rd["FirstName"].ToString(), rd["LastName"].ToString(), rd["RefEmployee"].ToString());
                tmpList.Ajouter(cl);
                cl = null;
            }
            //fermer le reader
            rd.Close();
            //fermer la connection
            // myCon.Close();
            //retourne la valeur tmpList
            return tmpList;
        }
    }
}
