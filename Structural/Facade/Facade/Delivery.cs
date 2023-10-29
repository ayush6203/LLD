using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Delivery
    {
        public void PickUpDelivery()
        {
            Console.WriteLine("Pick up the order");
        }

        public void DropDelivery()
        {
            Console.WriteLine("Drop the delivery");
        }
    }
}
