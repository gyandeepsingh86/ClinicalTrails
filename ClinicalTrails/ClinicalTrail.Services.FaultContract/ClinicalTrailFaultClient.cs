using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Services.FaultContract
{
    /// <summary>
    /// Datacontract to bring client exception through the wire (to the client).
    /// </summary>

    [DataContract]
    public class ClinicalTrailFaultClient
    {
        [DataMember]
        public List<string> ExceptionMessages { get; set; }

        public ClinicalTrailFaultClient(List<string> exceptionmessages)
        {
            ExceptionMessages = exceptionmessages;
        }
    }
}
