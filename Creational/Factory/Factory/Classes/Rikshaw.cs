using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    public class Rikshaw : IVehicle
    {
        private readonly int Wheels;

        public Rikshaw()
        {
            this.Wheels = 3;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }

        public string VehicleType()
        {
            return "Rikshaw Class";
        }
    }
}
