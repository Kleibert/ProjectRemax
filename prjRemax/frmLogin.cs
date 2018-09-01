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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(clsClient user in clsGlobal.Company.Cliente.Elements)
            {
                if(user.User == txtUser.Text &&user.Password ==txtPassword.Text)
                {
                    clsGlobal.userClient = user;
                    break;
                }
                
            }
            foreach(clsEmployee user in clsGlobal.Company.VEmployee.Elements)
            {
                if(user.User == txtUser.Text && user.Password==txtPassword.Text)
                {
                    clsGlobal.userEmployee = user;
                    break;
                }
            }

            if (clsGlobal.userClient != null || clsGlobal.userEmployee != null)
            {
                
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User don't found ");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
            clsGlobal.myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kleibert\source\repos\prjRemax\prjRemax\bin\Debug\data\dbRemax.mdb");
            clsGlobal.myCon.Open();
            clsGlobal.CreatLists();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }
    }
}
