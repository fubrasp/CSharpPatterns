using System;
namespace patterns.Singleton
{
    public class SingleObject
    {
        private static readonly Lazy<SingleObject> lazy = new Lazy<SingleObject>(() => new SingleObject());

        public static SingleObject Instance => lazy.Value;

        private SingleObject()
        {
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
