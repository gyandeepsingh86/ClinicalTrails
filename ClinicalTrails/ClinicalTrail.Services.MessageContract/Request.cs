using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ClinicalTrail.Business.DataContract;

namespace ClinicalTrail.Services.MessageContracts
{
    [MessageContract]
    public abstract class BaseRequest
    {
        //[MessageBodyMember(Order = 0)]
        //public Guid AuthenticationUser { get; set; }
    }

    [MessageContract]
    public abstract class VoidRequest : BaseRequest
    {
    }

    [MessageContract]
    public abstract class GetAllCity_Request : BaseRequest
    {
        
    }

    [MessageContract]
    public abstract class GetAllState_Request: BaseRequest
    {
        [MessageBodyMember(Order = 0)]
        public int ID { get; set; }
        [MessageBodyMember(Order = 1)]
        public string Name { get; set; }
        [MessageBodyMember(Order = 2)]
        public int? StateId { get; set; }
    }

    [MessageContract]
    public abstract class GetAllCountry_Request: BaseRequest
    {
        //[MessageBodyMember(Order = 0)]
        //public List<CountryMasterDto> CityList { get; set; }
    }
}
