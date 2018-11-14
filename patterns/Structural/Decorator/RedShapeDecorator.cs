using System;
using patterns.Structural.Decorator.shapes;

namespace patterns.Structural.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder(base._decoratedShape);
        }

        private void SetRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
