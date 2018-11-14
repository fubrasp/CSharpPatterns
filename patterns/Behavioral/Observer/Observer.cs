using System;
namespace patterns.Behavioral.Observer
{
    public abstract class Observer
    {
        protected Subject Subject { get; set; }
        public abstract void Update();
    }
}
