using Command.Executer;
using Command.Interface;

namespace Command.Command
{
    public class TubeLightOffCommand : ICommand
    {
        public TubeLight _tubeLight;
        public TubeLightOffCommand(TubeLight tubeLight)
        {
            _tubeLight = tubeLight;
        }

        public void Execute()
        {
            _tubeLight.SwitchOff();
        }
    }
}
