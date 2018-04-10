using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Factories;
using ClinicalTrail.Business.ServiceInterfaces;
using ClinicalTrail.Services.MessageContracts;
using ClinicalTrail.Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Services.ServiceImplementation
{
    public class ClinicalTrailsWCFServices : IClinicalTrailsWCFServices
    {
        public VoidResponse TestConnection(VoidRequest req)
        {
            return new VoidResponse();
        }

        public GetAllCity_Response GetAllCity(GetAllCity_Request req)
        {
            ICityMasterManager icm = DatabaseStructureService.GetDatabaseType(ClinicalTrail.GeneralObjectStore.Enums.DataSources.SQLServer);
            try
            {
                GetAllCity_Response resp = new GetAllCity_Response();
                List<CityMasterDto> cmdtolist = icm.GetAllCityMasterData();

                if (cmdtolist != null && cmdtolist.Count > 0)
                {
                    foreach (CityMasterDto cmdto in cmdtolist)
                    {
                        resp.ID = cmdto.ID;
                        resp.Name = cmdto.Name;
                        resp.StateId = cmdto.StateID;
                    }
                }
                return resp;
            }
            catch (Exception ex)
            {
                throw Error.HandleException(ex, icm.GetLogger(), "Admin");
            }
        }

        public GetAllState_Response GetAllState(GetAllState_Request request)
        {
            ICityMasterManager icm = DatabaseStructureService.GetDatabaseType(ClinicalTrail.GeneralObjectStore.Enums.DataSources.SQLServer);
            try
            {
                GetAllState_Response eacresp = new GetAllState_Response();
                CityMasterDto cmdto = icm.GetStateForCityID(request.ID);

                if (cmdto != null)
                {
                    eacresp.ID = cmdto.ID;
                    eacresp.Name = cmdto.Name;
                    eacresp.StateId = cmdto.StateID;
                }
                return eacresp;
            }
            catch (Exception ex)
            {
                throw Error.HandleException(ex, icm.GetLogger(), "Admin");
            }
        }

        public GetAllCountry_Response GetAllCountry(GetAllCountry_Request request)
        {
            throw new NotImplementedException();
        }

        public GetAllCity_Response GetAllCity()
        {
            throw new NotImplementedException();
        }
    }
}
