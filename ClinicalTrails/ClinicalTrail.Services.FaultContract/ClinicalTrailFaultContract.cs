using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClinicalTrail.Services.FaultContract
{
    /// <summary>
    /// Datacontract to bring exception through the wire (to the client).
    /// </summary>

    [DataContract]
    public class ClinicalTrailFaultContract
    {
        [DataMember]
        public string ExceptionMessage { get; set; }

        public ClinicalTrailFaultContract(string exceptionmessage)
        {
            ExceptionMessage = exceptionmessage;
        }
    }
}
