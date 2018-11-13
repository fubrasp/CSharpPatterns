using System;
namespace patterns.AbstractFactory.shapes
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Inside Square Draw() method.");
        }
    }
}
