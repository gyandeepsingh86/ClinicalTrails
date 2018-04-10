<%@ Page Title="Center Master" Language="C#" MasterPageFile="~/MasterPages/ClinicalTrailMaster.Master" AutoEventWireup="true" CodeBehind="CenterMaster.aspx.cs"
    Inherits="ClinicalTrail.Application.WebApplication.Views.CenterMaster.CenterMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="modal">
                <div class="center">
                    <img alt="" src="loader.gif" />
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>--%>
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblCeneterMasterTitle" runat="server" Text="Please Enter The Center Master Details"></asp:Label>
            </div>
            <div class="row" id="divCenterNumberTab" runat="server" visible="false">
                <div class="column15">
                    <asp:Label ID="lblMode" runat="server" CssClass="label left" Text="Mode"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtMode" runat="server" CssClass="form-control text-left fulllength" Enabled="false"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblCenterNo" runat="server" CssClass="label left" Text="Center Number"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtCenterNumber" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblCenterName" runat="server" CssClass="label left" Text="Center Name"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtCenterName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblCenterType" runat="server" CssClass="label left" Text="Center Type"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtCenterType" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblStreetAddress" runat="server" CssClass="label left" Text="Street Address"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtStreetAddress" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblCity" runat="server" CssClass="label left" Text="City"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblState" runat="server" CssClass="label left" Text="State"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblCountry" runat="server" CssClass="label left" Text="Country"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtCountry" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblPostcode" runat="server" CssClass="label left" Text="Postcode"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblSpecialties" runat="server" CssClass="label left" Text="Specialties"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtSpecialties" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblOfficePhone" runat="server" CssClass="label left" Text="OfficePhone"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtOfficePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblMobilePhone" runat="server" CssClass="label left" Text="MobilePhone"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtMobilePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblEmail" runat="server" CssClass="label left" Text="Email"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblPrimaryEmail" runat="server" CssClass="label left" Text="Primary Email"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtPrimaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblSecondaryEmail" runat="server" CssClass="label left" Text="Secondary Email"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtSecondaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblWebsite" runat="server" CssClass="label left" Text="Website"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtWebsite" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblEquipments" runat="server" CssClass="label left" Text="Equipments"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtEquipments" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblInvestigator1" runat="server" CssClass="label left" Text="Investigator1"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtInvestigator1" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblInvestigator2" runat="server" CssClass="label left" Text="Investigator 2"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtInvestigator2" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblInvestigator3" runat="server" CssClass="label left" Text="Investigator 3"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtInvestigator3" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column15">
                    <asp:Label ID="lblPayeeName" runat="server" CssClass="label left" Text="Payee Name"></asp:Label>
                </div>
                <div class="column30">
                    <asp:TextBox ID="txtPayeeName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column15">
                    <asp:Label ID="lblBankAccountNumbervarchar" runat="server" CssClass="label left" Text="Bank Account Number"></asp:Label>
                </div>
                <div class="column30">
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
                <asp:Label ID="lblUploadCeneterMaster" runat="server" Text="Please Upload Center Master Details"></asp:Label>
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
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn btn-info" OnClick="btnUpload_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Center Master Data"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:GridView ID="grvCenterMaster" CssClass="table table-striped table-bordered table-hover" runat="server" PageSize="5"
                        AutoGenerateColumns="false" ShowFooter="true" AllowSorting="True"
                        OnRowEditing="grvCenterMaster_RowEditing" OnRowCommand="grvCenterMaster_RowCommand" OnRowDataBound="grvCenterMaster_RowDataBound"
                        OnRowDeleting="grvCenterMaster_RowDeleting" OnRowCancelingEdit="grvCenterMaster_RowCancelingEdit" OnRowUpdating="grvCenterMaster_RowUpdating">
                        <Columns>
                            <asp:TemplateField HeaderText="Center No">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCenterNo" runat="server"
                                        Text='<%#Eval("Center_No")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Center Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCenterName" runat="server"
                                        Text='<%#Eval("Center_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Center Type">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCenterType" runat="server"
                                        Text='<%#Eval("Center_Type")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Street Address">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblStreetAddress" runat="server"
                                        Text='<%#Eval("Street_Address")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Specialties">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblSpecialties" runat="server"
                                        Text='<%#Eval("Specialties")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mobile">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblMobilePhone" runat="server"
                                        Text='<%#Eval("Mobile_Phone")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblEmail" runat="server"
                                        Text='<%#Eval("Email")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Equipments">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblEquipments" runat="server"
                                        Text='<%#Eval("Equipments")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnEdit" runat="server" ToolTip="Edit" CommandName="Edit" CommandArgument='<%#Eval("Center_No")%>'>
                                        <span class="icon-edit"></asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" ToolTip="Delete" CommandName="Delete" CommandArgument='<%#Eval("Center_No")%>' OnClientClick="return confirm('Are you sure you?');">
                                        <span class="icon-trash" ></asp:LinkButton>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="btnUpdate" runat="server" ToolTip="Update" CommandName="Update" CommandArgument='<%#Eval("Center_No")%>'>
                                        <span class="icon-refresh"></asp:LinkButton>
                                    <asp:LinkButton ID="btnCancel" runat="server" ToolTip="Cancel" CommandName="Cancle">
                                        <span class="icon-remove"></asp:LinkButton>
                                </EditItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>



