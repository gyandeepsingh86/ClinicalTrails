using ClinicalTrail.Business.DataContract;
using ClinicalTrail.Business.Mappers;
using ClinicalTrail.DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.Business.Managers
{
    public class CenterMasterManager : Manager
    {
         private readonly CenterMasterFactory _centermasterfactory;

         public CenterMasterManager()
        {
            _centermasterfactory = new CenterMasterFactory(_context);
        }

        public List<CenterMasterDto> GetAllCenterMaster()
        {
            return CenterMasterMapper.Map(_centermasterfactory.GetAllCenterMaster());
        }

        public void Add(CenterMasterDto centermanagerlist)
        {
            _centermasterfactory.AddCenterManager(CenterMasterMapper.Map(centermanagerlist));
        }

        public CenterMasterDto GetCenterManager(int CentNo)
        {
            return CenterMasterMapper.Map(_centermasterfactory.GetCenterManager(CentNo));
        }

        public List<CenterMasterDto> FilterCenterManager(CenterMasterDto centerMasterDto)
        {
            return CenterMasterMapper.Map(_centermasterfactory.FilterCenterManager(CenterMasterMapper.Map(centerMasterDto)));
        }

        public bool DeleteCenterManager(int centno)
        {
            return _centermasterfactory.DeleteCenterManager(centno);
        }
    }
}
