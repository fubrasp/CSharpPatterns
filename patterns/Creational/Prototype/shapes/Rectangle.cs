using System;
namespace patterns.Creational.Prototype.shapes
{
    public class Rectangle : Shape
    {
        public Rectangle() : base("Rectangle")
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle Draw() method.");
        }
    }
}
