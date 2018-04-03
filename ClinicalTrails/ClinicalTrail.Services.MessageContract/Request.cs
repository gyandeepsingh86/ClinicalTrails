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
        [MessageBodyMember(Order = 0)]
        public Guid AuthenticationUser { get; set; }
    }

    [MessageContract]
    public abstract class VoidRequest : BaseRequest
    {
    }

    [MessageContract]
    public abstract class ExtractAllCity : BaseRequest
    {
        [MessageBodyMember(Order = 0)]
        public List<CityMasterDto> CityList { get; set; }
    }

    [MessageContract]
    public abstract class ExtractAllState : BaseRequest
    {
        [MessageBodyMember(Order = 0)]
        public List<StateMasterDto> CityList { get; set; }
    }

    [MessageContract]
    public abstract class ExtractAllCountry : BaseRequest
    {
        [MessageBodyMember(Order = 0)]
        public List<CountryMasterDto> CityList { get; set; }
    }
}
