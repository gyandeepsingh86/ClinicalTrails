using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Mappers;
using ClinicalTrail.DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Managers
{
    public class CityMasterManager : Manager
    {
        private readonly CenterMasterFactory _centermasterfactory;

        public CityMasterManager()
        {
            _centermasterfactory = new CenterMasterFactory(_context);
        }

        public List<CityMasterDto> GetAllCityMaster()
        {
            return CityMasterMapper.Map(_centermasterfactory.GetAllCityMaster());
        }
    }
}
