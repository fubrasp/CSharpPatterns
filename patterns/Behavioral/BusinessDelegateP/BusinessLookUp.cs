using System;
using patterns.Behavioral.BusinessDelegateP.services;
namespace patterns.Behavioral.BusinessDelegateP
{
    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(String serviceType)
        {

            if (string.Equals(serviceType, "Object"))
            {
                return new ObjectService();
            }
            else
            {
                return new MailService();
            }
        }
    }
}
