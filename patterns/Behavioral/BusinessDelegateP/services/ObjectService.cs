using System;
namespace patterns.Behavioral.BusinessDelegateP.services
{
    public class ObjectService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking Object Service");
        }
    }
}
