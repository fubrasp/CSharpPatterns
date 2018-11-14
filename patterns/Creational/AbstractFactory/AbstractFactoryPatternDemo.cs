using System;
using patterns.AbstractFactory;
using patterns.AbstractFactory.colors;
using patterns.AbstractFactory.shapes;

namespace patterns
{
    public static class AbstractFactoryPatternDemo
    {
        public static void Start()
        {
            // Get shape factory
            AbstractFactoryClass shapeFactory = FactoryProducer.GetFactory("SHAPE");

            // Get an object of Shape Circle
            Shape shape1 = shapeFactory.GetShape("CIRCLE");

            // Call draw method of Shape Circle
            shape1.Draw();

            // Get an object of Shape Rectangle
            Shape shape2 = shapeFactory.GetShape("RECTANGLE");

            // Call draw method of Shape Rectangle
            shape2.Draw();

            // Get an object of Shape Square 
            Shape shape3 = shapeFactory.GetShape("SQUARE");

            // Call draw method of Shape Square
            shape3.Draw();

            // Get color factory
            AbstractFactoryClass colorFactory = FactoryProducer.GetFactory("COLOR");

            // Get an object of Color Red
            Color color1 = colorFactory.GetColor("RED");

            // Call fill method of Red
            color1.Fill();

            // Get an object of Color Green
            Color color2 = colorFactory.GetColor("GREEN");

            // Call fill method of Green
            color2.Fill();

            // Get an object of Color Blue
            Color color3 = colorFactory.GetColor("BLUE");

            // Call fill method of Color Blue
            color3.Fill();
        }
    }
}
