using System;
using patterns.Structural.Flyweight.shapes;
namespace patterns.Structural.Flyweight
{
    public static class FlyweightPatternDemo
    {
        static Random rnd = new Random();

        public static void Start()
        {

            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(GetRandomColor());
                circle.X = GetRandomValue();
                circle.Y = GetRandomValue();
                circle.Radius = 100;
                circle.Draw();
            }
        }

        private static String GetRandomColor()
        {
            string[] colors = { "Red", "Green", "Blue", "White", "Black" };
            return colors[rnd.Next(0, colors.Length)];
        }

        private static int GetRandomValue()
        {
            return rnd.Next(0, 100);
        }
    }

}
