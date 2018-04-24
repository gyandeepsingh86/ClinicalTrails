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

namespace ClinicalTrail.Application.WebApplication.Views.VendorMaster
{
    public partial class VendorMaster : System.Web.UI.Page
    {
        protected static ILogger Logger = LoggerFactory.GetLogger();
        private VendorMasterModel Vendormastermodel { get; set; }
        public readonly AddressTypeModelManager _addressTypeManger;
        private readonly VendorMasterModelManager _Vendormastermanagermodel;
        string Userid = "";

        #region "Page Events"

        public VendorMaster()
        {
            _addressTypeManger = new AddressTypeModelManager();
            _Vendormastermanagermodel = new VendorMasterModelManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllVendorMaster();
                GetAllAddressType();
                GetCityMasterList();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ControlClearing.ClearAllControls(this.Page.Form);
            divVendorNumberTab.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LoadVendorMasterModel();
                _Vendormastermanagermodel.AddVendorManager(Vendormastermodel, Userid);
                GetAllVendorMaster();
                ControlClearing.ClearAllControls(this.Page.Form);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LoadVendorMasterModel();
                _Vendormastermanagermodel.AddVendorManager(Vendormastermodel, Userid);
                grvVendorMaster.EditIndex = -1;
                GetAllVendorMaster();
                divVendorNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ControlClearing.ClearAllControls(this.Page.Form);
            }
        }

        #endregion

        #region "Grid Vendor Master Enevts"

        protected void grvVendorMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvVendorMaster.EditIndex = e.NewEditIndex;
            GetAllVendorMaster();
        }

        protected void grvVendorMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                divVendorNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            if (e.CommandName == "Edit")
            {
                divVendorNumberTab.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                GetAllAddressType();
                EditVendorMaster(e.CommandArgument.ToString());
            }
            if (e.CommandName == "Delete")
            {
                DeleteVendorMaster(e.CommandArgument.ToString());
            }

            if (e.CommandName == "Cancel")
            {
                divVendorNumberTab.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                grvVendorMaster.EditIndex = -1;
                GetAllVendorMaster();
            }
        }

        protected void grvVendorMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvVendorMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grvVendorMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvVendorMaster.EditIndex = -1;
            GetAllVendorMaster();
        }

        protected void grvVendorMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                LoadVendorMasterModel();
                _Vendormastermanagermodel.AddVendorManager(Vendormastermodel, Userid);
                grvVendorMaster.EditIndex = -1;
                GetAllAddressType();
                GetAllVendorMaster();
                ControlClearing.ClearAllControls(this.Page.Form);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
            }
        }

        protected void grvVendorMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvVendorMaster.PageIndex = e.NewPageIndex;
            GetAllVendorMaster();
        }

        #endregion

        #region "Common Methods"

        public void GetAllVendorMaster()
        {
            ViewState["Edit"] = "";
            VendorMasterModelManager objCMM = new VendorMasterModelManager();
            grvVendorMaster.DataSource = objCMM.getVendorManagers();
            grvVendorMaster.DataBind();
        }

        public void LoadVendorMasterModel()
        {
            try
            {
                Vendormastermodel = new VendorMasterModel();
                Vendormastermodel.Bank_Account_Number = txtBankAccountNumbervarchar.Text ?? "";
                Vendormastermodel.Vendor_Name = txtVendorName.Text ?? "";
                Vendormastermodel.Vendor_No = !string.IsNullOrEmpty(txtVendorNumber.Text) ? Convert.ToInt32(txtVendorNumber.Text) : 0;
                Vendormastermodel.Vendor_Type = ddlVendorType.SelectedItem.Text ?? "";
                Vendormastermodel.City = txtCity.Text ?? "";
                Vendormastermodel.Country = txtCountry.Text ?? "";
                Vendormastermodel.Email = txtEmail.Text ?? "";
                Vendormastermodel.Equipments = txtEquipments.Text ?? "";
                Vendormastermodel.IsActive = chkIsActive.Checked;
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
            }
            catch (Exception ex)
            {
                Logger.Error("CM000001|Error With Loading Vendor Manager :" + ex.InnerException.ToString());
            }
        }

        private void ChangeButtonForEditing(int GridEditIndex)
        {

        }

        private bool EditVendorMaster(string Vendorno)
        {
            try
            {
                int CentNo = Convert.ToInt32(Vendorno);
                VendorMasterModelManager objCentManModMast = new VendorMasterModelManager();
                Vendormastermodel = objCentManModMast.GetVendorManager(CentNo);
                GetAllAddressType();
                SetVendorManager(Vendormastermodel);
            }
            catch (Exception ex)
            {
                Logger.Error("CM000001|Error while editing Vendor Master Details: " + ex.InnerException.InnerException);
            }
            return false;
        }

        private void SetVendorManager(VendorMasterModel Vendormastermodel)
        {
            txtMode.Text = "Editing";
            txtBankAccountNumbervarchar.Text = Vendormastermodel.Bank_Account_Number ?? "No Item Selected";
            txtVendorNumber.Text = Vendormastermodel.Vendor_No.ToString();
            txtVendorNumber.Enabled = false;
            txtVendorName.Text = Vendormastermodel.Vendor_Name ?? "";
            ddlVendorType.SelectedIndex = GetAddressTypeByID(Vendormastermodel.Vendor_Type).AddressTypeID ?? 0;
            txtCity.Text = Vendormastermodel.City ?? "";
            txtCountry.Text = Vendormastermodel.Country ?? "";
            txtEmail.Text = Vendormastermodel.Email ?? "";
            txtEquipments.Text = Vendormastermodel.Equipments ?? "";
            txtMobilePhone.Text = Vendormastermodel.Mobile_Phone ?? "";
            txtOfficePhone.Text = Vendormastermodel.Office_Phone ?? "";
            txtPayeeName.Text = Vendormastermodel.Payee_Name ?? "";
            txtPostcode.Text = Vendormastermodel.Post_code ?? "";
            txtPrimaryEmail.Text = Vendormastermodel.Primary_Email ?? "";
            txtSecondaryEmail.Text = Vendormastermodel.Secondary_Email ?? "";
            txtSpecialties.Text = Vendormastermodel.Specialties ?? "";
            txtState.Text = Vendormastermodel.State ?? "";
            txtStreetAddress.Text = Vendormastermodel.Street_Address ?? "";
            txtWebsite.Text = Vendormastermodel.Website ?? "";
        }

        private void DeleteVendorMaster(string Vendorno)
        {
            try
            {
                int centno = Convert.ToInt32(Vendorno);
                VendorMasterModelManager objCentManModMast = new VendorMasterModelManager();
                bool result = objCentManModMast.DeleteVendorManager(centno);
                if (result)
                {
                    //MessageBox.Show("Sucessfully Deleted");
                    divVendorNumberTab.Visible = false;
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    GetAllVendorMaster();
                }
                //else
                //    MessageBox.Show("Error While deliting the Vendor Master");
            }
            catch (Exception ex)
            {
                Logger.Error("CM000001|Error while deleting Vendor Master Details: " + ex.InnerException.InnerException);
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
            ddlVendorType.DataSource = GetAddressTypeList();
            ddlVendorType.DataValueField = "AddressTypeID";
            ddlVendorType.DataTextField = "AddressTypeName";
            ddlVendorType.DataBind();

            ddlVendorType.Items.Insert(0, new ListItem("Select Vendor Type", "0"));
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
            if (fuVendorMaster.HasFile)
            {
                string FileName = Path.GetFileName(fuVendorMaster.PostedFile.FileName);
                string Extension = Path.GetExtension(fuVendorMaster.PostedFile.FileName);
                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];
                string FilePath = Server.MapPath(FolderPath + FileName);
                fuVendorMaster.SaveAs(FilePath);
                Import_To_Grid(FilePath, Extension, "Yes");
                GetAllVendorMaster();
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
                List<VendorMasterModel> ExcelList = new List<VendorMasterModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    Vendormastermodel = new VendorMasterModel();
                    Vendormastermodel.Bank_Account_Number = dr["Bank Account Number"].ToString() ?? "";
                    Vendormastermodel.Vendor_Name = dr["Vendor Name"].ToString() ?? "";
                    Vendormastermodel.Vendor_No = string.IsNullOrEmpty(dr["Vendor No"].ToString()) ? 0 : Convert.ToInt32(dr["Vendor No"]);
                    Vendormastermodel.Vendor_Type = dr["Vendor Type"].ToString() ?? "";
                    Vendormastermodel.City = dr["City"].ToString() ?? "";
                    Vendormastermodel.Country = dr["Country"].ToString() ?? "";
                    Vendormastermodel.Email = dr["Email"].ToString() ?? "";
                    Vendormastermodel.Equipments = dr["Equipments"].ToString() ?? "";
                    Vendormastermodel.Mobile_Phone = dr["Mobile Phone"].ToString() ?? "";
                    Vendormastermodel.Office_Phone = dr["Office Phone"].ToString() ?? "";
                    Vendormastermodel.Payee_Name = dr["Payee Name"].ToString() ?? "";
                    Vendormastermodel.Post_code = dr["Post code"].ToString() ?? "";
                    Vendormastermodel.Primary_Email = dr["Primary Email"].ToString() ?? "";
                    Vendormastermodel.Secondary_Email = dr["Secondary Email"].ToString() ?? "";
                    Vendormastermodel.Specialties = dr["Specialities"].ToString() ?? "";
                    Vendormastermodel.State = dr["State"].ToString() ?? "";
                    Vendormastermodel.Street_Address = dr["Street Address"].ToString() ?? "";
                    Vendormastermodel.Website = dr["Website"].ToString() ?? "";
                    ExcelList.Add(Vendormastermodel);
                }
                _Vendormastermanagermodel.AddVendorManager(ExcelList, "");
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
                if (columnNames[0] != null && columnNames[0] == "Vendor No")
                    status = true;
                else
                    return status = false;

                if (columnNames[1] != null && columnNames[1] == "Vendor Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[2] != null && columnNames[2] == "Vendor Type")
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

                if (columnNames[16] != null && columnNames[16] == "Specialities")
                    status = true;
                else
                    return status = false;

                if (columnNames[20] != null && columnNames[17] == "Payee Name")
                    status = true;
                else
                    return status = false;

                if (columnNames[21] != null && columnNames[18] == "Bank Account Number")
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
    }
}