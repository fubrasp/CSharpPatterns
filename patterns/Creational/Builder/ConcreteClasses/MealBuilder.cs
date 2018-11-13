using System;
using patterns.Creational.Builder.ConcreteClasses.drinks;
using patterns.Creational.Builder.ConcreteClasses.products;

namespace patterns.Creational.Builder.ConcreteClasses
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal(){
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal(){
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
