using System;
using System.Collections.Generic;
using patterns.Creational.Prototype.shapes;

namespace patterns.Creational.Prototype
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeDictionary = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId){
            Shape cachedShape;

            bool existingShape = shapeDictionary.TryGetValue(shapeId, out cachedShape);

            if(existingShape){
                return cachedShape;
            }else{
                return (Shape)cachedShape.DoClone();
            }
        }

        // Generate a fake data set
        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.Id = "1";
            shapeDictionary.Add(circle.Id, circle);

            Square square = new Square();
            square.Id = "2";
            shapeDictionary.Add(square.Id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.Id = "3";
            shapeDictionary.Add(rectangle.Id, rectangle);
        }
    }
}
