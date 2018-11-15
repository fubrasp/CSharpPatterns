using System;
using patterns.Behavioral.BusinessDelegateP.entryPoint;

namespace patterns.Behavioral.BusinessDelegateP
{
    public static class BusinessDelegatePatternDemo
    {
        public static void Start(){
            patterns.Behavioral.BusinessDelegateP.entryPoint.BusinessDelegate businessDelegate = new patterns.Behavioral.BusinessDelegateP.entryPoint.BusinessDelegate();
            businessDelegate.ServiceType="Object";

            Client client = new Client(businessDelegate);
            client.DoTask();

            businessDelegate.ServiceType="Mail";
            client.DoTask();
        }
    }
}
