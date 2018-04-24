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
    public class VendorMasterManager : Manager
    {
        private readonly VendorMasterFactory _Vendormasterfactory;

        public VendorMasterManager()
        {
            _Vendormasterfactory = new VendorMasterFactory(_context);
        }

        public List<VendorMasterDto> GetAllVendorMaster()
        {
            return VendorMasterMapper.Map(_Vendormasterfactory.GetAllVendorMaster());
        }

        public void AddVendorManager(VendorMasterDto Vendormanagerlist)
        {
            _Vendormasterfactory.AddVendorManager(VendorMasterMapper.Map(Vendormanagerlist));
        }

        public VendorMasterDto GetVendorManager(int CentNo)
        {
            return VendorMasterMapper.Map(_Vendormasterfactory.GetVendorManager(CentNo));
        }

        public List<VendorMasterDto> FilterVendorManager(VendorMasterDto VendorMasterDto)
        {
            return VendorMasterMapper.Map(_Vendormasterfactory.FilterVendorManager(VendorMasterMapper.Map(VendorMasterDto)));
        }

        public bool DeleteVendorManager(int centno)
        {
            return _Vendormasterfactory.DeleteVendorManager(centno);
        }

        public void AddVendorManager(List<VendorMasterDto> list)
        {
            foreach (VendorMasterDto dto in list)
            {
                _Vendormasterfactory.AddVendorManager(VendorMasterMapper.Map(dto));
            }
        }
    }
}
