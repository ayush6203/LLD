using Factory.Interface;

namespace Factory.Classes
{
    public class Bike : IVehicle
    {
        private readonly int Wheels;

        public Bike()
        {
            this.Wheels = 2;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }

        public string VehicleType()
        {
            return "Bike Class";
        }
    }
}
