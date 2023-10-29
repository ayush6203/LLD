using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteLivingThings
{
    public class Dog : LivingThings
    {
        public Dog() : base(new LandBreatheImplementation()) //You can pass this from dog constructor also, depends on use case
        {

        }
    }
}
