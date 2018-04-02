using ClinicalTrail.Application.WebApplication.Manager;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalTrail.Application.WebApplication.Views.CenterMaster
{
    public partial class CenterMaster : System.Web.UI.Page
    {
        private CenterMasterModel centermastermodel { get; set; }
        private readonly CenterMasterModelManager _CMMM;
        string Userid = "";

        public CenterMaster()
        {
            _CMMM = new CenterMasterModelManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCenterMaster();
        }

        public void GetAllCenterMaster()
        {
            CenterMasterModelManager objCMM = new CenterMasterModelManager();
            grvCenterMaster.DataSource = objCMM.getCenterManagers();
            grvCenterMaster.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            LoadCenterMasterModel();
            _CMMM.Add(centermastermodel, Userid);
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

        }

        public void LoadCenterMasterModel()
        {
            centermastermodel = new CenterMasterModel();
            centermastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text ?? "";
            centermastermodel.Center_Name = txtCenterName.Text ?? "";
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

        protected void grvCenterMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvCenterMaster.EditIndex = e.NewEditIndex;
            LinkButton lnkEdit = sender as LinkButton;
            GridViewRow row = (GridViewRow)lnkEdit.NamingContainer;


            string CenterNo =  grvCenterMaster.Rows[e.NewEditIndex].Cells[0].Text;
        }

        private void ChangeButtonForEditing(int GridEditIndex)
        {

        }

        private bool EditCenterMaster(string CenterNo)
        {
            return false;
        }

        protected void grvCenterMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                //ChangeButtonForEditing(e.NewEditIndex);
                //EditCenterMaster(CenterNo);
            }
        }

        protected void grvCenterMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lnkBtnEdit = (LinkButton)e.Row.FindControl("btnedit");
                lnkBtnEdit.Visible = false;
                LinkButton lnkBtnUpdate = (LinkButton)e.Row.FindControl("btnUpdate");
                lnkBtnUpdate.Visible = false;
                LinkButton lnkBtnDelete = (LinkButton)e.Row.FindControl("btnDelete");
                lnkBtnDelete.Visible = false;
                LinkButton lnkBtnCancel = (LinkButton)e.Row.FindControl("btnCancel");
                lnkBtnCancel.Visible = false;
            }
        }
    }
}