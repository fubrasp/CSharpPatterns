using System;
using patterns.Creational.Builder.ConcreteClasses;

namespace patterns.Creational.Builder
{
    public class BuilderPatternDemo
    {
        public static void Start(){
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {vegMeal.GetCost()}");


            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {nonVegMeal.GetCost()}");

        }
    }
}
