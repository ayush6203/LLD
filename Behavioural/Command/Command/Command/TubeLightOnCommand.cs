using Command.Executer;
using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class TubeLightOnCommand : ICommand
    {
        public TubeLight _tubeLight;
        public TubeLightOnCommand(TubeLight tubeLight)
        {
            _tubeLight = tubeLight;
        }

        public void Execute()
        {
            _tubeLight.SwitchOn();
        }
    }
}
