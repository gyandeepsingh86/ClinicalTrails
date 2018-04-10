using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Mappers;
using ClinicalTrail.Business.ServiceInterfaces;
using ClinicalTrail.DataAccess.Factory;
using ClinicalTrail.DataAccess.Model;
using ClinicalTrail.DataAccess.Repository;
using ClinicalTrail.GeneralObjectStore.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.ServiceManagers
{
    public class CityMasterServiceManager : SQLServerBaseManager, ICityMasterManager
    {
        private readonly CityMasterRepository _citymasterrepositoryfactory;
        private readonly CityMasterFactory _citymasterfactory;
        public ILogger logger { get; set; }

        public CityMasterServiceManager()
        {
            _citymasterrepositoryfactory = new CityMasterRepository(_context, _logger);
            _citymasterfactory = new CityMasterFactory();
        }

        public List<CityMasterDto> GetAllCityMasterData()
        {
            List<CityMasterDto> result = CityMasterMapper.Map(_citymasterrepositoryfactory.GetAllCityMaster());
            return result;
        }

        public CityMasterDto GetCityByCityID(int cityid)
        {
            CityMasterDto result = CityMasterMapper.Map(_citymasterrepositoryfactory.GetCityByID(cityid));
            return result;
        }

        public CityMasterDto GetStateForCityID(int cityid)
        {
            CityMasterDto result = CityMasterMapper.Map(_citymasterrepositoryfactory.GetStateByCityID(cityid));
            return result;
        }

        public CountryMasterDto GetAllCountryForCityandState(CityMaster citymaster)
        {
            CountryMasterDto result = CountryMasterMapper.Map(_citymasterrepositoryfactory.GetCountryByCityandStateID(citymaster));
            return result;
        }

        public ILogger GetLogger()
        {
            return logger;
        }
    }
}
