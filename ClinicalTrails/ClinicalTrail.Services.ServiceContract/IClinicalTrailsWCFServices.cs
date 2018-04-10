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
        GetAllCity_Response GetAllCity(GetAllCity_Request req);

        [OperationContract]
        [FaultContract(typeof(ClinicalTrailFaultContract))]
        GetAllState_Response GetAllState(GetAllState_Request request);

        [OperationContract]
        [FaultContract(typeof(ClinicalTrailFaultContract))]
        GetAllCountry_Response GetAllCountry(GetAllCountry_Request request);
    }
}
