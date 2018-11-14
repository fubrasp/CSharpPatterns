﻿using System;
namespace patterns.Behavioral.Observer
{
    public static class ObserverPatternDemo
    {
        public static void Start()
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.State = 15;
            Console.WriteLine("Second state change: 10");
            subject.State = 10;
        }
    }
}
