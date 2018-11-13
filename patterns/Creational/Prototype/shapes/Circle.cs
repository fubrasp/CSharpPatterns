using System;
namespace patterns.Creational.Prototype.shapes
{
    public class Circle : Shape
    {
        public Circle() : base("Circle")
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle Draw() method.");
        }
    }
}
