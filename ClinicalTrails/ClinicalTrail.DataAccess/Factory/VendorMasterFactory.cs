using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class VendorMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public VendorMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }
    }
}
