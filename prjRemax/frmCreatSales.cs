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
    public partial class frmCreatSales : Form
    {
        public frmCreatSales()
        {
            InitializeComponent();
        }
        int RefHouses;
        private void frmCreatSales_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User : " + clsGlobal.userClient.FtName;
            List<clsEmployee> emplo = new List<clsEmployee>();

           //clsListEmployee employeee = new clsListEmployee();
           // employeee = clsDataSource.GetEmployee();
            foreach (clsEmployee ep in clsGlobal.Company.VEmployee.Elements)
            {
                emplo.Add(ep);
            }

            var recher = from emp in emplo
                         select new {RefEmployee = emp.RefEmployee, Nom= emp.FtName };

            cboEmployee.DataSource = recher.ToList();
            cboEmployee.DisplayMember = "Nom";
            cboEmployee.ValueMember = "RefEmployee";
            var rpList = from clsHouse house in clsGlobal.Company.House.Elements
                         where house.RefClient.Contains(clsGlobal.userClient.RefClient)
                         select new { RefHouse = house.RefHouse, Types = house.Type, house.NumberRoom, house.NumberBathroom, house.Price, house.Address.City, house.Description, };
            gridHouse.DataSource = rpList.ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        { 
            int refer = clsGlobal.Company.House.Nombre + 1;
            clsHouse uneHouse = new clsHouse();
            uneHouse.RefHouse =Convert.ToString( refer);
            uneHouse.Type = cboType.SelectedItem.ToString();
            uneHouse.Address.Region = txtRegion.Text;
            uneHouse.Address.City = txtCity.Text;
            uneHouse.Address.Province = txtPovince.Text;
            uneHouse.NumberRoom =Convert.ToInt32( cboRooms.SelectedItem);
            uneHouse.NumberBathroom = Convert.ToInt32(cboBathroom.SelectedItem);
            uneHouse.Size = txtSize.Text;
            uneHouse.Description = txtDescription.Text;
            uneHouse.Address.AptNumber = Convert.ToInt32(txtAptNumber.Text);
            uneHouse.Address.StreetAddrees = txtStreet.Text;
            uneHouse.Address.PostalCode = txtPostalCode.Text;
            uneHouse.YearBuilt = txtYearBuilt.Text;
            uneHouse.Price = Convert.ToDecimal(txtPrice.Text);
            uneHouse.RefEmployee = cboEmployee.SelectedValue.ToString();
            uneHouse.RefClient = clsGlobal.userClient.RefClient;

            clsGlobal.Company.House.Ajouter(uneHouse);

            List<clsHouse> houses = new List<clsHouse>();

            foreach (clsHouse hs in clsGlobal.Company.House.Elements)
            {
                houses.Add(hs);
            }
            var recher = from house in houses
                         where house.RefClient.Contains(clsGlobal.userClient.RefClient)
                         select new { RefHouse=house.RefHouse, Types = house.Type, house.NumberRoom, house.NumberBathroom, house.Price, house.Address.City, house.Description, };
            gridHouse.DataSource = recher.ToList();

            string sql3 = @"INSERT INTO Houses(Type, Region, City, Province, NbRooms, 
NbBathroom, [Size],  Description,StreetAddress, PostalCode, 
                         aptnumber, YearBuilt, Price, RefEmployee, RefClient) 
VALUES('" + uneHouse.Type+"','"+uneHouse.Address.Region+"','"
                +uneHouse.Address.City+"','"+uneHouse.Address.Province+"',"+uneHouse.NumberRoom+
                ","+uneHouse.NumberBathroom+","+
                uneHouse.Size+",'"+uneHouse.Description+"','"+uneHouse.Address.StreetAddrees+"','"
                +uneHouse.Address.PostalCode+"',"+uneHouse.Address.AptNumber+
                ",'"+uneHouse.YearBuilt+"',"+Convert.ToDecimal( uneHouse.Price)+
                ","+Convert.ToInt32(uneHouse.RefEmployee)+","
                +Convert.ToInt32( uneHouse.RefClient)+");";
            OleDbCommand mycmd = new OleDbCommand(sql3, clsGlobal.myCon);
            int result = mycmd.ExecuteNonQuery();
            clsGlobal.CreatLists();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            cboType.Focus();
            cboEmployee.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Houses SET Type ='" + cboType.Text +
                    "',Region ='" + txtRegion.Text + "',City='" + txtCity.Text + "',Province='"
                    + txtPovince.Text + "',NbRooms=" + Convert.ToInt32(cboRooms.Text) +
                    ",NbBathroom=" + Convert.ToInt32(cboBathroom.Text) +
                    ",[Size]=" + Convert.ToInt32(txtSize.Text) + ",Description='"
                    + txtDescription.Text + "',StreetAddress='" + txtStreet.Text + "',PostalCode='"
                    + txtPostalCode.Text + "',aptnumber=" + Convert.ToInt32(txtAptNumber.Text)
                    + ",YearBuilt='" + txtYearBuilt.Text + "',Price="
                    + Convert.ToDecimal(txtPrice.Text) +
                    " WHERE RefHouse =" + RefHouses;

            OleDbCommand mycmd = new OleDbCommand(sql, clsGlobal.myCon);
            int result = mycmd.ExecuteNonQuery();
            clsGlobal.CreatLists();
            gridHouse.Refresh();
            cboEmployee.Enabled = true;
        }

        private void gridHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridHouse.SelectedCells.Count > 0)
            {
                int i = gridHouse.SelectedCells[0].RowIndex;
                string sno = gridHouse.Rows[i].Cells["RefHouse"].Value.ToString();

                foreach (clsHouse selectHouse in clsGlobal.Company.House.Elements)
                {
                    if (selectHouse.RefHouse.ToString() == sno)
                    {
                        RefHouses = Convert.ToInt32(selectHouse.RefHouse);
                        cboType.Text = selectHouse.Type.ToString();
                        txtRegion.Text = selectHouse.Address.Region.ToString();
                        txtCity.Text = selectHouse.Address.City.ToString();
                        txtPovince.Text = selectHouse.Address.Province.ToString();
                        cboRooms.Text = selectHouse.NumberRoom.ToString();
                        cboBathroom.Text = selectHouse.NumberBathroom.ToString();
                        txtSize.Text = selectHouse.Size.ToString();
                        txtDescription.Text = selectHouse.Description;
                        txtStreet.Text = selectHouse.Address.StreetAddrees;
                        txtPostalCode.Text = selectHouse.Address.PostalCode;
                        txtAptNumber.Text = selectHouse.Address.AptNumber.ToString();
                        txtYearBuilt.Text = selectHouse.YearBuilt;
                        txtPrice.Text = selectHouse.Price.ToString();
                       
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
             if (MessageBox.Show("Would you like to delet this House", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Houses WHERE RefHouse =" + RefHouses;
                    OleDbCommand mycmd = new OleDbCommand(sql, clsGlobal.myCon);
                    int result = mycmd.ExecuteNonQuery();
                    clsGlobal.CreatLists();
                    gridHouse.DataSource = null;
                    gridHouse.Refresh();
                    
                }
            
        }
    }
}
