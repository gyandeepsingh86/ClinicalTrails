using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class InvestigatorMasterModelManager
    {
        private readonly InvestigatorMasterManager _investigatormastermanager;

        public InvestigatorMasterModelManager()
        {
            _investigatormastermanager = new InvestigatorMasterManager();
        }

        public List<InvestigatorMasterModel> GetAllInvestigatorMasterList()
        {
            return InvestigatorMasterModelMapper.Map(_investigatormastermanager.GetInvestigatorMasterList());
        }

        public InvestigatorMasterModel GetInvestigatorMasterByID(int id)
        {
            return InvestigatorMasterModelMapper.Map(_investigatormastermanager.GetInvestigatorMasterByID(id));
        }

        internal void CRUDInvestigatorMaster(InvestigatorMasterModel investigatormastermodel, string mode)
        {
            _investigatormastermanager.CRUDInvestigatorMaster(InvestigatorMasterModelMapper.Map(investigatormastermodel), mode);
        }
    }
}