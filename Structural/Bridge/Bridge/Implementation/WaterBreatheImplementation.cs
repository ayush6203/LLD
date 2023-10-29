using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class WaterBreatheImplementation : IBreatheImplementor
    {
        public void Breate()
        {
            Console.WriteLine("Use gills to breathe inside water");
        }
    }
}
