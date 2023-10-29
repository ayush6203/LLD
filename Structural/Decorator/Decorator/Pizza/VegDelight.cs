﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pizza
{
    public class VegDelight : BasePizza
    {
        public override int Cost()
        {
            return 120;
        }
    }
}
