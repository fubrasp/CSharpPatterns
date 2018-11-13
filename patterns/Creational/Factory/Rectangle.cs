using System;
namespace patterns.Factory
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Inside Rectangle Draw() method.");
        }
    }
}
