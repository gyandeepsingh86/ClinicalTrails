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
    public class InvestigatorMasterManager
    {
        private readonly InvestigatorMasterFactory _factory;

        public InvestigatorMasterManager()
        {
            _factory = new InvestigatorMasterFactory();
        }

        public List<InvestigatorMasterDto> GetInvestigatorMasterList()
        {
            return InvestigatorMasterMapper.Map(_factory.GetAllInvestigatorMasterList());
        }

        public InvestigatorMasterDto GetInvestigatorMasterByID(int id)
        {
            return InvestigatorMasterMapper.Map(_factory.GetInvestigatorMasterByID(id));
        }

        public void CRUDInvestigatorMaster(InvestigatorMasterDto investigatormasterdto, string mode)
        {
            _factory.CRUDInvestigatorMaster(InvestigatorMasterMapper.Map(investigatormasterdto), mode);
        }

        public void DeleteInvestigatoMaster(int id)
        {
            _factory.DeleteInvestigatoMaster(id);
        }

        public void CRUDInvestigatorMaster(List<InvestigatorMasterDto> investigatormasterdtolist, string mode)
        {
            foreach (InvestigatorMasterDto dto in investigatormasterdtolist)
            {
                _factory.CRUDInvestigatorMaster(InvestigatorMasterMapper.Map(dto), mode);
            }
        }

        public List<InvestigatorMasterDto> GetSearchResultForInvestigatorMaster(InvestigatorMasterDto searchlist)
        {
            return InvestigatorMasterMapper.Map(_factory.GetSearchResultForInvestigatorMaster(InvestigatorMasterMapper.Map(searchlist)));
        }
    }
}
