using System;
namespace patterns.Creational.Prototype.shapes
{
    public abstract class Shape : ICloneable
    {
        public string Id {get;set;}
        public string Type {get;set;}

        public Shape(string type){
            Type = type;
        }

        public abstract void Draw();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Shape DoClone()
        {
            return (Shape)Clone();
        }
    }
}
