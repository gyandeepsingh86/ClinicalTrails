using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class CenterMasterModelManager
    {
        private CenterMasterManager _centermanager;
        public CenterMasterModelManager()
        {
            _centermanager = new CenterMasterManager();
        }

        public List<CenterMasterModel> getCenterManagers()
        {
            return CenterMasterModelMapper.Map(_centermanager.GetAllCenterMaster());
        }

        internal void Add(CenterMasterModel centermastermodel, string Userid)
        {
            _centermanager.Add(CenterMasterModelMapper.Map(centermastermodel));
         }

        internal CenterMasterModel GetCenterManager(int CentNo)
        {
            return CenterMasterModelMapper.Map(_centermanager.GetCenterManager(CentNo));
        }
    }
}