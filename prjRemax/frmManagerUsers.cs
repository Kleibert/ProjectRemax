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
    public partial class frmManagerUsers : Form
    {
        public frmManagerUsers()
        {
            InitializeComponent();
        }
        string validation = "";
        string vslqstring = "";
        int RefClient , RefEmployee;
        string slq="";
        private void rdClient_CheckedChanged(object sender, EventArgs e)
        {
            List<clsClient> listClient = new List<clsClient>();
            foreach (clsClient cl in clsGlobal.Company.Cliente.Elements)
            {
                listClient.Add(cl);
            }
            gridView.DataSource = listClient;
            lblType.Text = "Type";
            cboType.Items.Clear();
            cboType.Items.Add("Sales");
            cboType.Items.Add("Buyer");
            List<clsEmployee> listEmpl = new List<clsEmployee>();
            foreach (clsEmployee emp in clsGlobal.Company.VEmployee.Elements)
            {
                listEmpl.Add(emp);
            }
            var cboAgents = from emp in listEmpl
                            select new { Name = emp.FtName , RefEmployee = emp.RefEmployee};
            cboAgent.DataSource = cboAgents.ToList();
            cboAgent.DisplayMember = "Name";
            cboAgent.ValueMember = "RefEmployee";
            cboAgent.Visible = true;
            lblAgent.Visible = true;
        }

        private void frmManagerUsers_Load(object sender, EventArgs e)
        {
            clsGlobal.myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kleibert\source\repos\prjRemax\prjRemax\bin\Debug\data\dbRemax.mdb");
            clsGlobal.myCon.Open();
            clsGlobal.CreatLists();
            chButon(false, true, true, true);
        }

        private void rdEmployee_CheckedChanged(object sender, EventArgs e)
        {
            List<clsEmployee> listEmpl = new List<clsEmployee>();
            foreach (clsEmployee emp in clsGlobal.Company.VEmployee.Elements)
            {
                listEmpl.Add(emp);
            }
            gridView.DataSource = listEmpl;
            lblType.Text = "Poste";
            cboType.Items.Clear();
            cboType.Items.Add("Admin");
            cboType.Items.Add("Manager");
            cboType.Items.Add("Agent");

            cboAgent.Visible = false;
            lblAgent.Visible = false;
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int i = gridView.SelectedCells[0].RowIndex;
                string sno = gridView.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(sno);
                if(rdClient.Checked)
                {
                    foreach(clsClient cl in clsGlobal.Company.Cliente.Elements)
                    {
                        if(cl.RefClient.ToString()==sno)
                        {
                            RefClient = Convert.ToInt32(cl.RefClient);
                            cboType.Text = cl.Type;
                            txtUser.Text = cl.User;
                            txtPassword.Text = cl.Password;
                            txtFirstName.Text = cl.FtName;
                            txtLastName.Text = cl.LstName;
                            txtEmail.Text = cl.Email;
                            txtPhone.Text = cl.Phone;
                            foreach(clsEmployee emp in clsGlobal.Company.VEmployee.Elements)
                            {
                                if(cl.RefEmployee == emp.RefEmployee)
                                {
                                    cboAgent.Text = emp.FtName;
                                }
                            }
                        }
                    }
                }
                if (rdEmployee.Checked)
                {
                    
                    
                    foreach (clsEmployee cl in clsGlobal.Company.VEmployee.Elements)
                    {
                        if (cl.RefEmployee.ToString() == sno)
                        {
                            RefEmployee =Convert.ToInt32( cl.RefEmployee);
                            cboType.Text = cl.Poste;
                            txtUser.Text = cl.User;
                            txtPassword.Text = cl.Password;
                            txtFirstName.Text = cl.FtName;
                            txtLastName.Text = cl.LstName;
                            txtEmail.Text = cl.Email;
                            txtPhone.Text = cl.Phone;
                            
                        }
                    }
                }
            }
        }
        private void clearChamps()
        {
            cboType.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

        }
        private void chButon(bool save, bool delete, bool modify, bool create)
        {
            btnDelete.Enabled = delete;
            btnSave.Enabled = save;
            btnModify.Enabled = modify;
            btnCreate.Enabled = create;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            chButon(true,false,false,false);
            cboType.Focus();
            validation = "Modify";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdClient.Checked)
            {
                if (validation == "Modify")
                {
                    vslqstring = "UPDATE Clients SET Type='" + cboType.Text + "', [User]='" + txtUser.Text +
                       "', [Password]='" + txtPassword.Text + "', email='" + txtEmail.Text +
                       "', FirstName='" + txtFirstName.Text + "', LastName='" + txtLastName.Text +
                       "', Phone='" + txtPhone.Text + "' WHERE RefCLient=" + RefClient;
                    OleDbCommand mycmd = new OleDbCommand(vslqstring, clsGlobal.myCon);
                    int result = mycmd.ExecuteNonQuery();
                    chButon(false, true, true, true);
                    clsGlobal.CreatLists();
                    clearChamps();


                }
                if(validation=="Create")
                {
                    vslqstring = @"INSERT INTO Clients VALUES("+(clsGlobal.Company.Cliente.Nombre+1)+",'"+cboType.Text+
                        "', '"+txtUser.Text+"', '"+txtPassword.Text+"','"+txtEmail.Text+"','"+txtFirstName.Text+"','"+txtLastName.Text+
                        "','"+txtPhone.Text+"',"+cboAgent.SelectedValue+");";
                    OleDbCommand mycmd = new OleDbCommand(vslqstring, clsGlobal.myCon);
                    int result = mycmd.ExecuteNonQuery();
                    chButon(false, true, true, true);
                    clsGlobal.CreatLists();
                    clearChamps();
                }
            }
            if (rdEmployee.Checked)
            {
                if (validation == "Modify")
                {
                    vslqstring = "UPDATE Employees SET Poste='" + cboType.Text + "', [User]='" + txtUser.Text +
                       "', [Password]='" + txtPassword.Text + "', email='" + txtEmail.Text +
                       "', FirstName='" + txtFirstName.Text + "', LastName='" + txtLastName.Text +
                       "', Phone='" + txtPhone.Text + "' WHERE RefEmployee=" + RefEmployee;
                    OleDbCommand mycmd = new OleDbCommand(vslqstring, clsGlobal.myCon);
                    int result = mycmd.ExecuteNonQuery();
                    chButon(false, true, true, true);
                    clsGlobal.CreatLists();
                    clearChamps();
                }
                if (validation == "Create")
                {
                    vslqstring = @"INSERT INTO Employees VALUES(" + (clsGlobal.Company.VEmployee.Nombre + 1) + ",'" + cboType.Text +
                        "', '" + txtUser.Text + "', '" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text +
                        "','" + txtPhone.Text + "'," + 1 + ");";
                    OleDbCommand mycmd = new OleDbCommand(vslqstring, clsGlobal.myCon);
                    int result = mycmd.ExecuteNonQuery();
                    chButon(false, true, true, true);
                    clsGlobal.CreatLists();
                    clearChamps();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            chButon(true, false, false, false);
            clearChamps();
            cboType.Focus();
            validation = "Create";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdClient.Checked)
            {
                var recher = from clsClient client in clsGlobal.Company.Cliente.Elements
                             where client.RefClient.Contains(txtFind.Text)
                             select client;
                gridView.DataSource = recher.ToList();
            }else if (rdEmployee.Checked)
            {
                var recher = from clsEmployee emp in clsGlobal.Company.VEmployee.Elements
                             where emp.RefEmployee.Contains(txtFind.Text)
                             select emp;
                gridView.DataSource = recher.ToList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rdClient.Checked)
            {
                if (MessageBox.Show("Would you like to delet this Client", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool delete = true;
                    foreach (clsHouse hs in clsGlobal.Company.House.Elements)
                    {
                        if (hs.RefClient == RefClient.ToString())
                        {
                            MessageBox.Show("This Client Have someHouse for sale you can't delete");
                            delete = false;
                            break;
                        }
                    }
                    if (delete == true)
                    {
                        string sql = "DELETE FROM Clients WHERE RefClient =" + RefClient;
                        OleDbCommand mycmd = new OleDbCommand(sql, clsGlobal.myCon);
                        int result = mycmd.ExecuteNonQuery();
                        clsGlobal.CreatLists();
                        clearChamps();
                    }
                    
                }
            }
            if(rdEmployee.Checked)
                if (MessageBox.Show("Would you like to delete this Employee", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool delete = true;
                    foreach (clsHouse hs in clsGlobal.Company.House.Elements)
                    {
                        if (hs.RefEmployee == RefEmployee.ToString())
                        {
                            MessageBox.Show("This Client Have someHouse for sale you can't delete");
                            delete = false;
                            break;
                        }
                    }
                    if (delete == true)
                    {
                        string sql = "DELETE FROM Employees WHERE RefEmployee =" + RefEmployee;
                        OleDbCommand mycmd = new OleDbCommand(sql, clsGlobal.myCon);
                        int result = mycmd.ExecuteNonQuery();
                        clsGlobal.CreatLists();
                        clearChamps();
                    }
                }
        }
    }
    
}
