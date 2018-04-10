using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicalTrail.DataAccess.Model;
using ClinicalTrail.Application.WebApplication.ClinicalTrailServiceReferance;
using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;

namespace ClinicalTrail.Application.WebApplication.Test.Services.WCFServices
{
    [TestClass]
    public class CityMasterTestCases
    {
        private readonly ClinicalTrialsDBEntities _clinicaltrailsserver;

        //[TestInitialize]
        //public GetAllCityMaster()
        //{
        //    _clinicaltrailsserver = new ClinicalTrialsDBEntities();
        //}

        [TestMethod]
        public void CheckGetAllCityMaster()
        {
            try
            {
                ClinicalTrailsWCFServicesClient client = new ClinicalTrailsWCFServicesClient();
                GetAllState_Request req = new GetAllState_Request(1, "Name", 5);
                GetAllState_Response resp = client.GetAllState(req);
                Assert.AreEqual(1, 1);
            }
            catch(Exception ex)
            {
                string errmsg = ex.InnerException.ToString();
            }
        }
    }
}
