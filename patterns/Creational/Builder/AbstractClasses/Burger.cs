using System;
using patterns.Creational.Builder.ConcreteClasses;
using patterns.Creational.Builder.ConcreteClasses.containers;
using patterns.Creational.Builder.FoodItems;

namespace patterns.Creational.Builder.AbstractClasses
{
    public abstract class Burger : Item
    {
        public abstract string Name();

        public Packing Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
