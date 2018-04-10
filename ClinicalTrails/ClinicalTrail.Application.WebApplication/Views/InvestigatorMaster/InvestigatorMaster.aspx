<%@ Page Title="Investigator Master" Language="C#" MasterPageFile="~/MasterPages/ClinicalTrailMaster.Master" AutoEventWireup="true" CodeBehind="InvestigatorMaster.aspx.cs" Inherits="ClinicalTrail.Application.WebApplication.Views.InvestigatorMaster.InvestigatorMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblInvestigatorMasterTitle" runat="server" Text="Please Enter The Investigator Master Details"></asp:Label>
            </div>
            <div class="row" id="divInvestigatorNumberTab" runat="server" visible="false">
                <div class="column10">
                    <asp:Label ID="lblMode" runat="server" CssClass="label left" Text="Mode"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtMode" runat="server" CssClass="form-control text-left fulllength" Enabled="false"></asp:TextBox>
                </div>

                <div class="column10">
                    <asp:Label ID="lblInvestigatorID" runat="server" CssClass="label left" Text="Investigator ID"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtInvestigatorID" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblInvestigatorTitle" runat="server" CssClass="label left" Text="Title"></asp:Label>
                </div>
                <div class="column80">
                    <asp:TextBox ID="txtInvestigatorTitle" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblInvestigatorFName" runat="server" CssClass="label left" Text="Invst First Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorFName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigatorMName" runat="server" CssClass="label left" Text="Invst Mid Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorMName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigatorLName" runat="server" CssClass="label left" Text="Invst Last Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorLName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblDegree" runat="server" CssClass="label left" Text="Degree"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtDegree" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblAddressType" runat="server" CssClass="label left" Text="Address Type"></asp:Label>
                </div>
                <div class="column20">
                    <asp:DropDownList ID="ddlAddressType" runat="server" CssClass="btn btn-primary dropdown-toggle fulllength text-left" ></asp:DropDownList>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInstituteName" runat="server" CssClass="label left" Text="Institute Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInstituteName" runat="server" CssClass="form-control dropdown text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblStreetAddress" runat="server" CssClass="label left" Text="Street Address"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtStreetAddress" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCity" runat="server" CssClass="label left" Text="City"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblState" runat="server" CssClass="label left" Text="State"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCountry" runat="server" CssClass="label left" Text="Country"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCountry" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPostcode" runat="server" CssClass="label left" Text="Postcode"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblMobilePhone" runat="server" CssClass="label left" Text="MobilePhone"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtMobilePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblOfficePhone" runat="server" CssClass="label left" Text="OfficePhone"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtOfficePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblFaxNo" runat="server" CssClass="label left" Text="Fax No"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtFaxNo" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblCertification" runat="server" CssClass="label left" Text="Certification"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtCertification" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblSpecialties" runat="server" CssClass="label left" Text="Specialties"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSpecialties" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblEmail" runat="server" CssClass="label left" Text="Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPrimaryEmail" runat="server" CssClass="label left" Text="Primary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPrimaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblSecondaryEmail" runat="server" CssClass="label left" Text="Secondary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSecondaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>           
            <div class="row">
                 <div class="column10">
                    <asp:Label ID="lblCenter1" runat="server" CssClass="label left" Text="Center 1"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter1" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCenter2" runat="server" CssClass="label left" Text="Center 2"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter2" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCenter3" runat="server" CssClass="label left" Text="Center 3"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter3" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblPayeeName" runat="server" CssClass="label left" Text="Payee Name"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtPayeeName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column10">
                    <asp:Label ID="lblBankAccountNumbervarchar" runat="server" CssClass="label left" Text="Bank Acc No"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtBankAccountNumbervarchar" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-info" OnClick="btnCancel_Click" />
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-info" OnClick="btnSave_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-info" OnClick="btnUpdate_Click" Visible="false" />
                    <%--<input type="submit" class="btn btn-info" value="Cancel">
                    <input type="submit" class="btn btn-info" value="Save">--%>
                </div>
            </div>
        </div>
        <script type="text/javascript">
            $(function () {

                // We can attach the `fileselect` event to all file inputs on the page
                $(document).on('change', ':file', function () {
                    var input = $(this),
                        numFiles = input.get(0).files ? input.get(0).files.length : 1,
                        label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
                    input.trigger('fileselect', [numFiles, label]);
                });

                // We can watch for our custom `fileselect` event like this
                $(document).ready(function () {
                    $(':file').on('fileselect', function (event, numFiles, label) {

                        var input = $(this).parents('.input-group').find(':text'),
                            log = numFiles > 1 ? numFiles + ' files selected' : label;

                        if (input.length) {
                            input.val(log);
                        } else {
                            if (log) alert(log);
                        }

                    });
                });

            });
        </script>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblUploadInvestigatorMaster" runat="server" Text="Please Upload Investigator Master Details"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <div class="col-lg-6 col-sm-6 col-12">
                        <div class="input-group">
                            <input type="text" class="form-control">
                            <label class="input-group-btn">
                                <span class="btn btn-primary">
                                    <asp:Button ID="file" runat="server" Text="Browse" />
                                </span>
                            </label>
                        </div>
                    </div>
                    <div class="col-lg-6 col-sm-6 col-12">
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn btn-info"/>
                    </div>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Investigator Master Data"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:GridView ID="grvInvestigatorMaster" CssClass="table table-striped table-bordered table-hover" runat="server" PageSize="5"
                        AutoGenerateColumns="false" ShowFooter="true" AllowSorting="True" OnRowEditing="grvInvestigatorMaster_RowEditing" OnRowDeleting="grvInvestigatorMaster_RowDeleting"  >
                        <Columns>
                            <asp:TemplateField HeaderText="Inv No">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorNo" runat="server"
                                        Text='<%#Eval("ID")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Title">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblTitle" runat="server"
                                        Text='<%#Eval("Title")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Inv First Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorFName" runat="server"
                                        Text='<%#Eval("Investigator_First_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Inv Middle Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorMName" runat="server"
                                        Text='<%#Eval("Investigator_Middle_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Inv Last Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorLName" runat="server"
                                        Text='<%#Eval("Investigator_Last_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Degree">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblDegree" runat="server"
                                        Text='<%#Eval("Degree")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Address Type">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblAddressType" runat="server"
                                        Text='<%#Eval("Address_Type")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Institute Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInstituteName" runat="server"
                                        Text='<%#Eval("Institute_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email ID">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblEmailID" runat="server"
                                        Text='<%#Eval("Email_ID")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnEdit" runat="server" ToolTip="Edit" CommandName="Edit" CommandArgument='<%#Eval("ID")%>'>
                                        <span class="icon-edit"></asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" ToolTip="Delete" CommandName="Delete" CommandArgument='<%#Eval("ID")%>' OnClientClick="return confirm('Are you sure you?');">
                                        <span class="icon-trash" ></asp:LinkButton>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="btnUpdate" runat="server" Visible="true" ToolTip="Update" CommandName="Update" CommandArgument='<%#Eval("ID")%>'>
                                        <span class="icon-refresh"></asp:LinkButton>
                                    <asp:LinkButton ID="btnCancel" runat="server" Visible="true" ToolTip="Cancel" CommandName="Cancle">
                                        <span class="icon-remove"></asp:LinkButton>
                                </EditItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            <asp:Label ID="lblEmptyGridMessage" runat="server" CssClass="info text-center fulllength" Text="Oops!! No Record Found, Please add new record" ></asp:Label></EmptyDataTemplate>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
