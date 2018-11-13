using System;
using patterns.AbstractFactory.colors;

namespace patterns.AbstractFactory.shapes
{
    public class ShapeFactory : AbstractFactoryClass
    {
        public override Color GetColor(string color)
        {
            return null;
        }

        public override Shape GetShape(string shape)
        {
            if (string.IsNullOrEmpty(shape))
            {
                return null;
            }
            switch (shape)
            {
                case "CIRCLE":
                    return new Circle();
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
