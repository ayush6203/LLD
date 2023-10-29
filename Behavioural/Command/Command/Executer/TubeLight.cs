using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Executer
{
    public class TubeLight
    {
        public void SwitchOn()
        {
            Console.WriteLine("Tubelight is switched on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Tubelight is switched off");
        }
    }
}
