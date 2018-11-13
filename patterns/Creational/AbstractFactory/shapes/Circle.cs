using System;
namespace patterns.AbstractFactory.shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Inside Circle Draw() method.");
        }
    }
}
