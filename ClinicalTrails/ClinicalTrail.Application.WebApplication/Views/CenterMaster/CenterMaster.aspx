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
                <div class="column10">
                    <asp:Label ID="lblMode" runat="server" CssClass="label left" Text="Mode"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtMode" runat="server" CssClass="form-control text-left fulllength" Enabled="false"></asp:TextBox>
                </div>

                <div class="column10">
                    <asp:Label ID="lblCenterNo" runat="server" CssClass="label left" Text="Center Number"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtCenterNumber" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblCenterName" runat="server" CssClass="label left" Text="Center Name"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtCenterName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtCenterName" ControlToValidate="txtCenterName" ErrorMessage="Please enter the Center Name!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtCenterName" ControlToValidate="txtCenterName" ValidationExpression="[0-9a-zA-Z' ']{5,100}$" ErrorMessage="*Valid characters: Alphabets, Number and space (Max 100)." CssClass="alert-danger" Display="Dynamic" />
                </div>

                <div class="column10">
                    <asp:Label ID="lblCenterType" runat="server" CssClass="label left" Text="Center Type"></asp:Label>
                </div>
                <div class="column35">
                    <asp:DropDownList ID="ddlCenterType" runat="server" CssClass="btn btn-primary dropdown-toggle fulllength text-left"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="rfvddlCenterType" ControlToValidate="ddlCenterType" InitialValue="0" ErrorMessage="Please Select Center Type!" CssClass="alert-danger" Display="Dynamic" />
                    <%--<asp:TextBox ID="txtCenterType" runat="server" CssClass="form-control text-left fulllength" Visible="false"></asp:TextBox>--%>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblStreetAddress" runat="server" CssClass="label left" Text="Street Address"></asp:Label>
                </div>
                <div class="column80">
                    <asp:TextBox ID="txtStreetAddress" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtStreetAddress" ControlToValidate="txtStreetAddress" ErrorMessage="Please enter the Street Address!" CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblCity" runat="server" CssClass="label left" Text="City"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtCity" ControlToValidate="txtCity" ErrorMessage="Please enter the City!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtCity" ControlToValidate="txtCity" ValidationExpression="^[a-zA-Z''-'\s]{1,30}$" ErrorMessage="*Valid characters: Alphabets. (Max 30)" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="column10">
                    <asp:Label ID="lblState" runat="server" CssClass="label left" Text="State"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtState" ControlToValidate="txtState" ErrorMessage="Please enter the State!" CssClass="alert-danger" Display="Dynamic" />
                </div>

                <div class="column10">
                    <asp:Label ID="lblCountry" runat="server" CssClass="label left" Text="Country"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCountry" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtCountry" ControlToValidate="txtCountry" ErrorMessage="Please enter the Country!" CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblPostcode" runat="server" CssClass="label left" Text="Postcode"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtPostcode" ControlToValidate="txtPostcode" ErrorMessage="Please enter the Post Code!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtPostcode" ControlToValidate="txtPostcode" ValidationExpression="\b[0-9]{6}\b" ErrorMessage="*Valid characters: Numaric. (Only 6)" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="column10">
                    <asp:Label ID="lblSpecialties" runat="server" CssClass="label left" Text="Specialties"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSpecialties" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtSpecialties" ControlToValidate="txtSpecialties" ErrorMessage="Please enter you Specialties!" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="column10">
                    <asp:Label ID="lblEquipments" runat="server" CssClass="label left" Text="Equipments"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtEquipments" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblOfficePhone" runat="server" CssClass="label left" Text="Office Phone"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtOfficePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rvftxtOfficePhone" ControlToValidate="txtOfficePhone" ErrorMessage="Please enter the Office Phone No!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtOfficePhone" ControlToValidate="txtOfficePhone" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}|(\d[ -]?){10}\d$" ErrorMessage="*Valid characters: Numaric Only." CssClass="alert-danger" Display="Dynamic" />
                </div>

                <div class="column10">
                    <asp:Label ID="lblMobilePhone" runat="server" CssClass="label left" Text="Mobile Phone"></asp:Label>
                </div>
                <div class="column35">
                    <asp:TextBox ID="txtMobilePhone" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtMobilePhone" ControlToValidate="txtMobilePhone" ErrorMessage="Please enter the Mobile Phone No!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtMobilePhone" ControlToValidate="txtMobilePhone" ValidationExpression="^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$" ErrorMessage="*Valid characters: Numaric Only." CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblEmail" runat="server" CssClass="label left" Text="Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtEmail" ControlToValidate="txtEmail" ErrorMessage="Please enter the Email ID!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ErrorMessage="Invalid Email Format!" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPrimaryEmail" runat="server" CssClass="label left" Text="Primary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPrimaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revtxtPrimaryEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtPrimaryEmail" ErrorMessage="Invalid Email Format!" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                <div class="column10">
                    <asp:Label ID="lblSecondaryEmail" runat="server" CssClass="label left" Text="Secondary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSecondaryEmail" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revtxtSecondaryEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtSecondaryEmail" ErrorMessage="Invalid Email Format!" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
            </div>           
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblInvestigator1" runat="server" CssClass="label left" Text="Investigator1"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigator1" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigator2" runat="server" CssClass="label left" Text="Investigator 2"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigator2" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column10">
                    <asp:Label ID="lblInvestigator3" runat="server" CssClass="label left" Text="Investigator 3"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigator3" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblWebsite" runat="server" CssClass="label left" Text="Website"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtWebsite" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPayeeName" runat="server" CssClass="label left" Text="Payee Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPayeeName" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>

                <div class="column10">
                    <asp:Label ID="lblBankAccountNumbervarchar" runat="server" CssClass="label left" Text="Bank Acc Number"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtBankAccountNumbervarchar" runat="server" CssClass="form-control text-left fulllength"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-info" OnClick="btnCancel_Click" CausesValidation="false" />
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-info" OnClick="btnSave_Click" CausesValidation="true" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-info" OnClick="btnUpdate_Click" Visible="false" CausesValidation="true" />
                    <%--<input type="submit" class="btn btn-info" value="Cancel">
                    <input type="submit" class="btn btn-info" value="Save">--%>
                </div>
            </div>
        </div>

        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblUploadCeneterMaster" runat="server" Text="Please Upload Center Master Details"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <div class="col-lg-6 col-sm-6 col-12">
                        <div class="input-group">
                            <asp:FileUpload ID="fuCenterMaster" runat="server" class="btn btn-default btn-file text-left fulllength border-0" />
                        </div>
                    </div>
                    <div class="col-lg-6 col-sm-6 col-12">
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn btn-info" OnClick="btnUpload_Click" />
                    </div>
                </div>
                <div class="column100">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover"
                        AutoGenerateColumns="true" ShowFooter="true" AllowSorting="True"
                        OnPageIndexChanging="PageIndexChanging" AllowPaging="true">
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Center Master Data"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:GridView ID="grvCenterMaster" CssClass="table table-striped table-bordered table-hover" runat="server" PageSize="10" AllowPaging="true"
                        AutoGenerateColumns="false" ShowFooter="true" AllowSorting="True"
                        OnRowEditing="grvCenterMaster_RowEditing" OnRowCommand="grvCenterMaster_RowCommand" OnRowDataBound="grvCenterMaster_RowDataBound"
                        OnRowDeleting="grvCenterMaster_RowDeleting" OnRowCancelingEdit="grvCenterMaster_RowCancelingEdit" OnRowUpdating="grvCenterMaster_RowUpdating"
                        OnPageIndexChanging="grvCenterMaster_PageIndexChanging" >
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
                                    <asp:LinkButton ID="btnEdit" runat="server" ToolTip="Edit" CommandName="Edit" CommandArgument='<%#Eval("Center_No")%>' CausesValidation="False">
                                        <span class="icon-edit"></asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" ToolTip="Delete" CommandName="Delete" CommandArgument='<%#Eval("Center_No")%>' OnClientClick="return confirm('Are you sure you?');" CausesValidation="False">
                                        <span class="icon-trash" ></asp:LinkButton>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="btnUpdate" runat="server" ToolTip="Update" CommandName="Update" CommandArgument='<%#Eval("Center_No")%>' CausesValidation="true">
                                        <span class="icon-refresh"></asp:LinkButton>
                                    <asp:LinkButton ID="btnCancel" runat="server" ToolTip="Cancel" CommandName="Cancle" CausesValidation="False">
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



