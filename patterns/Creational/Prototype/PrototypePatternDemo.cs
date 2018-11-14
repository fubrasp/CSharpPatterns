using System;
using patterns.Creational.Prototype;

namespace patterns.Prototype
{
    public static class PrototypePatternDemo
    {
        public static void Start()
        {
            ShapeCache.LoadCache();

            Creational.Prototype.shapes.Shape clonedShape = ShapeCache.GetShape("1");
            Console.WriteLine($"Shape : {clonedShape.Type}");

            Creational.Prototype.shapes.Shape clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine($"Shape : {clonedShape2.Type}");

            Creational.Prototype.shapes.Shape clonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine($"Shape : {clonedShape3.Type}");
        }
    }
}
