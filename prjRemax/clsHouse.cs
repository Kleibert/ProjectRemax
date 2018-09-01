using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
    public class clsHouse
    {
        private string vRefHouse;
        private string vType;
        private clsAddress vAddress;
        private int vNumberRoom;
        private int vNumberBathroom;
        private string vSize;
        private string vYearBuilt;
        private decimal vPrice;
        private string vDescription;
        private string vRefEmployee;
        private string vRefClient;

        public clsHouse(string RefHouse, string Type, clsAddress Address, int NumberRoom, int NumberBathromm, string Size,
            string YearBuilt, decimal Price, string Description, string RefEmployee, string RefClient)
        {
            this.RefHouse = RefHouse;
            this.Type = Type;
            this.Address = Address;
            this.NumberRoom = NumberRoom;
            this.NumberBathroom = NumberBathromm;
            this.Size = Size;
            this.YearBuilt = YearBuilt;
            this.Price = Price;
            this.Description = Description;
            this.RefEmployee = RefEmployee;
            this.RefClient = RefClient;
        }
        public clsHouse()
        {
            RefHouse = "Undefined";
            Type = "Undefined";
            Address = new clsAddress();
            NumberRoom = 00;
            NumberBathroom = 00;
            Size = "Undefined";
            YearBuilt = "Undefined";
            Price = 000;
            Description = "Undefined";
            RefEmployee = "Undefined";
            RefClient = "Undefined";
        }
        public string RefHouse { get => vRefHouse; set => vRefHouse = value; }
        public string Type { get => vType; set => vType = value; }
        public clsAddress Address { get => vAddress; set => vAddress = value; }
        public int NumberRoom { get => vNumberRoom; set => vNumberRoom = value; }
        public int NumberBathroom { get => vNumberBathroom; set => vNumberBathroom = value; }
        public string Size { get => vSize; set => vSize = value; }
        public string YearBuilt { get => vYearBuilt; set => vYearBuilt = value; }
        public decimal Price { get => vPrice; set => vPrice = value; }
        public string Description { get => vDescription; set => vDescription = value; }
        public string RefEmployee { get => vRefEmployee; set => vRefEmployee = value; }
        public string RefClient { get => vRefClient; set => vRefClient = value; }

        public override string ToString()
        {
            string result = this.RefHouse +" "+ this.Type +" "+ this.vAddress;
            return result;
        }
    }
}
