using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightClass
{
    public class RobotFactory
    {
        Dictionary<string, IRobot> cache = new Dictionary<string, IRobot>();

        public IRobot CreateRobot(string robotType)
        {
            if (!cache.ContainsKey(robotType))
            {
                if (robotType == "HUMANOID")
                    cache.Add("HUMANOID", new HumanoidRobot("HUMANOID", new Sprites()));

                if (robotType == "DOG")
                    cache.Add("DOG", new HumanoidRobot("DOG", new Sprites()));
            }

            return cache[robotType];
        }
    }
}
