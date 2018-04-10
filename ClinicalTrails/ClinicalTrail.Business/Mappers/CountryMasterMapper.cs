using ClinicalTrail.Business.DataContract;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class CountryMasterMapper
    {
        public CountryMasterMapper()
        {

        }

        internal static CountryMasterDto Map(CountryMaster countryMaster)
        {
            CountryMasterDto to = new CountryMasterDto();
            to.ID = countryMaster.ID;
            to.Name = countryMaster.Name;
            to.CountryCode = countryMaster.CountryCode;

            return to;
        }
    }
}
