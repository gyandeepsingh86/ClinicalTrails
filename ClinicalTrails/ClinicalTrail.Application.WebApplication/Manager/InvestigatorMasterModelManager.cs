using ClinicalTrail.Application.WebApplication.Mapper;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace ClinicalTrail.Application.WebApplication.Manager
{
    public class InvestigatorMasterModelManager : IDisposable
    {
        private readonly InvestigatorMasterManager _investigatormastermanager;
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

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

        internal void CRUDInvestigatorMaster(List<InvestigatorMasterModel> investigatormastermodellist, string mode)
        {
            _investigatormastermanager.CRUDInvestigatorMaster(InvestigatorMasterModelMapper.Map(investigatormastermodellist), mode);
        }

        internal void DeleteInvestigatoMaster(int id)
        {
            _investigatormastermanager.DeleteInvestigatoMaster(id);
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        internal List<InvestigatorMasterModel> GetSearchResultForInvestigatorMaster(InvestigatorMasterModel searchlist)
        {
            return InvestigatorMasterModelMapper.Map(_investigatormastermanager.GetSearchResultForInvestigatorMaster(InvestigatorMasterModelMapper.Map(searchlist)));
        }
    }
}