using System;
using patterns.Creational.Builder.FoodItems;

namespace patterns.Creational.Builder.ConcreteClasses.containers
{
    public class Bottle : Packing
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
