using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Services.MessageContracts
{
    [MessageContract]
    public class VoidResponse
    {
    }

    [MessageContract]
    public class GetAllCity_Response
    {
        [MessageBodyMember(Order = 0)]
        public int ID { get; set; }
        [MessageBodyMember(Order = 1)]
        public string Name { get; set; }
        [MessageBodyMember(Order = 2)]
        public int? StateId { get; set; }
    }

    [MessageContract]
    public class GetAllState_Response
    {
        [MessageBodyMember(Order = 0)]
        public int ID { get; set; }
        [MessageBodyMember(Order = 1)]
        public string Name { get; set; }
        [MessageBodyMember(Order = 2)]
        public int? StateId { get; set; }
    }

    [MessageContract]
    public class GetAllCountry_Response
    {
    }
}
