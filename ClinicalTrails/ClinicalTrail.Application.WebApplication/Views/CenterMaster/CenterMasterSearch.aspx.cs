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

namespace ClinicalTrail.Application.WebApplication.Views.CenterMaster
{
    public partial class CenterMasterSearch : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private CenterMasterModel centermastermodel { get; set; }
        private readonly CenterMasterModelManager _centermastermanagermodel;

        public CenterMasterSearch()
        {
            _centermastermanagermodel = new CenterMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCenterMasterModel();
            grvCenterMasterSearch.DataSource = _centermastermanagermodel.FilterCenterManager(centermastermodel);
            grvCenterMasterSearch.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        public void LoadCenterMasterModel()
        {
            try
            {
                centermastermodel = new CenterMasterModel();
                centermastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text ?? "";
                centermastermodel.Center_Name = txtCenterName.Text ?? "";
                centermastermodel.Center_No = string.IsNullOrEmpty(txtCenterNumber.Text) ? -1 : Convert.ToInt32(txtCenterNumber.Text);
                centermastermodel.Center_Type = txtCenterType.Text ?? "";
                centermastermodel.City = txtCity.Text ?? "";
                centermastermodel.Country = txtCountry.Text ?? "";
                centermastermodel.Email = txtEmail.Text ?? "";
                centermastermodel.Equipments = txtEquipments.Text ?? "";
                centermastermodel.Investigator_1 = txtInvestigator1.Text ?? "";
                centermastermodel.Investigator_2 = txtInvestigator2.Text ?? "";
                centermastermodel.Investigator_3 = txtInvestigator3.Text ?? "";
                centermastermodel.Mobile_Phone = txtMobilePhone.Text ?? "";
                centermastermodel.Office_Phone = txtOfficePhone.Text ?? "";
                centermastermodel.Payee_Name = txtPayeeName.Text ?? "";
                centermastermodel.Post_code = txtPostcode.Text ?? "";
                centermastermodel.Primary_Email = txtPrimaryEmail.Text ?? "";
                centermastermodel.Secondary_Email = txtSecondaryEmail.Text ?? "";
                centermastermodel.Specialties = txtSpecialties.Text ?? "";
                centermastermodel.State = txtState.Text ?? "";
                centermastermodel.Street_Address = txtStreetAddress.Text ?? "";
                centermastermodel.Website = txtWebsite.Text ?? "";

            }
            catch (Exception ex)
            {
                Logger.Error("CM000003|Error With Center Manager Search :" + ex.InnerException.ToString());
            }
        }

        protected void grvCenterMasterSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCenterMasterSearch.PageIndex = e.NewPageIndex;
            LoadCenterMasterModel();
            grvCenterMasterSearch.DataSource = _centermastermanagermodel.FilterCenterManager(centermastermodel);
            grvCenterMasterSearch.DataBind();
        }
    }
}