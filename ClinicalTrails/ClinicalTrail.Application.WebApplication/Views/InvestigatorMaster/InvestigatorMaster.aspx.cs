using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.Application.WebApplication.Manager;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.GeneralObjectStore.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
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

        #region "Page Events"

        public InvestigatorMaster()
        {
            _addressTypeManger = new AddressTypeModelManager();
            _investigatormastermodelmanager = new InvestigatorMasterModelManager();
        }

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
            if (Page.IsValid)
            {
                SetInvestigatorModel();
                _investigatormastermodelmanager.CRUDInvestigatorMaster(investigatormastermodel, "Update");
                LoadAllInvertorMastertoGrid();
                GetAllAddressType();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ControlClearing.ClearAllControls(this.Page.Form);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SetInvestigatorModel();
                _investigatormastermodelmanager.CRUDInvestigatorMaster(investigatormastermodel, "Add");
                LoadAllInvertorMastertoGrid();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            ControlClearing.ClearAllControls(this.Page.Form);
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
            chkIsActive.Checked = investigatormastermodel.IsActive;
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

        private bool CheckAllExcelHeader(DataTable dt)
        {
            string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>()
                                    select dc.ColumnName).ToArray();
            bool status = false;
            try
            {
                if (columnNames[0] != null && columnNames[0] == "ID")
                    status = true;
                else
                    return status = false;

                if (columnNames[1] != null && columnNames[1] == "Title")
                    status = true;
                else
                    return status = false;

                if (columnNames[2] != null && columnNames[2] == "Investigator First Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[3] != null && columnNames[3] == "Investigator Middle Name")
                    status = true;
                else
                    return status = false;
                if (columnNames[4] != null && columnNames[4] == "Investigator Last Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[5] != null && columnNames[5] == "Degree")
                    status = true;
                else
                    return status = false;

                if (columnNames[6] != null && columnNames[6] == "Address Type")
                    status = true;
                else
                    return status = false;

                if (columnNames[7] != null && columnNames[7] == "Institute Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[8] != null && columnNames[8] == "Street Address")
                    status = true;
                else
                    return status = false;

                if (columnNames[9] != null && columnNames[9] == "City")
                    status = true;
                else
                    return status = false;

                if (columnNames[10] != null && columnNames[10] == "State")
                    status = true;
                else
                    return status = false;

                if (columnNames[11] != null && columnNames[11] == "Country")
                    status = true;
                else
                    return status = false;

                if (columnNames[12] != null && columnNames[12] == "Post Code")
                    status = true;
                else
                    return status = false;

                if (columnNames[13] != null && columnNames[13] == "Office Phone")
                    status = true;
                else
                    return status = false;

                if (columnNames[14] != null && columnNames[14] == "Mobile Phone")
                    status = true;
                else
                    return status = false;

                if (columnNames[15] != null && columnNames[15] == "Fax No")
                    status = true;
                else
                    return status = false;

                if (columnNames[16] != null && columnNames[16] == "Email ID")
                    status = true;
                else
                    return status = false;

                if (columnNames[17] != null && columnNames[17] == "Primary Email")
                    status = true;
                else
                    return status = false;

                if (columnNames[18] != null && columnNames[18] == "Secondary Email")
                    status = true;
                else
                    return status = false;

                if (columnNames[19] != null && columnNames[19] == "Certification")
                    status = true;
                else
                    return status = false;

                if (columnNames[20] != null && columnNames[20] == "Speciality")
                    status = true;
                else
                    return status = false;

                if (columnNames[21] != null && columnNames[21] == "Centre 1")
                    status = true;
                else
                    return status = false;

                if (columnNames[22] != null && columnNames[22] == "Centre 2")
                    status = true;
                else
                    return status = false;

                if (columnNames[23] != null && columnNames[23] == "Centre 3")
                    status = true;
                else
                    return status = false;

                if (columnNames[24] != null && columnNames[24] == "Payee Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[25] != null && columnNames[25] == "Bank Account Number")
                    status = true;
                else
                    return status = false;

                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
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

        protected void grvInvestigatorMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvInvestigatorMaster.EditIndex = -1;
            LoadAllInvertorMastertoGrid();
        }

        protected void grvInvestigatorMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void grvInvestigatorMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                SetInvestigatorModel();
                _investigatormastermodelmanager.CRUDInvestigatorMaster(investigatormastermodel, "Update");
                LoadAllInvertorMastertoGrid();
                GetAllAddressType();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ControlClearing.ClearAllControls(this.Page.Form);
            }
            if (e.CommandName == "Edit")
            {
                divInvestigatorNumberTab.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                LoadAllInvertorMastertoGrid();
            }
            if (e.CommandName == "Delete")
            {
                _investigatormastermodelmanager.DeleteInvestigatoMaster(Convert.ToInt32(e.CommandArgument));
                LoadAllInvertorMastertoGrid();
            }

            if (e.CommandName == "Cancel")
            {
                LoadAllInvertorMastertoGrid();
            }
        }

        protected void grvInvestigatorMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvInvestigatorMaster.PageIndex = e.NewPageIndex;
            LoadAllInvertorMastertoGrid();
        }


        #endregion

        #region "File Uploader All Event"

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuInvestigatorMaster.HasFile)
            {
                string FileName = Path.GetFileName(fuInvestigatorMaster.PostedFile.FileName);
                string Extension = Path.GetExtension(fuInvestigatorMaster.PostedFile.FileName);
                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];
                string FilePath = Server.MapPath(FolderPath + FileName);
                fuInvestigatorMaster.SaveAs(FilePath);
                Import_To_Grid(FilePath, Extension, "Yes");
                LoadAllInvertorMastertoGrid();
            }
        }
        
        private void Import_To_Grid(string FilePath, string Extension, string isHDR)
        {
            string conStr = "";
            switch (Extension)
            {
                case ".xls": //Excel 97-03
                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]
                             .ConnectionString;
                    break;

                case ".xlsx": //Excel 07
                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]
                              .ConnectionString;
                    break;
            }

            conStr = String.Format(conStr, FilePath, isHDR);

            OleDbConnection connExcel = new OleDbConnection(conStr);
            OleDbCommand cmdExcel = new OleDbCommand();
            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();
            cmdExcel.Connection = connExcel;

            //Get the name of First Sheet
            connExcel.Open();
            DataTable dtExcelSchema;
            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
            connExcel.Close();

            //Read Data from First Sheet
            connExcel.Open();
            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
            oda.SelectCommand = cmdExcel;
            oda.Fill(dt);
            connExcel.Close();

            if(CheckAllExcelHeader(dt))
            {
                List<InvestigatorMasterModel> ExcelList = new List<InvestigatorMasterModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    investigatormastermodel = new InvestigatorMasterModel();
                    investigatormastermodel.Address_Type = dr["Address Type"].ToString() ?? "";
                    investigatormastermodel.Bank_Account_Number = dr["Bank Account Number"].ToString() ?? "";
                    investigatormastermodel.Centre_1 = dr["Centre 1"].ToString() ?? "";
                    investigatormastermodel.Centre_2 = dr["Centre 2"].ToString() ?? "";
                    investigatormastermodel.Centre_3 = dr["Centre 3"].ToString() ?? "";
                    investigatormastermodel.Certification = dr["Certification"].ToString() ?? "";
                    investigatormastermodel.City = dr["City"].ToString() ?? "";
                    investigatormastermodel.Country = dr["Country"].ToString() ?? "";
                    investigatormastermodel.Degree = dr["Degree"].ToString() ?? "";
                    investigatormastermodel.Email_ID = dr["Email ID"].ToString() ?? "";
                    investigatormastermodel.Fax_No = dr["Fax No"].ToString() ?? "";
                    investigatormastermodel.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : Convert.ToInt32(dr["ID"].ToString());
                    investigatormastermodel.Institute_Name = dr["Institute Name"].ToString() ?? "";
                    investigatormastermodel.Investigator_First_Name = dr["Investigator First Name"].ToString() ?? "";
                    investigatormastermodel.Investigator_Last_Name = dr["Investigator Last Name"].ToString() ?? "";
                    investigatormastermodel.Investigator_Middle_Name = dr["Investigator Middle Name"].ToString() ?? "";
                    investigatormastermodel.IsActive = true;
                    investigatormastermodel.Mobile_Phone = dr["Mobile Phone"].ToString() ?? "";
                    investigatormastermodel.Office_Phone = dr["Office Phone"].ToString() ?? "";
                    investigatormastermodel.Payee_Name = dr["Payee Name"].ToString() ?? "";
                    investigatormastermodel.Post_Code = dr["Post Code"].ToString() ?? "";
                    investigatormastermodel.Primary_Email = dr["Primary Email"].ToString() ?? "";
                    investigatormastermodel.Secondary_Email_ID = dr["Secondary Email"].ToString() ?? "";
                    investigatormastermodel.Speciality = dr["Speciality"].ToString() ?? "";
                    investigatormastermodel.State = dr["State"].ToString() ?? "";
                    investigatormastermodel.Street_Address = dr["Street Address"].ToString() ?? "";
                    investigatormastermodel.Title = dr["Title"].ToString() ?? "";
                    ExcelList.Add(investigatormastermodel);
                }
                _investigatormastermodelmanager.CRUDInvestigatorMaster(ExcelList, "");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please correct the Header column of your excel sheet");
            }

            //Bind Data to GridView
            //GridView1.Caption = Path.GetFileName(FilePath);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];
            string FileName = GridView1.Caption;
            string Extension = Path.GetExtension(FileName);
            string FilePath = Server.MapPath(FolderPath + FileName);

            Import_To_Grid(FilePath, Extension, "Yes");
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        #endregion
    }
}