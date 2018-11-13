using System;
using patterns.Creational.Builder.AbstractClasses;

namespace patterns.Creational.Builder.ConcreteClasses.products
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 50.5f;
        }
    }
}
