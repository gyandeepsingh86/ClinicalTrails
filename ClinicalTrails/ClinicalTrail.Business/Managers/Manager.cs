using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrail.DataAccess.Model;
using ClinicalTrail.GeneralObjectStore.Logger;
using AtlasCopco.Framework.Objects.Logging;

namespace ClinicalTrail.Business.Managers
{
    public abstract class Manager: IDisposable
    {
        protected ClinicalTrialsDBEntities _context;
        protected static ILogger Logger = LoggerFactory.GetLogger();

        protected Manager()
        {
            _context = new ClinicalTrialsDBEntities();
            Logger.Initialize("Manager");
        }

        protected Manager(ClinicalTrialsDBEntities entities, ILogger log)
        {
            _context = entities;
            Logger = log;
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
