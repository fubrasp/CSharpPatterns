using System;
using patterns.Creational.Builder;
using patterns.Factory;
using patterns.Prototype;
using patterns.Singleton;
using patterns.Structural.Adapter;
using patterns.Structural.Bridge;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Factory");
            //FactoryPatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("AbstractFactory");
            //AbstractFactoryPatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Singleton");
            //SingletonPatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Builder");
            //BuilderPatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Prototype");
            //PrototypePatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Adapter");
            //AdapterPatternDemo.Start();
            //Console.WriteLine("");

            Console.WriteLine("Bridge");
            BridgePatternDemo.Start();
            Console.WriteLine("");
        }
    }
}
