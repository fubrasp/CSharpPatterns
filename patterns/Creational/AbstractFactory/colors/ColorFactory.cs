using System;
using patterns.AbstractFactory.shapes;

namespace patterns.AbstractFactory.colors
{
    public class ColorFactory : AbstractFactoryClass
    {
        public override Color GetColor(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                return null;
            }
            switch (color)
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
                default:
                    return null;
            }
        }

        public override Shape GetShape(string shape)
        {
            return null;
        }
    }
}
