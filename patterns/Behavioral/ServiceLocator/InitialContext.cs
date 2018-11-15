using System;
using patterns.Behavioral.ServiceLocator.services;

namespace patterns.Behavioral.ServiceLocator
{
    public class InitialContext
    {
        public Object Lookup(String communicationBus)
        {
            switch (communicationBus)
            {
                case "Service1":
                    Console.WriteLine("Looking up and creating a new Service1 object");
                    return new Service1();
                case "Service2":
                    Console.WriteLine("Looking up and creating a new Service2 object");
                    return new Service2();
                default:
                    return null;
            }
        }
    }
}
