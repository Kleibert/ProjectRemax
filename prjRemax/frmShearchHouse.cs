using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRemax
{
    public partial class frmShearchHouse : Form
    {
        public frmShearchHouse()
        {
            InitializeComponent();
        }
        List<clsHouse> houses = new List<clsHouse>();
        private void frmShearchHouse_Load(object sender, EventArgs e)
        {
            for(int i=50000; i<1000000;i+=100000)
            {
                int c = i;
                cboPrice.Items.Add(c);
            }

            //List<clsHouse> houses = new List<clsHouse>();
            
            foreach(clsHouse hs in clsGlobal.Company.House.Elements)
            {
                houses.Add(hs);
            }
            var recher = from house in houses
                         select new {
                             RefHouse = house.RefHouse,
                             Types = house.Type,
                             house.NumberRoom,
                             house.NumberBathroom,
                             house.Price,
                             house.Address.City,
                             house.Address.Province,
                             house.Address.Region,
                             house.Address.StreetAddrees,
                             house.Address.PostalCode,
                             house.Description
                         };
            gridHouses.DataSource = recher.ToList();



            var cbcity = (from city in houses
                         select new { City = city.Address.City}).Distinct();

            cboCity.DataSource = cbcity.ToList();
            cboCity.DisplayMember = "City";

            var cbTypes = (from types in houses
                          select new { Types = types.Type}).Distinct();
            cboType.DataSource = cbTypes.ToList();
            cboType.DisplayMember = "Types";
            cboType.ValueMember = "Types";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //string selectValue = cboType.Text;
            if (checkHouse.Checked)
            {
                var recher = from house in houses
                             where house.RefHouse.Contains(txtHouseRef.Text)
                             select new
                             {
                                 house.RefHouse,
                                 Types = house.Type,
                                 house.NumberRoom,
                                 house.NumberBathroom,
                                 house.Price,
                                 house.Address.City,
                                 house.Address.Province,
                                 house.Address.Region,
                                 house.Address.StreetAddrees,
                                 house.Address.PostalCode,
                                 house.Description
                             };
                gridHouses.DataSource = recher.ToList();
            }
            else if (checkAgent.Checked)
            {
                var recher = from house in houses
                             where house.RefEmployee.Contains(txtAgentRef.Text)
                             select new
                             {
                                 house.RefHouse,
                                 Types = house.Type,
                                 house.NumberRoom,
                                 house.NumberBathroom,
                                 house.Price,
                                 house.Address.City,
                                 house.Address.Province,
                                 house.Address.Region,
                                 house.Address.StreetAddrees,
                                 house.Address.PostalCode,
                                 house.Description
                             };
                gridHouses.DataSource = recher.ToList();
            }
            else
            {
                if (cboType.Text != "" && cboCity.Text == "" && cboRooms.Text == "" && cboBathroom.Text == "" && cboPrice.Text == "")
                {

                    var recher = from house in houses
                                 where house.Type.Contains(cboType.Text)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else if (cboType.Text != "" && cboCity.Text != "" && cboRooms.Text == "" && cboBathroom.Text == "" && cboPrice.Text == "")
                {

                    var recher = from house in houses
                                 where house.Type.Contains(cboType.Text) && house.Address.City.Contains(cboCity.Text)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else if (cboType.Text != "" && cboCity.Text != "" && cboRooms.Text != "" && cboBathroom.Text == "" && cboPrice.Text == "")
                {

                    var recher = from house in houses
                                 where house.Type.Contains(cboType.Text) &&
                                 house.Address.City.Contains(cboCity.Text) &&
                                 house.NumberRoom.ToString().Contains(cboRooms.Text)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else if (cboType.Text != "" && cboCity.Text != "" && cboRooms.Text != "" && cboBathroom.Text != "" && cboPrice.Text == "")
                {

                    var recher = from house in houses
                                 where house.Type.Contains(cboType.Text) &&
                                 house.Address.City.Contains(cboCity.Text) &&
                                 house.NumberRoom.ToString().Contains(cboRooms.Text) &&
                                 house.NumberBathroom.ToString().Contains(cboBathroom.Text)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else if (cboType.Text != "" && cboCity.Text != "" && cboRooms.Text != "" && cboBathroom.Text != "" && cboPrice.Text != "")
                {

                    var recher = from house in houses
                                 where house.Type.Contains(cboType.Text) &&
                                 house.Address.City.Contains(cboCity.Text) &&
                                 house.NumberRoom.ToString().Contains(cboRooms.Text) &&
                                 house.NumberBathroom.ToString().Contains(cboBathroom.Text) &&
                                 house.Price <= Convert.ToDecimal(cboPrice.SelectedItem)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else if (cboType.Text == "" && cboCity.Text == "" && cboRooms.Text == "" && cboBathroom.Text == "" && cboPrice.Text != "")
                {

                    var recher = from house in houses
                                 where
                                 house.Price <= Convert.ToDecimal(cboPrice.SelectedItem)
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
                else
                {

                    var recher = from house in houses
                                 select new
                                 {
                                     house.RefHouse,
                                     Types = house.Type,
                                     house.NumberRoom,
                                     house.NumberBathroom,
                                     house.Price,
                                     house.Address.City,
                                     house.Address.Province,
                                     house.Address.Region,
                                     house.Address.StreetAddrees,
                                     house.Address.PostalCode,
                                     house.Description
                                 };
                    gridHouses.DataSource = recher.ToList();
                }
            }
            btnValidation(true, true, true, true, true, true, true);
            checkAgent.Checked = false;
            checkHouse.Checked =false;
            txtAgentRef.Text = "";
            txtHouseRef.Text = "";
        }

        private void gridHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridHouses.SelectedCells.Count > 0)
            {
                int i = gridHouses.SelectedCells[0].RowIndex;
                string sno = gridHouses.Rows[i].Cells["RefHouse"].Value.ToString();

                foreach (clsHouse selectHouse in clsGlobal.Company.House.Elements)
                {
                    if (selectHouse.RefHouse.ToString() == sno)
                    {
                        
                        string RefClient = selectHouse.RefClient;
                        foreach (clsClient client in clsGlobal.Company.Cliente.Elements)
                        {
                            if (client.RefClient.ToString() == RefClient)
                            {
                                // MessageBox.Show(client.LstName);
                           MessageBox.Show(//selectHouse.Type.ToString() + "\n" +
                        //    selectHouse.Address.Region.ToString() + "\n" +
                        //selectHouse.Address.City.ToString() + "\n" +
                        //selectHouse.Address.City.ToString() + "\n" +
                        //selectHouse.NumberRoom.ToString() + "\n" +
                        // selectHouse.NumberBathroom.ToString() + "\n" +
                        //selectHouse.Size.ToString() + "\n" +
                        //selectHouse.Description + "\n" +
                        //selectHouse.Address.StreetAddrees + "\n" +
                        // selectHouse.Address.PostalCode + "\n" +
                        //selectHouse.Address.AptNumber.ToString() + "\n" +
                        // selectHouse.YearBuilt + "\n" +
                        //selectHouse.Price.ToString() + "\n"+
                        "Informations for contact\n"+
                              "First Name :"+ client.FtName + "\n" +
                               "Last Name :"+ client.LstName + "\n" +
                               "Phone :" +client.Phone + "\n" +
                               "E-email:" + client.Email);
                            }
                        }

                    }
                }



            }
        }

        private void checkHouse_CheckedChanged(object sender, EventArgs e)
        {
            btnValidation(false, false, false, false, false, true, false);
            checkAgent.Checked = false;
            cboType.Text = "";
            cboCity.Text = "";
        }
        private void btnValidation(bool CboType, bool CboCity, bool CboRooms, bool CboBathroom,bool CboPrice, bool txthouseCode, bool txtagenCode)
        {
            txtAgentRef.Enabled = txtagenCode;
            cboType.Enabled = CboType;
            cboCity.Enabled = CboCity;
            cboRooms.Enabled = CboRooms;
            cboBathroom.Enabled = CboBathroom;
            cboPrice.Enabled = CboPrice;
            txtHouseRef.Enabled = txthouseCode;
        }

        private void checkAgent_CheckedChanged(object sender, EventArgs e)
        {
            btnValidation(false, false, false, false, false, false, true);
            checkHouse.Checked=false;
            cboType.Text = "";
            cboCity.Text = "";
        }
    }
}
