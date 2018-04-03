using ClinicalTrail.Services.MessageContracts;
using ClinicalTrail.Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Services.ServiceImplementation
{
    public class ClinicalTrailsWCFServices : IClinicalTrailsWCFServices
    {
        public VoidResponse TestConnection(VoidRequest req)
        {
            throw new NotImplementedException();
        }

        public ExtractAllCityResponse ExtractAllCityService(ExtractAllCity extractallcityrequest)
        {
            throw new NotImplementedException();
        }

        public ExtractAllStateResponse ExtractAllStateService(ExtractAllState extractallstaterequest)
        {
            throw new NotImplementedException();
        }

        public ExtractAllCountryResponse ExtractAllCountryService(ExtractAllCountry extractallcountryrequest)
        {
            throw new NotImplementedException();
        }
    }
}
