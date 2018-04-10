using ClinicalTrail.Application.WebApplication.ClinicalTrailServiceReferance;
using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using ClinicalTrail.Business.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Windows.Forms;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class CityMasterModelManager
    {
        private readonly CityMasterManager _citymastermanger;

        public CityMasterModelManager()
        {
            _citymastermanger = new CityMasterManager();
        }

        internal List<CityMasterModel> GetAllCityMaster()
        {
            return CityMasterModelMapper.Map(_citymastermanger.GetAllCityMaster());
        }

        internal List<CityMasterModel> GetAllCityMasterFromService()
        {
            //GetAllState_Response resp;
            //using (ClinicalTrailsWCFServicesClient client = new ClinicalTrailsWCFServicesClient())
            //{
            //    GetAllState_Request request = new GetAllState_Request();
            //    request.Cityid = 1;
            //    //request.
            //    //var v = client.GetAllState()
            //}
            return null;
        }

        internal CityMasterModel GetStateByCityID()
        {
            CityMasterModel state =null;

            try
            {
                ClinicalTrailsWCFServicesClient client = new ClinicalTrailsWCFServicesClient();
                GetAllState_Request req = new GetAllState_Request(1, "Name", 5);
                GetAllState_Response resp = client.GetAllState(req);
                state = CityMasterModelMapper.Map(resp);
                MessageBox.Show("Done");
                return state;
            }
            catch(FaultException ex)
            {
                string msg = "FaultException: " + ex.Message;
                MessageFault fault = ex.CreateMessageFault();
                if (fault.HasDetail == true)
                {
                    System.Xml.XmlReader reader = fault.GetReaderAtDetailContents();
                    if (reader.Name == "ExceptionDetail")
                    {
                        ExceptionDetail detail = fault.GetDetail<ExceptionDetail>();
                        msg += "\n\nStack Trace: " + detail.StackTrace;
                    }
                }
                MessageBox.Show(msg);
                return state;
            }
        }
    }
}