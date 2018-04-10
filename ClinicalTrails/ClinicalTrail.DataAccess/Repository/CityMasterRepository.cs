using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrail.GeneralObjectStore.Logger;
using ClinicalTrail.DataAccess.Factory;
using ClinicalTrail.GeneralObjectStore.Controls;

namespace ClinicalTrail.DataAccess.Repository
{
    public class CityMasterRepository
    {
        private readonly ClinicalTrialsDBEntities _context;
        private readonly ILogger _logger;
        private readonly CityMasterFactory _citymasterfactory;

        public CityMasterRepository(ClinicalTrialsDBEntities entity, ILogger log)
        {
            _context = entity;
            _logger = log;
        }

        public List<CityMaster> GetAllCityMaster()
        {
            _logger.Debug(string.Format("SERVER|{0}|GetAllCityMaster()|START", ServerControl.GetCurentDatetime()));
            List<CityMaster> results = _citymasterfactory.GetAllCityMaster();
            _logger.Debug(string.Format("SERVER|{0}|GetAllCityMaster()|END", ServerControl.GetCurentDatetime()));
            return results;
        }

        public CityMaster GetCityByID(int cityid)
        {
            _logger.Debug(string.Format("SERVER|{0}|GetAllCityMaster()|START", ServerControl.GetCurentDatetime()));
            CityMaster results = _citymasterfactory.GetCityByID(cityid);
            _logger.Debug(string.Format("SERVER|{0}|GetAllCityMaster()|END", ServerControl.GetCurentDatetime()));
            return null;
        }

        public CityMaster GetStateByCityID(int cityid)
        {
            _logger.Debug(string.Format("SERVER|{0}|GetStateByID()|START", ServerControl.GetCurentDatetime()));
            CityMaster results = _citymasterfactory.GetCityByID(cityid);
            _logger.Debug(string.Format("SERVER|{0}|GetAllCityMaster()|END", ServerControl.GetCurentDatetime()));
            return null;
        }


        public CountryMaster GetCountryByCityandStateID(CityMaster citymaster)
        {
            _logger.Debug(string.Format("SERVER|{0}|GetCountryByCityandStateID()|START", ServerControl.GetCurentDatetime()));
            CountryMaster results = _citymasterfactory.GetCountryByCityandStateID(citymaster);
            _logger.Debug(string.Format("SERVER|{0}|GetCountryByCityandStateID()|END", ServerControl.GetCurentDatetime()));
            return null;
        }
    }
}
