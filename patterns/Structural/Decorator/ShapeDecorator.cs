using System;
using patterns.Structural.Decorator.shapes;

namespace patterns.Structural.Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape _decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            _decoratedShape.Draw();
        }
    }
}
