using System;
namespace patterns.AbstractFactory.colors
{
    public class Blue : Color
    {
        public Blue()
        {
        }

        public void Fill()
        {
            Console.WriteLine("Inside Blue fill() method.");
        }
    }
}
