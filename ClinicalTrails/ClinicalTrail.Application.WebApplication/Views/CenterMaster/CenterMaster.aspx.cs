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

        public CenterMaster()
        {
            _centermastermanagermodel = new CenterMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllCenterMaster();
        }

        public void GetAllCenterMaster()
        {
            ViewState["Edit"] = "";
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
            _centermastermanagermodel.Add(centermastermodel, Userid);
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

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

        protected void grvCenterMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ViewState["Edit"] = "true";

            //grvCenterMaster.EditIndex = e.NewEditIndex;
            //LinkButton lnkbtnEdit = sender as LinkButton;
            //GridViewRow rowEdit = (GridViewRow)lnkbtnEdit.NamingContainer;
            //lnkbtnEdit.Visible = false;

            //LinkButton lnkBtnDelete = sender as LinkButton;
            //GridViewRow rowDelete = (GridViewRow)lnkBtnDelete.NamingContainer;
            //lnkBtnDelete.Visible = false;

            //LinkButton lnkBtnUpdate = sender as LinkButton;
            //GridViewRow rowUpdate = (GridViewRow)lnkBtnUpdate.NamingContainer;
            //lnkBtnUpdate.Visible = true;

            //LinkButton lnkBtnCancel = sender as LinkButton;
            //GridViewRow rowCancel = (GridViewRow)lnkBtnCancel.NamingContainer;
            //lnkBtnCancel.Visible = true;

            //LinkButton lnkBtnEdit = (LinkButton)e.Row.FindControl("btnedit");
            //lnkBtnEdit.Visible = false;
            //LinkButton lnkBtnUpdate = (LinkButton)e.Row.FindControl("btnUpdate");
            //lnkBtnUpdate.Visible = true;
            //LinkButton lnkBtnDelete = (LinkButton)e.Row.FindControl("btnDelete");
            //lnkBtnDelete.Visible = false;
            //LinkButton lnkBtnCancel = (LinkButton)e.Row.FindControl("btnCancel");
            //lnkBtnCancel.Visible = true;

            //string CenterNo = grvCenterMaster.Rows[e.NewEditIndex].Cells[0].Text;
            //EditCenterMaster(CenterNo);
        }

        private void ChangeButtonForEditing(int GridEditIndex)
        {

        }

        private bool EditCenterMaster(string CenterNo)
        {
            try
            {
                int CentNo = Convert.ToInt32(CenterNo);
                CenterMasterModelManager objCentManModMast = new CenterMasterModelManager();
                centermastermodel = objCentManModMast.GetCenterManager(CentNo);
                divCenterNumberTab.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
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

        protected void grvCenterMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                //ChangeButtonForEditing(e.CommandArgument.ToString());
                EditCenterMaster(e.CommandArgument.ToString());
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            if (e.CommandName == "Edit")
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                EditCenterMaster(e.CommandArgument.ToString());
            }
            if (e.CommandName == "Delete")
            {
                DeleteCenterMaster(e.CommandArgument.ToString());
            }
        }

        private void DeleteCenterMaster(string p)
        {

        }

        protected void grvCenterMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lnkBtnEdit = (LinkButton)e.Row.FindControl("btnedit");
                LinkButton lnkBtnUpdate = (LinkButton)e.Row.FindControl("btnUpdate");
                LinkButton lnkBtnDelete = (LinkButton)e.Row.FindControl("btnDelete");
                LinkButton lnkBtnCancel = (LinkButton)e.Row.FindControl("btnCancel");
                if (ViewState["Edit"].ToString() == "true")
                {
                    lnkBtnEdit.Visible = false;
                    lnkBtnDelete.Visible = false;
                    lnkBtnUpdate.Visible = true;
                    lnkBtnCancel.Visible = true;
                }
                else
                {
                    lnkBtnEdit.Visible = true;
                    lnkBtnDelete.Visible = true;
                    lnkBtnUpdate.Visible = false;
                    lnkBtnCancel.Visible = false;
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadCenterMasterModel();
            _centermastermanagermodel.Add(centermastermodel, Userid);
            GetAllCenterMaster();
            divCenterNumberTab.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            FindControls(this.Page.Form, false);
        }

        //private void FindControls(Control htmlForm, bool p)
        //{
        //    throw new NotImplementedException();
        //}

        private void ClearAllControls(System.Web.UI.HtmlControls.HtmlForm htmlForm)
        {
            foreach (System.Web.UI.Control control in htmlForm.Controls)
            {
                if (control is System.Web.UI.WebControls.TextBox)
                {
                    System.Web.UI.WebControls.TextBox txtbox = (System.Web.UI.WebControls.TextBox)control;
                    txtbox.Text = string.Empty;
                }
                //else if (control is CheckBox)
                //{
                //    CheckBox chkbox = (CheckBox)control;
                //    chkbox.Checked = false;
                //}
                //else if (control is RadioButton)
                //{
                //    RadioButton rdbtn = (RadioButton)control;
                //    rdbtn.Checked = false;
                //}
                //else if (control is DateTimePicker)
                //{
                //    DateTimePicker dtp = (DateTimePicker)control;
                //    dtp.Value = DateTime.Now;
                //}
            }
        }

        #region "Common Methods"

        //public void ClearAllControls(Form form)
        //{
        //    foreach (System.Web.UI.Control control in form.Controls)
        //    {
        //        if (control is System.Web.UI.WebControls.TextBox)
        //        {
        //            System.Web.UI.WebControls.TextBox txtbox = (System.Web.UI.WebControls.TextBox)control;
        //            txtbox.Text = string.Empty;
        //        }
        //        //else if (control is CheckBox)
        //        //{
        //        //    CheckBox chkbox = (CheckBox)control;
        //        //    chkbox.Checked = false;
        //        //}
        //        //else if (control is RadioButton)
        //        //{
        //        //    RadioButton rdbtn = (RadioButton)control;
        //        //    rdbtn.Checked = false;
        //        //}
        //        //else if (control is DateTimePicker)
        //        //{
        //        //    DateTimePicker dtp = (DateTimePicker)control;
        //        //    dtp.Value = DateTime.Now;
        //        //}
        //    }
        //}

        /// <summary>
        /// Change status of all the master controles used in the page
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="status"></param>
        /// <param name="status"></param>
        public void FindControls(Control ctrl,bool status)
        {
            foreach (System.Web.UI.Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Text = "";
                }
                if (item is DropDownList)
                {
                    DropDownList ddl = (DropDownList)item;
                    ddl.SelectedIndex = 0;
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = status;
                }
                //if (item is Button)
                //{
                //    Button btn = (Button)item;
                //    btn.Visible = status;
                //}
                if (item is RadioButtonList)
                {
                    RadioButtonList rbtnl = (RadioButtonList)item;
                    rbtnl.SelectedIndex = 0;
                }
                if (item is LinkButton)
                {
                    LinkButton lbtn = (LinkButton)item;
                    lbtn.Text = "";
                }
                //if (item is Panel)
                //{
                //    Panel pnl = (Panel)item;
                //    pnl.Visible = status;
                //}
                FindChildControls(item,status);
            }
        }

        /// <summary>
        /// Change status of all the child controles used in the page
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="status"></param>
        public void FindChildControls(Control ctrl, bool status)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txb = (TextBox)item;
                    txb.Text = "";
                }
                if (item is DropDownList)
                {
                    DropDownList ddl = (DropDownList)item;
                    ddl.SelectedIndex = 0;
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = status;
                }
                //if (item is Button)
                //{
                //    Button btn = (Button)item;
                //    btn.Visible = status;
                //}
                if (item is RadioButtonList)
                {
                    RadioButtonList rbtnl = (RadioButtonList)item;
                    rbtnl.SelectedIndex = 0;
                }
                if (item is LinkButton)
                {
                    LinkButton lbtn = (LinkButton)item;
                    lbtn.Text = "";
                }
                //if (item is Panel)
                //{
                //    Panel pnl = (Panel)item;
                //    pnl.Visible = status;
                //}
                FindChildControls(item, status);
            }
        }

        #endregion
    }
}