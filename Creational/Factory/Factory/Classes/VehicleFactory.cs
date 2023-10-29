using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            IVehicle objectType = null;
            if (vehicleType.ToLower().Equals("bike"))
                objectType = new Bike();

            if (vehicleType.ToLower().Equals("car"))
                objectType = new Car();

            if (vehicleType.ToLower().Equals("rikshaw"))
                objectType = new Rikshaw();

            return objectType;
        }
    }
}
