namespace Flyweight.FlyweightClass
{
    public class DogRobot : IRobot
    {
        private string Type;
        private Sprites Sprites;

        public DogRobot(string type, Sprites sprites)
        {
            Type = type;
            Sprites = sprites;
        }

        public void Display(int x, int y)
        {
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
