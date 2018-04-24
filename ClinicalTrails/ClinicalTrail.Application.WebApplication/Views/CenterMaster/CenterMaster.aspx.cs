using ClinicalTrail.Application.WebApplication.Manager;
using AtlasCopco.Framework.Objects.Logging;
using ClinicalTrail.Application.WebApplication.Models;
using ClinicalTrail.GeneralObjectStore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace ClinicalTrail.Application.WebApplication.Views.CenterMaster
{
    public partial class CenterMaster : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private CenterMasterModel centermastermodel {get;set;}
        public readonly AddressTypeModelManager _addressTypeManger;
        private readonly CenterMasterModelManager _centermastermanagermodel;

        string Userid = "";

        #region "Page Event"

        public CenterMaster()
        {
            _addressTypeManger = new AddressTypeModelManager();
            _centermastermanagermodel = new CenterMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllCenterMaster();
                GetAllAddressType();
                GetCityMasterList();
            }
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
            if (Page.IsValid)
            {
                LoadCenterMasterModel();
                _centermastermanagermodel.AddCenterManager(centermastermodel, Userid);
                GetAllCenterMaster();
                ControlClearing.ClearAllControls(this.Page.Form);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LoadCenterMasterModel();
                _centermastermanagermodel.AddCenterManager(centermastermodel, Userid);
                grvCenterMaster.EditIndex = -1;
                GetAllCenterMaster();
                divCenterNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ControlClearing.ClearAllControls(this.Page.Form);
            }
        }

        #endregion

        #region "Grid Center Master Enevts"

        protected void grvCenterMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvCenterMaster.EditIndex = e.NewEditIndex;
            GetAllCenterMaster();
        }

        protected void grvCenterMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                divCenterNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            if (e.CommandName == "Edit")
            {
                divCenterNumberTab.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                GetAllAddressType();
                EditCenterMaster(e.CommandArgument.ToString());
            }
            if (e.CommandName == "Delete")
            {
                DeleteCenterMaster(e.CommandArgument.ToString());
            }

            if (e.CommandName == "Cancel")
            {
                divCenterNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                grvCenterMaster.EditIndex = -1;
                GetAllCenterMaster();
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
            try
            {
                LoadCenterMasterModel();
                _centermastermanagermodel.AddCenterManager(centermastermodel, Userid);
                grvCenterMaster.EditIndex = -1;
                GetAllAddressType();
                GetAllCenterMaster();                
                ControlClearing.ClearAllControls(this.Page.Form);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
            }
        }

        protected void grvCenterMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCenterMaster.PageIndex = e.NewPageIndex;
            GetAllCenterMaster();
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
                centermastermodel.Center_Type = ddlCenterType.SelectedItem.Text ?? "";
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
                GetAllAddressType();
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
            txtMode.Text = "Editing";
            txtBankAccountNumbervarchar.Text = centermastermodel.Bank_Account_Number ?? "No Item Selected";
            txtCenterNumber.Text = centermastermodel.Center_No.ToString();
            txtCenterNumber.Enabled = false;
            txtCenterName.Text = centermastermodel.Center_Name ?? "";
            ddlCenterType.SelectedIndex = GetAddressTypeByID(centermastermodel.Center_Type).AddressTypeID ??  0;
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

        private void GetAllAddressType()
        {
            ddlCenterType.DataSource = GetAddressTypeList();
            ddlCenterType.DataValueField = "AddressTypeID";
            ddlCenterType.DataTextField = "AddressTypeName";
            ddlCenterType.DataBind();

            ddlCenterType.Items.Insert(0, new ListItem("Select Center Type", "0"));
        }

        private AddressTypeModel GetAddressTypeByID(string addresstype)
        {
            AddressTypeModel addresstypemodel = new AddressTypeModel();
            return _addressTypeManger.GetAddressTypeByID(addresstype);
        }

        private List<AddressTypeModel> GetAddressTypeList()
        {
            return _addressTypeManger.GetAddressTypeList();
        }

        #endregion

        #region "File Uploader All Event"

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuCenterMaster.HasFile)
            {
                string FileName = Path.GetFileName(fuCenterMaster.PostedFile.FileName);
                string Extension = Path.GetExtension(fuCenterMaster.PostedFile.FileName);
                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];
                string FilePath = Server.MapPath(FolderPath + FileName);
                fuCenterMaster.SaveAs(FilePath);
                Import_To_Grid(FilePath, Extension, "Yes");
                GetAllCenterMaster();
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

            if (CheckAllExcelHeader(dt))
            {
                List<CenterMasterModel> ExcelList = new List<CenterMasterModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    centermastermodel = new CenterMasterModel();
                    centermastermodel.Bank_Account_Number = dr["Bank Account Number"].ToString() ?? "";
                    centermastermodel.Center_Name = dr["Centre Name"].ToString() ?? "";
                    centermastermodel.Center_No = string.IsNullOrEmpty(dr["Centre No"].ToString()) ? 0 : Convert.ToInt32(dr["Centre No"]);
                    centermastermodel.Center_Type = dr["Centre Type"].ToString() ?? "";
                    centermastermodel.City = dr["City"].ToString() ?? "";
                    centermastermodel.Country = dr["Country"].ToString() ?? "";
                    centermastermodel.Email = dr["Email"].ToString() ?? "";
                    centermastermodel.Equipments = dr["Equipments"].ToString() ?? "";
                    centermastermodel.Investigator_1 = dr["Investigator 1"].ToString() ?? "";
                    centermastermodel.Investigator_2 = dr["Investigator 2"].ToString() ?? "";
                    centermastermodel.Investigator_3 = dr["Investigator 3"].ToString() ?? "";
                    centermastermodel.Mobile_Phone = dr["Mobile Phone"].ToString() ?? "";
                    centermastermodel.Office_Phone = dr["Office Phone"].ToString() ?? "";
                    centermastermodel.Payee_Name = dr["Payee Name"].ToString() ?? "";
                    centermastermodel.Post_code = dr["Post code"].ToString() ?? "";
                    centermastermodel.Primary_Email = dr["Primary Email"].ToString() ?? "";
                    centermastermodel.Secondary_Email = dr["Secondary Email"].ToString() ?? "";
                    centermastermodel.Specialties = dr["Specialities"].ToString() ?? "";
                    centermastermodel.State = dr["State"].ToString() ?? "";
                    centermastermodel.Street_Address = dr["Street Address"].ToString() ?? "";
                    centermastermodel.Website = dr["Website"].ToString() ?? "";
                    ExcelList.Add(centermastermodel);
                }
                _centermastermanagermodel.AddCenterManager(ExcelList, "");
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

        private bool CheckAllExcelHeader(DataTable dt)
        {
            string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>()
                                    select dc.ColumnName).ToArray();
            bool status = false;
            try
            {
                if (columnNames[0] != null && columnNames[0] == "Centre No")
                    status = true;
                else
                    return status = false;

                if (columnNames[1] != null && columnNames[1] == "Centre Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[2] != null && columnNames[2] == "Centre Type")
                    status = true;
                else
                    return status = false;

                if (columnNames[3] != null && columnNames[3] == "Street Address")
                    status = true;
                else
                    return status = false;
                if (columnNames[4] != null && columnNames[4] == "City")
                    status = true;
                else
                    return status = false;

                if (columnNames[5] != null && columnNames[5] == "State")
                    status = true;
                else
                    return status = false;

                if (columnNames[6] != null && columnNames[6] == "Country")
                    status = true;
                else
                    return status = false;

                if (columnNames[7] != null && columnNames[7] == "Post code")
                    status = true;
                else
                    return status = false;

                if (columnNames[8] != null && columnNames[8] == "Specialities")
                    status = true;
                else
                    return status = false;

                if (columnNames[9] != null && columnNames[9] == "Office Phone")
                    status = true;
                else
                    return status = false;

                if (columnNames[10] != null && columnNames[10] == "Mobile Phone")
                    status = true;
                else
                    return status = false;

                if (columnNames[11] != null && columnNames[11] == "Email")
                    status = true;
                else
                    return status = false;

                if (columnNames[12] != null && columnNames[12] == "Primary Email")
                    status = true;
                else
                    return status = false;

                if (columnNames[13] != null && columnNames[13] == "Secondary Email")
                    status = true;
                else
                    return status = false;

                if (columnNames[14] != null && columnNames[14] == "Website")
                    status = true;
                else
                    return status = false;

                if (columnNames[15] != null && columnNames[15] == "Equipments")
                    status = true;
                else
                    return status = false;

                if (columnNames[16] != null && columnNames[16] == "Specialities1")
                    status = true;
                else
                    return status = false;

                if (columnNames[17] != null && columnNames[17] == "Investigator 1")
                    status = true;
                else
                    return status = false;

                if (columnNames[18] != null && columnNames[18] == "Investigator 2")
                    status = true;
                else
                    return status = false;

                if (columnNames[19] != null && columnNames[19] == "Investigator 3")
                    status = true;
                else
                    return status = false;

                if (columnNames[20] != null && columnNames[20] == "Payee Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[21] != null && columnNames[21] == "Bank Account Number")
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