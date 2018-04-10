using ClinicalTrail.Business.DataContract;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Mappers
{
    public class CityMasterMapper
    {
        internal static List<CityMasterDto> Map(List<CityMaster> list)
        {
            var to = from c in list
                     select Map(c);

            return to.ToList();
        }

        internal static CityMasterDto Map(CityMaster citymaster)
        {
            var to = new CityMasterDto();

            to.ID = citymaster.ID;
            to.Name = citymaster.Name;
            to.StateID = citymaster.StateID;

            return to;
        }
    }
}
