using System;
namespace patterns.Factory
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
