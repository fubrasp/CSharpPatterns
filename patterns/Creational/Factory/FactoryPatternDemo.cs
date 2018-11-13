using System;
using patterns.Factory;

namespace patterns.Factory
{
    public class FactoryPatternDemo
    {
        public static void Start()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            // Get an object of Circle
            Shape shape1 = shapeFactory.GetShape("CIRCLE");

            // Call its draw method
            shape1.Draw();

            // Get an object of Rectangle and call its draw method
            Shape shape2 = shapeFactory.GetShape("RECTANGLE");

            // Call its draw method
            shape2.Draw();

            // Get an object of Rectangle and call its draw method
            Shape shape3 = shapeFactory.GetShape("SQUARE");

            // Call its draw method
            shape3.Draw();

        }
    }
}
