using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Address
    {
        public int DoorNumber { get; set; }
        public int StreetNumber { get; set;}
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return string.Format("DoorNumber : {0}, StreetNumber : {1}, ZipCode : {2}, Country : {3}", this.DoorNumber, this.StreetNumber, this.ZipCode, this.Country);
        }
    }
}
