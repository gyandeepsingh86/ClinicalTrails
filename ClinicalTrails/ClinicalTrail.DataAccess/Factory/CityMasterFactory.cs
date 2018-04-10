using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class CityMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public CityMasterFactory()
        {
            _context = new ClinicalTrialsDBEntities();
        }

        public List<CityMaster> GetAllCityMaster()
        {
            var cm = from resp in _context.CityMasters
                     select resp;

            return cm.ToList();
        }

        internal CityMaster GetCityByID(int cityid)
        {
            var cm = from resp in _context.CityMasters
                     where resp.ID == cityid
                     select resp;

            return cm.FirstOrDefault();
        }

        internal CityMaster GetStateByCityID(int stateid)
        {
            var cm = from resp in _context.CityMasters
                     where resp.StateID == stateid
                     select resp;

            return cm.FirstOrDefault();
        }

        internal CountryMaster GetCountryByCityandStateID(CityMaster citymaster)
        {
            var cm = from resp in _context.CountryMasters
                     join tblstatemaster in _context.StateMasters on resp.ID equals tblstatemaster.CountryID
                     where tblstatemaster.ID == citymaster.StateID
                     select resp;

            return cm.FirstOrDefault();
        }
    }
}
