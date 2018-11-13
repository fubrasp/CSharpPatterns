using System;
namespace patterns.Creational.Builder.FoodItems
{
    public interface Item
    {
        string Name();
        Packing Packing();
        float Price();
    }
}
