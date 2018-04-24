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

namespace ClinicalTrail.Application.WebApplication.Views.InvestigatorMaster
{
    public partial class InvestigatorMasterSearch : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private readonly InvestigatorMasterModelManager _investigatormastermodelmanager;
        public readonly AddressTypeModelManager _addressTypeManger;
        InvestigatorMasterModel investigatormastermodel;

        public InvestigatorMasterSearch()
        {
            _addressTypeManger = new AddressTypeModelManager();
            _investigatormastermodelmanager = new InvestigatorMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetAllAddressType();
                LoadAllInvertorMastertoGrid();
            }
        }

        private void LoadAllInvertorMastertoGrid()
        {
            grvInvestigatorMasterSearch.DataSource = _investigatormastermodelmanager.GetAllInvestigatorMasterList();
            grvInvestigatorMasterSearch.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SetInvestigatorModel();
            using (InvestigatorMasterModelManager _investigatormastermodelmanager = new InvestigatorMasterModelManager())
            {
                grvInvestigatorMasterSearch.DataSource = _investigatormastermodelmanager.GetSearchResultForInvestigatorMaster(investigatormastermodel);
                grvInvestigatorMasterSearch.DataBind();
            }
        }

        protected void grvInvestigatorMasterSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvInvestigatorMasterSearch.PageIndex = e.NewPageIndex;
            LoadAllInvertorMastertoGrid();
        }

        /// <summary>
        /// Set the Invertigator Model Data for all purpose like save update edit
        /// </summary>
        private void SetInvestigatorModel()
        {
            investigatormastermodel = new InvestigatorMasterModel();
            investigatormastermodel.Address_Type = ddlAddressType.SelectedIndex != 0 ? ddlAddressType.SelectedItem.Text : "";
            investigatormastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text;
            investigatormastermodel.Centre_1 = txtCenter1.Text;
            investigatormastermodel.Centre_2 = txtCenter2.Text;
            investigatormastermodel.Centre_3 = txtCenter3.Text;
            investigatormastermodel.Certification = txtCertification.Text;
            investigatormastermodel.City = txtCity.Text;
            investigatormastermodel.Country = txtCountry.Text;
            investigatormastermodel.Degree = txtDegree.Text;
            investigatormastermodel.Email_ID = txtEmail.Text;
            investigatormastermodel.Fax_No = txtFaxNo.Text;
            investigatormastermodel.ID = string.IsNullOrEmpty(txtInvestigatorID.Text) ? -1 : Convert.ToInt32(txtInvestigatorID.Text);
            investigatormastermodel.Institute_Name = txtInstituteName.Text;
            investigatormastermodel.Investigator_First_Name = txtInvestigatorFName.Text;
            investigatormastermodel.Investigator_Last_Name = txtInvestigatorLName.Text;
            investigatormastermodel.Investigator_Middle_Name = txtInvestigatorMName.Text;
            investigatormastermodel.IsActive = chkIsActive.Checked;
            investigatormastermodel.Mobile_Phone = txtMobilePhone.Text;
            investigatormastermodel.Office_Phone = txtOfficePhone.Text;
            investigatormastermodel.Payee_Name = txtPayeeName.Text;
            investigatormastermodel.Post_Code = txtPostcode.Text;
            investigatormastermodel.Primary_Email = txtPrimaryEmail.Text;
            investigatormastermodel.Secondary_Email_ID = txtSecondaryEmail.Text;
            investigatormastermodel.Speciality = txtSpecialties.Text;
            investigatormastermodel.State = txtState.Text;
            investigatormastermodel.Street_Address = txtStreetAddress.Text;
            investigatormastermodel.Title = txtInvestigatorTitle.Text;
        }

        public void GetAllAddressType()
        {
            ddlAddressType.DataSource = _addressTypeManger.GetAddressTypeList();
            ddlAddressType.DataValueField = "AddressTypeID";
            ddlAddressType.DataTextField = "AddressTypeName";
            ddlAddressType.DataBind();

            ddlAddressType.Items.Insert(0, new ListItem("Select Address Type", "0"));
        }
    }
}