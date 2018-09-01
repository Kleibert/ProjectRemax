using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace prjRemax
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {//Connection avec la base do donnees
            //clsGlobal.myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kleibert\source\repos\prjRemax\prjRemax\bin\Debug\data\dbRemax.mdb");
            //clsGlobal.myCon.Open();
            //clsGlobal.CreatLists();

            //loginToolStripMenuItem.Visible = false;


            if (clsGlobal.userEmployee==null && clsGlobal.userClient==null)
            {
                btnValidation(true, false, false);
               // MessageBox.Show(clsGlobal.userEmployee.ToString());
            }
            if (clsGlobal.userEmployee != null)
            {
                if (clsGlobal.userEmployee.Poste == "Admin")
                {
                    btnValidation(true, true, true);
                }
                else 
                {
                    btnValidation(true, false, true);
                }
            }
            if(clsGlobal.userClient!=null)
            {
                btnValidation(true, false, true);
            }
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShearchHouse frmHouses = new frmShearchHouse();
            frmHouses.MdiParent = this;
            frmHouses.Show();
        }

        private void createHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmCreatSales frmSales = new frmCreatSales();
            frmSales.MdiParent = this;
            frmSales.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmGestion frmGest = new frmGestion();
        //    frmGest.MdiParent = this;
        //    frmGest.Show();
        //}

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();

        }

        private void managerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
                frmManagerUsers managerUsers = new frmManagerUsers();
                managerUsers.MdiParent = this;
                managerUsers.Show();
            
        }
        private void btnValidation(bool searchHouse, bool managerUser, bool managerHouse)
        {
            managerUserToolStripMenuItem.Visible = managerUser;
            managerHouses.Visible = managerHouse;
            housesToolStripMenuItem.Visible = searchHouse;

        }

        private void searchHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void managerHouses_Click(object sender, EventArgs e)
        {
            if (clsGlobal.userEmployee != null)
            {
                frmGestion frmGest = new frmGestion();
                frmGest.MdiParent = this;
                frmGest.Show();
            }
        if (clsGlobal.userClient != null)
        {
            frmCreatSales frmSales = new frmCreatSales();
            frmSales.MdiParent = this;
            frmSales.Show();
        }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            //login.MdiParent = this;
            login.Show();

        }
    }
}
