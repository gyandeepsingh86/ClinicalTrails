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
    public partial class InvestigatorMaster : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private readonly InvestigatorMasterModelManager _investigatormastermodelmanager;
        public readonly AddressTypeModelManager _addressTypeManger;
        InvestigatorMasterModel investigatormastermodel;

        public InvestigatorMaster()
        {
            _addressTypeManger = new AddressTypeModelManager();
            _investigatormastermodelmanager = new InvestigatorMasterModelManager();
        }

        #region "Page Events"

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllAddressType();
                LoadAllInvertorMastertoGrid();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SetInvestigatorModel();
            _investigatormastermodelmanager.CRUDInvestigatorMaster(investigatormastermodel, "Update");
            LoadAllInvertorMastertoGrid();
            GetAllAddressType();
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SetInvestigatorModel();
            _investigatormastermodelmanager.CRUDInvestigatorMaster(investigatormastermodel, "Add");
            LoadAllInvertorMastertoGrid();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region "Common Function"

        public void GetAllAddressType()
        {
            ddlAddressType.DataSource = GetAddressTypeList();
            ddlAddressType.DataValueField = "AddressTypeID";
            ddlAddressType.DataTextField = "AddressTypeName";
            ddlAddressType.DataBind();

            ddlAddressType.Items.Insert(0, new ListItem("Select Address Type", "0"));
        }

        private List<AddressTypeModel> GetAddressTypeList()
        {
            return _addressTypeManger.GetAddressTypeList();
        }

        private void LoadAllInvertorMastertoGrid()
        {
            GetAllInvestorMasterList();
        }

        private void GetAllInvestorMasterList()
        {
            grvInvestigatorMaster.DataSource = _investigatormastermodelmanager.GetAllInvestigatorMasterList();
            grvInvestigatorMaster.DataBind();
        }

        /// <summary>
        /// Set the Invertigator Model Data for all purpose like save update edit
        /// </summary>
        private void SetInvestigatorModel()
        {
            investigatormastermodel = new InvestigatorMasterModel();
            investigatormastermodel.Address_Type = ddlAddressType.SelectedItem.Text;
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
            investigatormastermodel.ID = string.IsNullOrEmpty(txtInvestigatorID.Text) ? 0 : Convert.ToInt32(txtInvestigatorID.Text);
            investigatormastermodel.Institute_Name = txtInstituteName.Text;
            investigatormastermodel.Investigator_First_Name = txtInvestigatorFName.Text;
            investigatormastermodel.Investigator_Last_Name = txtInvestigatorLName.Text;
            investigatormastermodel.Investigator_Middle_Name = txtInvestigatorMName.Text;
            investigatormastermodel.IsActive = true;
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

        private void EditInvestorMasterList(string id)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                investigatormastermodel = _investigatormastermodelmanager.GetInvestigatorMasterByID(ID);
                SetInvestigatorMasterModel(investigatormastermodel);
                LoadAllInvertorMastertoGrid();
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            catch (Exception ex)
            {
                Logger.Error("IM000001|Error while editing Center Master Details: " + ex.InnerException.InnerException);
            }
        }

        private void SetInvestigatorMasterModel(InvestigatorMasterModel investigatormastermodel)
        {
            txtInvestigatorID.Text = investigatormastermodel.ID.ToString();
            ddlAddressType.SelectedItem.Text = investigatormastermodel.Address_Type.ToString();
            txtBankAccountNumbervarchar.Text = investigatormastermodel.Bank_Account_Number;
            txtCenter1.Text = investigatormastermodel.Centre_1;
            txtCenter2.Text = investigatormastermodel.Centre_2;
            txtCenter3.Text = investigatormastermodel.Centre_3;
            txtCertification.Text = investigatormastermodel.Certification;
            txtCity.Text = investigatormastermodel.City;
            txtCountry.Text = investigatormastermodel.Country;
            txtDegree.Text = investigatormastermodel.Degree;
            txtEmail.Text = investigatormastermodel.Email_ID;
            txtFaxNo.Text = investigatormastermodel.Fax_No;
            txtInstituteName.Text = investigatormastermodel.Institute_Name;
            txtInvestigatorFName.Text = investigatormastermodel.Investigator_First_Name;
            txtInvestigatorLName.Text = investigatormastermodel.Investigator_Last_Name;
            txtInvestigatorMName.Text = investigatormastermodel.Investigator_Middle_Name;
            txtMobilePhone.Text = investigatormastermodel.Mobile_Phone;
            txtOfficePhone.Text = investigatormastermodel.Office_Phone;
            txtPayeeName.Text = investigatormastermodel.Payee_Name;
            txtPostcode.Text = investigatormastermodel.Post_Code;
            txtPrimaryEmail.Text = investigatormastermodel.Primary_Email;
            txtSecondaryEmail.Text = investigatormastermodel.Secondary_Email_ID;
            txtSpecialties.Text = investigatormastermodel.Speciality;
            txtState.Text = investigatormastermodel.State;
            txtStreetAddress.Text = investigatormastermodel.Street_Address;
            txtInvestigatorTitle.Text = investigatormastermodel.Title;
        }

        #endregion

        #region "Grid Investigator Master Events"

        protected void grvInvestigatorMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvInvestigatorMaster.EditIndex = e.NewEditIndex;
            GetAllInvestorMasterList();
            EditInvestorMasterList(e.NewEditIndex.ToString());
        }

        protected void grvInvestigatorMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        #endregion
    }
}