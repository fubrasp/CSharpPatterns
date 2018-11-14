using System;
namespace patterns.Structural.Flyweight.shapes
{
    public class Circle : Shape
    {
        public String Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(String color)
        {
            this.Color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Circle: Draw() [Color : {Color}, x : {X}, y : {Y}, radius : {Radius}");
        }
    }
}
