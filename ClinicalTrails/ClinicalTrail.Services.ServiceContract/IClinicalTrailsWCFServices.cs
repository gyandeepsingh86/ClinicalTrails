using ClinicalTrail.Services.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrail.Services.FaultContract;

namespace ClinicalTrail.Services.ServiceContracts
{
    [ServiceContract]
    public interface IClinicalTrailsWCFServices
    {
        [OperationContract]
        VoidResponse TestConnection(VoidRequest req);

        [OperationContract]
        [FaultContract(typeof(ClinicalTrailFaultContract))]
        ExtractAllCityResponse ExtractAllCityService(ExtractAllCity extractallcityrequest);

        [OperationContract]
        [FaultContract(typeof(ClinicalTrailFaultContract))]
        ExtractAllStateResponse ExtractAllStateService(ExtractAllState extractallstaterequest);

        [OperationContract]
        [FaultContract(typeof(ClinicalTrailFaultContract))]
        ExtractAllCountryResponse ExtractAllCountryService(ExtractAllCountry extractallcountryrequest);
    }
}
