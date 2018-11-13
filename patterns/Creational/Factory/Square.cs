using System;
namespace patterns.Factory
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
