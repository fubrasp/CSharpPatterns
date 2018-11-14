using System;
namespace patterns.Structural.Facade
{
    public class FacadePatternDemo
    {
        public static void Start(){
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
