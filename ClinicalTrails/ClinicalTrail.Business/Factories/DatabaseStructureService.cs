using ClinicalTrail.Business.ServiceInterfaces;
using ClinicalTrail.Business.ServiceManagers;
using ClinicalTrail.GeneralObjectStore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Factories
{
    public static class DatabaseStructureService
    {
        public static ICityMasterManager GetDatabaseType(DataSources datasource)
        {
            switch (datasource)
            {
                case DataSources.SQLServer:
                    return new CityMasterServiceManager();
                case DataSources.ORACLE:
                    return null;
                default:
                    return null;
            }
        }
    }
}
