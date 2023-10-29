using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class LandBreatheImplementation : IBreatheImplementor
    {
        public void Breate()
        {
            Console.WriteLine("Use Lungs to breathe");
        }
    }
}
