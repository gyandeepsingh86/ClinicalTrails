using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class UserMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public UserMasterFactory()
        {
            _context = new ClinicalTrialsDBEntities();
        }

        public List<UserMaster> GetAllUserMaster()
        {
            var um = from resp in _context.UserMasters
                                  select resp;
            return um.ToList();
        }
    }
}
