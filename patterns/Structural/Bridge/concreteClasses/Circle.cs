using System;
using patterns.Structural.Bridge.abstractClasses;

namespace patterns.Structural.Bridge.concreteClasses
{
    public class Circle : Shape
    {
        private int _x, _y, _radius;

        public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            _drawAPI.DrawCircle(_radius, _x, _y);
        }
    }
}
