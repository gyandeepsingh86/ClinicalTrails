using ClinicalTrail.DataAccess.Model;
using ClinicalTrail.GeneralObjectStore.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.ServiceManagers
{
    public class SQLServerBaseManager : IDisposable
    {
        protected readonly ClinicalTrialsDBEntities _context;
        protected readonly ILogger _logger;

        public SQLServerBaseManager(ClinicalTrialsDBEntities entity, ILogger log)
        {
            _context = entity;
            _logger = log;
        }

        public SQLServerBaseManager()
        {
            _context = new ClinicalTrialsDBEntities();
            _logger = LoggerFactory.CreateLogger();
            _logger.Initialize(this.ToString());
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
