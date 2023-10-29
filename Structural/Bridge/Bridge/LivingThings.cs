using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class LivingThings
    {
        private readonly IBreatheImplementor _breatheImplementor;

        public LivingThings(IBreatheImplementor breatheImplementor)
        {
            _breatheImplementor = breatheImplementor;
        }

        public void Breathe()
        {
            _breatheImplementor.Breate();
        }
    }
}
