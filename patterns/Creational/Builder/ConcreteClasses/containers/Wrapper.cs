using System;
using patterns.Creational.Builder.FoodItems;

namespace patterns.Creational.Builder.ConcreteClasses.containers
{
    public class Wrapper : Packing
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
