using System;
using patterns.Behavioral.ServiceLocator.services;

namespace patterns.Behavioral.ServiceLocator
{
    public class ServiceLocator
    {
        private static Cache _cache = new Cache();
         
    public static IService GetService(String serviceNameInCommunicationBus)
    { 
        IService service = _cache.GetService(serviceNameInCommunicationBus);

        if (service != null)
        {
            return service;
        }

        InitialContext context = new InitialContext();
            IService service1 = (IService)context.Lookup(serviceNameInCommunicationBus);
        _cache.AddService(service1);
        return service1;
    }
}
}
