namespace Flyweight.FlyweightClass
{
    public class HumanoidRobot : IRobot
    {
        private string Type;
        private Sprites Sprites;

        public HumanoidRobot(string type, Sprites sprites)
        {
            Type = type;
            Sprites = sprites;
        }

        public void Display(int x, int y)
        {
            //Use the sprites pixel to reander the image
            Console.WriteLine("x : " + x + ", y : " + y);
        }

        public string GetRoboType
        {
            get { return Type; }
        }

        public Sprites GetSprites
        {
            get { return Sprites; }
        }
    }

}
