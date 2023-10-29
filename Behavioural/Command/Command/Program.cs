// See https://aka.ms/new-console-template for more information
using Command.Command;
using Command.Controller;
using Command.Executer;

Console.WriteLine("Hello, World!");

TubeLight tubelight = new TubeLight();
TubeLightOnCommand onCommand = new TubeLightOnCommand(tubelight);
TubeLightOffCommand offCommand = new TubeLightOffCommand(tubelight);

RemoteController controller = new RemoteController(onCommand);
controller.PressButton();
controller.SetCommand(offCommand);
controller.PressButton();
