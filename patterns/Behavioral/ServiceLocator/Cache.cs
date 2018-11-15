using System;
using System.Collections.Generic;
using patterns.Behavioral.ServiceLocator.services;

namespace patterns.Behavioral.ServiceLocator
{
    public class Cache
    {
        private List<IService> _services; 

        public Cache()
        {
            _services = new List<IService>();
        }

        public IService GetService(String serviceName)
        {

            foreach (IService service in _services)
            {
                if (string.Equals(service.GetName(), serviceName))
                {
                    Console.WriteLine($"Returning cached {serviceName} object");
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            bool exists = false;

            foreach (IService service in _services)
            {
                if (string.Equals(service.GetName(),newService.GetName()))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                _services.Add(newService);
            }
        }
    }
}
