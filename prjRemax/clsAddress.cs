using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public class clsAddress
    {
        private string vRegion;
        private string vCity;
        private string vProvince;
        private string vStreetAddrees;
        private string vPostalCode;
        private int vAptNumber;
        public string Region { get => vRegion; set => vRegion = value; }
        public string City { get => vCity; set => vCity = value; }
        public string Province { get => vProvince; set => vProvince = value; }
        public string PostalCode { get => vPostalCode; set => vPostalCode = value; }
        public string StreetAddrees { get => vStreetAddrees; set => vStreetAddrees = value; }
        public int AptNumber { get => vAptNumber; set => vAptNumber = value; }

        public clsAddress()
        {
            Region = "Undefined";
            City = "Undefined";
            Province = "Undefined";
            StreetAddrees = "Undefined";
            PostalCode = "Undefined";
            AptNumber = 00;

        }
        public clsAddress(string Region, string City, string Province, string StreetAddrees, string PostalCode, int AptNumber)
        {
            this.Region = Region;
            this.City = City;
            this.Province = Province;
            this.StreetAddrees = StreetAddrees;
            this.PostalCode = PostalCode;
            this.AptNumber = AptNumber;
        }

        public override string ToString()
        {
            string text = this.Region +" "+ this.City +
                " " + this.Province + " " + this.StreetAddrees + " " + this.PostalCode;
            return text;
        }
    }
}
