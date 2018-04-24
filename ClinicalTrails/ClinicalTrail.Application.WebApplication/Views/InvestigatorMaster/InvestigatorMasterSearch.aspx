<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ClinicalTrailMaster.Master" AutoEventWireup="true" CodeBehind="InvestigatorMasterSearch.aspx.cs" Inherits="ClinicalTrail.Application.WebApplication.Views.InvestigatorMaster.InvestigatorMasterSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblInvestigatorMasterTitle" runat="server" Text="Please Enter The Investigator Master Details"></asp:Label>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblInvestigatorTitle" runat="server" CssClass="label left" Text="Title"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtInvestigatorTitle" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Title"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigatorID" runat="server" CssClass="label left" Text="Investigator ID"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorID" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Investigator ID"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblInvestigatorFName" runat="server" CssClass="label left" Text="First Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorFName" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Invertigator First Name"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigatorMName" runat="server" CssClass="label left" Text="Middle Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorMName" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Invertigator Middle Name"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInvestigatorLName" runat="server" CssClass="label left" Text="Last Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInvestigatorLName" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Invertigator Last Name"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblDegree" runat="server" CssClass="label left" Text="Degree"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtDegree" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Degree"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblAddressType" runat="server" CssClass="label left" Text="Address Type"></asp:Label>
                </div>
                <div class="column20">
                    <asp:DropDownList ID="ddlAddressType" runat="server" CssClass="btn btn-primary dropdown-toggle fulllength text-left"></asp:DropDownList>
                </div>
                <div class="column10">
                    <asp:Label ID="lblInstituteName" runat="server" CssClass="label left" Text="Institute Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtInstituteName" runat="server" CssClass="form-control dropdown text-left fulllength" placeholder="Search by Institute Name"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblStreetAddress" runat="server" CssClass="label left" Text="Street Address"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtStreetAddress" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Street Address"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCity" runat="server" CssClass="label left" Text="City"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by City"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblState" runat="server" CssClass="label left" Text="State"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by State"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCountry" runat="server" CssClass="label left" Text="Country"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCountry" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Country"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPostcode" runat="server" CssClass="label left" Text="Postcode"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Post Code"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblMobilePhone" runat="server" CssClass="label left" Text="MobilePhone"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtMobilePhone" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Mobile Number"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblOfficePhone" runat="server" CssClass="label left" Text="OfficePhone"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtOfficePhone" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Office Number"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblFaxNo" runat="server" CssClass="label left" Text="Fax No"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtFaxNo" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Fax Number"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblCertification" runat="server" CssClass="label left" Text="Certification"></asp:Label>
                </div>
                <div class="column50">
                    <asp:TextBox ID="txtCertification" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Certification"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblSpecialties" runat="server" CssClass="label left" Text="Specialties"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSpecialties" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Specialties"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblEmail" runat="server" CssClass="label left" Text="Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Email"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblPrimaryEmail" runat="server" CssClass="label left" Text="Primary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPrimaryEmail" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Primary Email"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblSecondaryEmail" runat="server" CssClass="label left" Text="Secondary Email"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtSecondaryEmail" runat="server" CssClass="form-control text-left fulllength"  placeholder="Search by Secondary Email"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblCenter1" runat="server" CssClass="label left" Text="Center 1"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter1" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Center 1"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCenter2" runat="server" CssClass="label left" Text="Center 2"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter2" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Center 2"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblCenter3" runat="server" CssClass="label left" Text="Center 3"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtCenter3" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Center 3"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="column10">
                    <asp:Label ID="lblPayeeName" runat="server" CssClass="label left" Text="Payee Name"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtPayeeName" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Payee Name"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblBankAccountNumbervarchar" runat="server" CssClass="label left" Text="Bank Acc No"></asp:Label>
                </div>
                <div class="column20">
                    <asp:TextBox ID="txtBankAccountNumbervarchar" runat="server" CssClass="form-control text-left fulllength" placeholder="Search by Bank Account Number"></asp:TextBox>
                </div>
                <div class="column10">
                    <asp:Label ID="lblIsActive" runat="server" CssClass="label left" Text="Is Active"></asp:Label>
                </div>
                <div class="column20">
                    <asp:CheckBox ID="chkIsActive" runat="server" Checked="true" />
                </div>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-info" OnClick="btnClear_Click" CommandName="Clear" />
                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSearch_Click" CommandName="Search" />
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="Label1" runat="server" Text="Investigator Master Search Data"></asp:Label>
            </div>
            <div class="row">
                <div class="column100">
                    <asp:GridView ID="grvInvestigatorMasterSearch" CssClass="table table-striped table-bordered table-hover" runat="server" PageSize="10" AllowPaging="true"
                        AutoGenerateColumns="false" ShowFooter="true" AllowSorting="True"
                        OnPageIndexChanging="grvInvestigatorMasterSearch_PageIndexChanging">
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
                            <asp:TemplateField HeaderText="First Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorFName" runat="server"
                                        Text='<%#Eval("Investigator_First_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Middle Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblInvestigatorMName" runat="server"
                                        Text='<%#Eval("Investigator_Middle_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Last Name">
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
                            <%--<asp:TemplateField HeaderText="Email ID">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblStreetAddressID" runat="server"
                                        Text='<%#Eval("Street_Address")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField HeaderText="City">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCity" runat="server"
                                        Text='<%#Eval("City")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="State">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblState" runat="server"
                                        Text='<%#Eval("State")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Country">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCountry" runat="server"
                                        Text='<%#Eval("Country")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mobile Phone">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblMobilePhone" runat="server"
                                        Text='<%#Eval("Mobile_Phone")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email ID">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblEmailID" runat="server"
                                        Text='<%#Eval("Email_ID")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="Certification">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCertification" runat="server"
                                        Text='<%#Eval("Certification")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Speciality">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblSpeciality" runat="server"
                                        Text='<%#Eval("Speciality")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField HeaderText="Center 1">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCenter1" runat="server"
                                        Text='<%#Eval("Centre_1")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="Center 2">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblCenter2" runat="server"
                                        Text='<%#Eval("Centre_2")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                           <%-- <asp:TemplateField HeaderText="Payee Name">
                                <ItemTemplate>
                                    <asp:Label ID="grvlblPayeeName" runat="server"
                                        Text='<%#Eval("Payee_Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                        <EmptyDataTemplate>
                            <asp:Label ID="lblEmptyGridMessage" runat="server" CssClass="info text-center fulllength" Text="Oops!! No Record Found, Please search again"></asp:Label>
                        </EmptyDataTemplate>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
