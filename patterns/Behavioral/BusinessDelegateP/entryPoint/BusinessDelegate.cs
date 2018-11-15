using System;
using patterns.Behavioral.BusinessDelegateP.services;

namespace patterns.Behavioral.BusinessDelegateP.entryPoint
{
    public class BusinessDelegate
    {
        private BusinessLookUp _lookupService = new BusinessLookUp();
        private IBusinessService _businessService;
        public string ServiceType { get; set; }

        public void DoTask(){
            _businessService = _lookupService.GetBusinessService(ServiceType);
            _businessService.DoProcessing();
        }
    }
}
