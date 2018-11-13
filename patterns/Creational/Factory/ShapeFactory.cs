using System;
namespace patterns.Factory
{
    public class ShapeFactory
    {
        public Shape GetShape(string shapeType){
            if(string.IsNullOrEmpty(shapeType)){
                return null;
            }
            switch(shapeType){
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
