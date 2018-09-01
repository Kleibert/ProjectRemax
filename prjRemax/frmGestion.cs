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
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }
        List<clsHouse> houses = new List<clsHouse>();
        int RefHouses;
        private void frmGestion_Load(object sender, EventArgs e)
        {
            lblUser.Text ="USER:"+ clsGlobal.userEmployee.User;
            LoadGridView();

            
            btnCheck(false, false, false, false, false, false, false, false, false, false, false, false, false,
                false, false, false, false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(gridHouses.SelectedCells["RefHouse"].Value.ToString());
            //MessageBox.Show(gridHouses.SelectedRows[1].Cells["RefHouse"].Value.ToString());
            if (gridHouses.SelectedCells.Count > 0)
            {
                int i = gridHouses.SelectedCells[0].RowIndex;
                string sno = gridHouses.Rows[i].Cells["RefHouse"].Value.ToString();

                foreach(clsHouse selectHouse in clsGlobal.Company.House.Elements)
                {
                    if(selectHouse.RefHouse.ToString() == sno)
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
                        string RefClient = selectHouse.RefClient;
                        foreach(clsClient client in clsGlobal.Company.Cliente.Elements)
                        {
                            if(client.RefClient.ToString()== RefClient)
                            {
                               // MessageBox.Show(client.LstName);
                                txtFirstName.Text = client.FtName;
                                txtLastName.Text = client.LstName;
                                txtPhone.Text = client.Phone;
                                txtEmail.Text = client.Email;
                            }
                        }

                    }
                }
                
                
                
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(checkHouseCode.Checked )
            {

                var recher = from house in houses
                             where textHouseCode.Text == house.RefHouse
                             select house;
                gridHouses.DataSource = recher.ToList();
                if (gridHouses.RowCount == 0)
                {
                    MessageBox.Show("House don't found");
                }
            }
            else if(checkClient.Checked)
            {
                var recher = from house in houses
                             where textClient.Text == house.RefClient
                             select house;
                gridHouses.DataSource = recher.ToList();
                if (gridHouses.RowCount == 0)
                {
                    MessageBox.Show("House don't found");
                }

            }
            else if(checkClient.Checked && checkHouseCode.Checked)
            {
                var recher = from house in houses
                             where textClient.Text == house.RefClient && textHouseCode.Text == house.RefHouse
                             select house;
                gridHouses.DataSource = recher.ToList();
               if( gridHouses.RowCount == 0)
                {
                    MessageBox.Show("House don't found");
                }
            }
            else if (!checkClient.Checked && !checkHouseCode.Checked)
            {
                MessageBox.Show("You need tou check one");
            }
        }

        private void btnCheck( bool Type,bool Region, bool City, bool Province, bool Rooms,
            bool Bathroom, bool Size, bool Description, bool Street, bool PostalCode,
            bool AptNumber, bool YearBuilt, bool Price, bool FirstNAme, bool LastName
            ,bool Phone, bool Email)
        {
            cboType.Enabled = Type;
            txtRegion.Enabled = Region;
            txtCity.Enabled = City;
            txtPovince.Enabled = Province;
            cboRooms.Enabled = Rooms;
            cboBathroom.Enabled = Bathroom;
            txtSize.Enabled = Size;
            txtDescription.Enabled = Description;
            txtStreet.Enabled = Street;
            txtPostalCode.Enabled = PostalCode;
            txtAptNumber.Enabled = AptNumber;
            txtYearBuilt.Enabled = YearBuilt;
            txtPrice.Enabled = Price;
            txtFirstName.Enabled = FirstNAme;
            txtLastName.Enabled = LastName;
            txtPhone.Enabled = Phone;
            txtEmail.Enabled = Email;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnCheck(true, true, true, true, true, true, true, true, true, true, true, true, true, false,
                false, false, false);
            cboType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Would you like to save all modifications","Modify",MessageBoxButtons.YesNo)== DialogResult.Yes)
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
                gridHouses.Refresh();
                LoadGridView();
                clearChamps();
            }
         }
        private void LoadGridView()
        {
            
            foreach (clsHouse hs in clsGlobal.Company.House.Elements)
            {
                houses.Add(hs);
            }
            if (clsGlobal.userEmployee.Poste == "Agent")
            {
                var recher = from house in houses
                             where house.RefEmployee.Contains(clsGlobal.userEmployee.RefEmployee.ToString())
                             select house;
                gridHouses.DataSource = recher.ToList();
            }
            else
            {
                var recher = from house in houses
                             select house;
                gridHouses.DataSource = recher.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to delet this House", "Modify", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Houses WHERE RefHouse =" + RefHouses ;
                OleDbCommand mycmd = new OleDbCommand(sql, clsGlobal.myCon);
                int result = mycmd.ExecuteNonQuery();
                clsGlobal.CreatLists();
                clearChamps();
                gridHouses.DataSource = null;
                gridHouses.Refresh();
                LoadGridView();
                clearChamps();
            }
        }
        private void clearChamps()
        {
            cboType.Text = "";
            txtRegion.Text = "";
            txtCity.Text ="";
            txtPovince.Text = "";
            cboRooms.Text = "";
            cboBathroom.Text = "";
            txtSize.Text= "";
            txtDescription.Text = "";
            txtStreet.Text = "";
            txtPostalCode.Text = "";
            txtAptNumber.Text = "";
            txtYearBuilt.Text = "";
            txtPrice.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text= "";
            txtPhone.Text = "";
            txtEmail.Text= "";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
