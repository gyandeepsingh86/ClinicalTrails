using ClinicalTrail.Application.WebApplication.Manager;
using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.Application.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicalTrail.GeneralObjectStore;
using ClinicalTrail.GeneralObjectStore.Extensions;

namespace ClinicalTrail.Application.WebApplication.Views.CenterMaster
{
    public partial class CenterMaster : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private CenterMasterModel centermastermodel { get; set; }
        private readonly CenterMasterModelManager _centermastermanagermodel;
        string Userid = "";

        #region "Page Event"

        public CenterMaster()
        {
            _centermastermanagermodel = new CenterMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCenterMaster();

            GetCityMasterList();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ControlClearing.ClearAllControls(this.Page.Form);
            divCenterNumberTab.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            LoadCenterMasterModel();
            _centermastermanagermodel.Add(centermastermodel, Userid);
            GetAllCenterMaster();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadCenterMasterModel();
            _centermastermanagermodel.Add(centermastermodel, Userid);
            GetAllCenterMaster();
            divCenterNumberTab.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        #endregion

        #region "Grid Center Master Enevts"

        protected void grvCenterMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvCenterMaster.EditIndex = e.NewEditIndex;
            GetAllCenterMaster();
            EditCenterMaster(e.NewEditIndex.ToString());
        }

        protected void grvCenterMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                EditCenterMaster(e.CommandArgument.ToString());
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            if (e.CommandName == "Edit")
            {
                divCenterNumberTab.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            if (e.CommandName == "Delete")
            {
                DeleteCenterMaster(e.CommandArgument.ToString());
            }

            if (e.CommandName == "Cancel")
            {
            }
        }

        protected void grvCenterMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        
        }

        protected void grvCenterMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grvCenterMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvCenterMaster.EditIndex = -1;
            GetAllCenterMaster();
        }

        protected void grvCenterMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            LoadCenterMasterModel();
            _centermastermanagermodel.Add(centermastermodel, Userid);
            GetAllCenterMaster();
            divCenterNumberTab.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            ControlClearing.ClearAllControls(this.Page.Form);
        }

        #endregion

        #region "Common Methods"

        public void GetAllCenterMaster()
        {
            ViewState["Edit"] = "";
            CenterMasterModelManager objCMM = new CenterMasterModelManager();
            grvCenterMaster.DataSource = objCMM.getCenterManagers();
            grvCenterMaster.DataBind();
        }

        public void LoadCenterMasterModel()
        {
            try
            {
                centermastermodel = new CenterMasterModel();
                centermastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text ?? "";
                centermastermodel.Center_Name = txtCenterName.Text ?? "";
                centermastermodel.Center_No = txtCenterNumber.Text != null ? Convert.ToInt32(txtCenterNumber.Text) : 0;
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
                Logger.Error("CM000001|Error With Loading Center Manager :" + ex.InnerException.ToString());
            }
        }

        private void ChangeButtonForEditing(int GridEditIndex)
        {

        }

        private bool EditCenterMaster(string centerno)
        {
            try
            {
                int CentNo = Convert.ToInt32(centerno);
                CenterMasterModelManager objCentManModMast = new CenterMasterModelManager();
                centermastermodel = objCentManModMast.GetCenterManager(CentNo);                
                SetCenterManager(centermastermodel);
            }
            catch (Exception ex)
            {
                Logger.Error("CM000001|Error while editing Center Master Details: " + ex.InnerException.InnerException);
            }
            return false;
        }

        private void SetCenterManager(CenterMasterModel centermastermodel)
        {
            txtBankAccountNumbervarchar.Text = centermastermodel.Bank_Account_Number ?? "";
            txtCenterNumber.Text = centermastermodel.Center_No.ToString();
            txtCenterNumber.Enabled = false;
            txtCenterName.Text = centermastermodel.Center_Name ?? "";
            txtCenterType.Text = centermastermodel.Center_Type ?? "";
            txtCity.Text = centermastermodel.City ?? "";
            txtCountry.Text = centermastermodel.Country ?? "";
            txtEmail.Text = centermastermodel.Email ?? "";
            txtEquipments.Text = centermastermodel.Equipments ?? "";
            txtInvestigator1.Text = centermastermodel.Investigator_1 ?? "";
            txtInvestigator2.Text = centermastermodel.Investigator_2 ?? "";
            txtInvestigator3.Text = centermastermodel.Investigator_3 ?? "";
            txtMobilePhone.Text = centermastermodel.Mobile_Phone ?? "";
            txtOfficePhone.Text = centermastermodel.Office_Phone ?? "";
            txtPayeeName.Text = centermastermodel.Payee_Name ?? "";
            txtPostcode.Text = centermastermodel.Post_code ?? "";
            txtPrimaryEmail.Text = centermastermodel.Primary_Email ?? "";
            txtSecondaryEmail.Text = centermastermodel.Secondary_Email ?? "";
            txtSpecialties.Text = centermastermodel.Specialties ?? "";
            txtState.Text = centermastermodel.State ?? "";
            txtStreetAddress.Text = centermastermodel.Street_Address ?? "";
            txtWebsite.Text = centermastermodel.Website ?? "";
        }

        private void DeleteCenterMaster(string centerno)
        {
            try
            {
                int centno = Convert.ToInt32(centerno);
                CenterMasterModelManager objCentManModMast = new CenterMasterModelManager();
                bool result = objCentManModMast.DeleteCenterManager(centno);
                if (result)
                {
                    //MessageBox.Show("Sucessfully Deleted");
                    divCenterNumberTab.Visible = false;
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    GetAllCenterMaster();
                }
                //else
                //    MessageBox.Show("Error While deliting the Center Master");
            }
            catch (Exception ex)
            {
                Logger.Error("CM000001|Error while deleting Center Master Details: " + ex.InnerException.InnerException);
            }
        }

        public void GetCityMasterList()
        {
            //CityMasterModelManager _citymastermodelmanager = new CityMasterModelManager();
            ////List<CityMasterModel> citymasterlist = _citymastermodelmanager.GetAllCityMaster();
            //CityMasterModel citymasterlist1 = _citymastermodelmanager.GetStateByCityID();
        }

        #endregion

    }
}