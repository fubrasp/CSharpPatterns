using System;
namespace patterns.Behavioral.BusinessDelegateP.services
{
    public class MailService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking Mail Service");
        }
    }
}
