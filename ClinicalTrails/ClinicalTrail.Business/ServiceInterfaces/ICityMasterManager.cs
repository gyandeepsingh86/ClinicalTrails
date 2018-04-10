using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Interfaces;
using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.ServiceInterfaces
{
    public interface ICityMasterManager : ILogManager
    {
        List<CityMasterDto> GetAllCityMasterData();

        CityMasterDto GetCityByCityID(int cityid);

        CityMasterDto GetStateForCityID(int cityid);

        CountryMasterDto GetAllCountryForCityandState(CityMaster citymaster);
    }
}
