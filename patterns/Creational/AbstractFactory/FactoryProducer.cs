using System;
using patterns.AbstractFactory;
using patterns.AbstractFactory.colors;
using patterns.AbstractFactory.shapes;

namespace patterns.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactoryClass GetFactory(string choice){
            if (string.IsNullOrEmpty(choice))
            {
                return null;
            }
            switch (choice)
            {
                case "SHAPE":
                    return new ShapeFactory();
                case "COLOR":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
