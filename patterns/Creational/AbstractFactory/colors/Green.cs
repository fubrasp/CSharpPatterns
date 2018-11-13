using System;
namespace patterns.AbstractFactory.colors
{
    public class Green : Color
    {
        public Green()
        {
        }

        public void Fill()
        {
            Console.WriteLine("Inside Green fill() method.");
        }
    }
}
