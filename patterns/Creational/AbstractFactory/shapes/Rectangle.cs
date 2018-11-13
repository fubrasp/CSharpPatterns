using System;
namespace patterns.AbstractFactory.shapes
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
