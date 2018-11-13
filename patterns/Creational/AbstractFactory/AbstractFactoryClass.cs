using patterns.AbstractFactory.colors;
using patterns.AbstractFactory.shapes;

namespace patterns.AbstractFactory
{
    public abstract class AbstractFactoryClass
    {
        public abstract Color GetColor(string color);
        public abstract Shape GetShape(string shape);
    }
}
