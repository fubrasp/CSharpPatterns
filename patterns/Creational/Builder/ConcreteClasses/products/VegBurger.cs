using System;
using patterns.Creational.Builder.AbstractClasses;

namespace patterns.Creational.Builder.ConcreteClasses.products
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }
}
