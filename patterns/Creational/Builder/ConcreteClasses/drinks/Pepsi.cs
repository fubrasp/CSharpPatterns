using System;
using patterns.Creational.Builder.AbstractClasses;

namespace patterns.Creational.Builder.ConcreteClasses.drinks
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 35.0f;
        }
    }
}
