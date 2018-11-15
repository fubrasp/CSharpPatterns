using System;
namespace patterns.Behavioral.ServiceLocator.services
{
    public class Service2 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service2");
        }

        public string GetName()
        {
            return "Service2";
        }
    }
}
