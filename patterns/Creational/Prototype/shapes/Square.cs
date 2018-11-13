using System;
namespace patterns.Creational.Prototype.shapes
{
    public class Square : Shape
    {
        public Square() : base("Square")
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square Draw() method.");
        }
    }
}
