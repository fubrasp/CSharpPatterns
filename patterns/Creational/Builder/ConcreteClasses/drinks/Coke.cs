using System;
using patterns.Creational.Builder.AbstractClasses;

namespace patterns.Creational.Builder.ConcreteClasses.drinks
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 30.0f;
        }
    }
}
