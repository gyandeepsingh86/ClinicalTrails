using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class VendorMasterModelManager
    {
        private VendorMasterManager _Vendormanager;

        public VendorMasterModelManager()
        {
            _Vendormanager = new VendorMasterManager();
        }

        public List<VendorMasterModel> getVendorManagers()
        {
            return VendorMasterModelMapper.Map(_Vendormanager.GetAllVendorMaster());
        }

        internal void AddVendorManager(VendorMasterModel Vendormastermodel, string Userid)
        {
            _Vendormanager.AddVendorManager(VendorMasterModelMapper.Map(Vendormastermodel));
         }

        internal VendorMasterModel GetVendorManager(int CentNo)
        {
            return VendorMasterModelMapper.Map(_Vendormanager.GetVendorManager(CentNo));
        }

        internal List<VendorMasterModel> FilterVendorManager(VendorMasterModel Vendormastermodel)
        {
            return VendorMasterModelMapper.Map(_Vendormanager.FilterVendorManager(VendorMasterModelMapper.Map(Vendormastermodel)));
        }

        internal bool DeleteVendorManager(int centno)
        {
            return _Vendormanager.DeleteVendorManager(centno);
        }

        internal void AddVendorManager(List<VendorMasterModel> excellist, string username)
        {
            _Vendormanager.AddVendorManager(VendorMasterModelMapper.Map(excellist));
        }
    }
}