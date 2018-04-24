using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.Application.WebApplication.Manager;
using ClinicalTrail.Application.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicalTrail.Application.WebApplication.Controllers
{
    public class InvestigatorMasterController : Controller
    {
        // GET: InvestigatorMaster
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private readonly InvestigatorMasterModelManager _investigatormastermodelmanager;
        public readonly AddressTypeModelManager _addressTypeManger;
        InvestigatorMasterModel _investigatormastermodel;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchInvestigator()
        {
            using (InvestigatorMasterModelManager _investigatormastermodelmanager = new InvestigatorMasterModelManager())
            {
                var investigatormastermodelmanager = _investigatormastermodelmanager.GetAllInvestigatorMasterList();
                return Json(new { data = investigatormastermodelmanager }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Search(InvestigatorMasterModel searchlist)
        {
            using (InvestigatorMasterModelManager _investigatormastermodelmanager = new InvestigatorMasterModelManager())
            {
                var investigatormastermodelmanager = _investigatormastermodelmanager.GetSearchResultForInvestigatorMaster(searchlist);
                return View(investigatormastermodelmanager);
            }
        }
    }
}