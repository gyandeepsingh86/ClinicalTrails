using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.Application.WebApplication.Manager;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.GeneralObjectStore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalTrail.Application.WebApplication.Views.VendorMaster
{
    public partial class VendorMasterSearch : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private VendorMasterModel Vendormastermodel { get; set; }
        private readonly VendorMasterModelManager _Vendormastermanagermodel;

        public VendorMasterSearch()
        {
            _Vendormastermanagermodel = new VendorMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LoadVendorMasterModel();
            grvVendorMasterSearch.DataSource = _Vendormastermanagermodel.FilterVendorManager(Vendormastermodel);
            grvVendorMasterSearch.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        public void LoadVendorMasterModel()
        {
            try
            {
                Vendormastermodel = new VendorMasterModel();
                Vendormastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text ?? "";
                Vendormastermodel.Vendor_Name = txtVendorName.Text ?? "";
                Vendormastermodel.Vendor_No = string.IsNullOrEmpty(txtVendorNumber.Text) ? -1 : Convert.ToInt32(txtVendorNumber.Text);
                Vendormastermodel.Vendor_Type = txtVendorType.Text ?? "";
                Vendormastermodel.City = txtCity.Text ?? "";
                Vendormastermodel.Country = txtCountry.Text ?? "";
                Vendormastermodel.Email = txtEmail.Text ?? "";
                Vendormastermodel.Equipments = txtEquipments.Text ?? "";
                Vendormastermodel.Mobile_Phone = txtMobilePhone.Text ?? "";
                Vendormastermodel.Office_Phone = txtOfficePhone.Text ?? "";
                Vendormastermodel.Payee_Name = txtPayeeName.Text ?? "";
                Vendormastermodel.Post_code = txtPostcode.Text ?? "";
                Vendormastermodel.Primary_Email = txtPrimaryEmail.Text ?? "";
                Vendormastermodel.Secondary_Email = txtSecondaryEmail.Text ?? "";
                Vendormastermodel.Specialties = txtSpecialties.Text ?? "";
                Vendormastermodel.State = txtState.Text ?? "";
                Vendormastermodel.Street_Address = txtStreetAddress.Text ?? "";
                Vendormastermodel.Website = txtWebsite.Text ?? "";
                Vendormastermodel.IsActive = chkIsActive.Checked;

            }
            catch (Exception ex)
            {
                Logger.Error("CM000003|Error With Vendor Manager Search :" + ex.InnerException.ToString());
            }
        }

        protected void grvVendorMasterSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvVendorMasterSearch.PageIndex = e.NewPageIndex;
            LoadVendorMasterModel();
            grvVendorMasterSearch.DataSource = _Vendormastermanagermodel.FilterVendorManager(Vendormastermodel);
            grvVendorMasterSearch.DataBind();
        }
    }
}