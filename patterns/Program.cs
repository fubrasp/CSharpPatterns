﻿using System;
using patterns.Creational.Builder;
using patterns.Factory;
using patterns.Prototype;
using patterns.Singleton;
using patterns.Structural.Adapter;
using patterns.Structural.Bridge;
using patterns.Structural.Composite;
using patterns.Structural.Decorator;
using patterns.Structural.Filter;

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

            //Console.WriteLine("Bridge");
            //BridgePatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Criteria");
            //CriteriaPatternDemo.Start();
            //Console.WriteLine("");

            //Console.WriteLine("Composite");
            //CompositePatternDemo.Start();
            //Console.WriteLine("");

            Console.WriteLine("Decorator");
            DecoratorPatternDemo.Start();
            Console.WriteLine("");

        }
    }
}
