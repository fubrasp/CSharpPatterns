using System;
using System.Collections.Generic;
using patterns.Creational.Builder.FoodItems;

namespace patterns.Creational.Builder.ConcreteClasses
{
    public class Meal
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item){
            _items.Add(item);
        }

        public float GetCost(){
            float cost = 0.0f;

            foreach(Item item in _items){
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems(){
            foreach(Item item in _items){
                Console.Write("Item : " + item.Name());
                Console.Write(", Packing : " + item.Packing().Pack());
                Console.Write(", Price : " + item.Price()+ "\n");
            }
        }
    }
}
