using System;
namespace patterns.Structural.Bridge.abstractClasses
{
    public abstract class Shape
    {
        protected DrawAPI _drawAPI;

        public Shape(DrawAPI drawAPI)
        {
            _drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
