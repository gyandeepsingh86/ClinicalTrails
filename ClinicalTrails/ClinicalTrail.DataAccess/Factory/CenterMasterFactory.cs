using ClinicalTrail.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.DataAccess.Factory
{
    public class CenterMasterFactory
    {
        private readonly ClinicalTrialsDBEntities _context;

        public CenterMasterFactory(ClinicalTrialsDBEntities entities)
        {
            _context = entities;
        }

        public List<CenterMaster> GetAllCenterMaster()
        {
            var cm = from resp in _context.CenterMasters
                     select resp;

            return cm.ToList();
        }

        public void AddCenterManager(CenterMaster centermanager)
        {
            _context.CenterMasters.Add(centermanager);
            _context.SaveChanges();
        }
    }
}
