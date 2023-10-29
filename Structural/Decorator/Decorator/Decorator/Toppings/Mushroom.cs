using Decorator.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Toppings
{
    public class Mushroom : ToppingDecorator
    {
        BasePizza _basePizza;

        public Mushroom(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 15;
        }
    }
}
