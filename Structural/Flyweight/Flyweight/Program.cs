// See https://aka.ms/new-console-template for more information

using Flyweight.FlyweightClass;

RobotFactory robotFactory = new RobotFactory();
IRobot humanoidRobot1 = robotFactory.CreateRobot("HUMANOID");
IRobot humanoidRobot2 = robotFactory.CreateRobot("HUMANOID");

IRobot gogRobot1 = robotFactory.CreateRobot("DOG");
IRobot dogRobot2 = robotFactory.CreateRobot("DOG");

humanoidRobot1.Display(1, 2);
humanoidRobot2.Display(4, 5);
dogRobot2.Display(5, 5);

Console.ReadKey();