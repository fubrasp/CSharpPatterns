using System;
namespace patterns.Behavioral.ServiceLocator.services
{
    public class Service1 : IService
    {
        public Service1()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string GetName()
        {
            return "Service1";
        }
    }
}
