using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ZomatoFacade
    {
        Resturant resturant = new Resturant();
        Delivery delivery = new Delivery();

        public void PlaceOrder()
        {
            Console.WriteLine("Order placement initiated");
            resturant.PrepareFood();
            delivery.PickUpDelivery();
            delivery.DropDelivery();
        }
    }
}
