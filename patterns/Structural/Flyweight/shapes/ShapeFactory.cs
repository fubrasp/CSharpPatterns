using System;
using System.Collections.Generic;

namespace patterns.Structural.Flyweight.shapes
{
    public class ShapeFactory
    {
        private static Dictionary<string, Circle> circles = new Dictionary<string, Circle>();

        public static Shape getCircle(String color)
        {
            Circle circle;
            bool isCircleColorExisting = circles.TryGetValue(color, out circle);

            if (!isCircleColorExisting)
            {
                circle = new Circle(color);
                circles.Add(color, circle);
                Console.WriteLine($"Creating circle of color : {color}");
            }
            return circle;
        }
    }
}
