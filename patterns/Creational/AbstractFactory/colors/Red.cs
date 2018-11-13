using System;
namespace patterns.AbstractFactory.colors
{
    public class Red : Color
    {
        public Red()
        {
        }

        public void Fill()
        {
            Console.WriteLine("Inside Red fill() method.");
        }
    }
}
