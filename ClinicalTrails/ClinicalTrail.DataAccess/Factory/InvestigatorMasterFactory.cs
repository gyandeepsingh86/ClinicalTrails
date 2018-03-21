using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrail.DataAccess.Model;

namespace ClinicalTrail.DataAccess.Factory
{
    public class InvestigatorMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public InvestigatorMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }
    }
}
