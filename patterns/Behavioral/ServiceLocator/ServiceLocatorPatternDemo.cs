using System;
using patterns.Behavioral.ServiceLocator.services;

namespace patterns.Behavioral.ServiceLocator
{
    public static class ServiceLocatorPatternDemo
    {
        public static void Start()
        {
            IService service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();
            service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();
        }
    }
}
