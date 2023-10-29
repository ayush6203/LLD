using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteLivingThings
{
    public class Fish : LivingThings
    {
        public Fish() : base(new WaterBreatheImplementation()) { }
    }
}
