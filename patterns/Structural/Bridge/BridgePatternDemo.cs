using patterns.Structural.Bridge.concreteClasses;
using patterns.Structural.Bridge.abstractClasses;
using patterns.Structural.Bridge.shapes;


namespace patterns.Structural.Bridge
{
    public class BridgePatternDemo
    {
        public static void Start()
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
