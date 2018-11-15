using System;
using patterns.Behavioral.BusinessDelegateP.entryPoint;
namespace patterns.Behavioral.BusinessDelegateP
{
    public class Client
    {
        patterns.Behavioral.BusinessDelegateP.entryPoint.BusinessDelegate _businessService; 

        public Client(patterns.Behavioral.BusinessDelegateP.entryPoint.BusinessDelegate businessDelegate)
        {
            _businessService = businessDelegate;
        }

        public void DoTask(){
            _businessService.DoTask();
        }
    }
}
