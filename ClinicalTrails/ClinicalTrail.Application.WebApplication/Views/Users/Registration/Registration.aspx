<%@ Page Title="User Registration Form" Language="C#" MasterPageFile="~/MasterPages/LoginAndRegistrationMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ClinicalTrail.Application.WebApplication.Views.Users.Registration.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Please Enter All The Required Details</h4>
    <div class="container">
        <h4>Account</h4>
        <div class="row">
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-user"></i></div>
                <asp:RequiredFieldValidator runat="server" ID="rfvtxtFirstName" ControlToValidate="txtFirstName" ErrorMessage="Please enter the First Name!" CssClass="alert-danger" Display="Dynamic" />
                <asp:RegularExpressionValidator runat="server" ID="revtxtFirstName" ControlToValidate="txtFirstName" ValidationExpression="[a-zA-Z' ']{5,50}$" ErrorMessage="*Valid characters: Alphabets, Number and space (Min 5 - Max 50)." CssClass="alert-danger" Display="Dynamic" />
            </div>
            <div class="input-group input-group-icon column30">
                <asp:TextBox ID="txtMiddleNamw" runat="server" placeholder="Middle Name"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-user"></i></div>
                <asp:RegularExpressionValidator runat="server" ID="revtxtMiddleNamw" ControlToValidate="txtMiddleNamw" ValidationExpression="[a-zA-Z' ']{5,50}$" ErrorMessage="*Valid characters: Alphabets, Number and space (Min 5 - Max 50)." CssClass="alert-danger" Display="Dynamic" />
            </div>
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-user"></i></div>
                <asp:RequiredFieldValidator runat="server" ID="rfvtxtLastName" ControlToValidate="txtLastName" ErrorMessage="Please enter the Last Name!" CssClass="alert-danger" Display="Dynamic" />
                <asp:RegularExpressionValidator runat="server" ID="revtxtLastName" ControlToValidate="txtLastName" ValidationExpression="[a-zA-Z' ']{5,50}$" ErrorMessage="*Valid characters: Alphabets, Number and space (Min 5 - Max 50)." CssClass="alert-danger" Display="Dynamic" />
            </div>
        </div>

        <h4>Email Account</h4>
        <div class="row">
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtPrimaryEmailID" runat="server" placeholder="Primary Email ID"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-envelope"></i></div>
                <asp:RequiredFieldValidator runat="server" ID="rfvtxtEmail" ControlToValidate="txtPrimaryEmailID" ErrorMessage="Please enter the Email ID!" CssClass="alert-danger" Display="Dynamic" />
                <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtPrimaryEmailID" ErrorMessage="Invalid Email Format!" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
            </div>
            <div class="input-group input-group-icon column30">
                <asp:TextBox ID="txtSecondaryEmailID" runat="server" placeholder="Secondary Email ID"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-envelope"></i></div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtSecondaryEmailID" ErrorMessage="Invalid Email Format!" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
            </div>
        </div>

        <h4>Phone Numbers</h4>
        <div class="row">
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtMobileNumber" runat="server" placeholder="Mobile Number"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-mobile"></i></div>
                <asp:RequiredFieldValidator runat="server" ID="rfvtxtMobilePhone" ControlToValidate="txtMobileNumber" ErrorMessage="Please enter the Mobile Phone No!" CssClass="alert-danger" Display="Dynamic" />
                <asp:RegularExpressionValidator runat="server" ID="revtxtMobilePhone" ControlToValidate="txtMobileNumber" ValidationExpression="^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$" ErrorMessage="*Valid characters: Numaric Only." CssClass="alert-danger" Display="Dynamic" />
            </div>
            <div class="input-group input-group-icon column30">
                <asp:TextBox ID="txtOfficeNumber" runat="server" placeholder="Office Number"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-phone"></i></div>
                <asp:RegularExpressionValidator runat="server" ID="revtxtOfficePhone" ControlToValidate="txtOfficeNumber" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}|(\d[ -]?){10}\d$" ErrorMessage="*Valid characters: Numaric Only." CssClass="alert-danger" Display="Dynamic" />
            </div>
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtFAXNumber" runat="server" placeholder="Fax Number"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-fax"></i></div>
                <asp:RegularExpressionValidator runat="server" ID="revtxtFAXNumber" ControlToValidate="txtFAXNumber" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}|(\d[ -]?){10}\d$" ErrorMessage="*Valid characters: Numaric Only." CssClass="alert-danger" Display="Dynamic" />
            </div>
        </div>

        <h4>Date of Birth</h4>
        <div class="row">
            <div class="input-group input-group-icon column50">
                <div class="container">
                    <div class="row">
                        <div class='col-sm-6'>
                            <div class="form-group">
                                <div class='input-group date' id='datetimepicker1'>
                                    <input type='text' class="form-control" />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <script type="text/javascript">
                            $(function () {
                                $('#datetimepicker1').datetimepicker();
                            });
                        </script>
                    </div>
                </div>
                <div class="col-third">
                    <asp:TextBox ID="txtDate" runat="server" placeholder="DD"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtDate" ControlToValidate="txtDate" ErrorMessage="Please enter the Date!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtDate" ControlToValidate="txtDate" ValidationExpression="[0-9]{2}$" ErrorMessage="*Valid characters: Number(Only 2)." CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="col-third">
                    <asp:TextBox ID="txtMonth" runat="server" placeholder="MM"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtMonth" ControlToValidate="txtMonth" ErrorMessage="Please enter the Month!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtMonth" ControlToValidate="txtMonth" ValidationExpression="[0-9]{2}$" ErrorMessage="*Valid characters: Number(Only 2)." CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="col-third">
                    <asp:TextBox ID="txtYear" runat="server" placeholder="YYYY"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtYear" ControlToValidate="txtYear" ErrorMessage="Please enter the Year!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtYear" ControlToValidate="txtYear" ValidationExpression="[0-9]{4}$" ErrorMessage="*Valid characters: Number(Only 4)." CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
        </div>

        <h4>Gender</h4>
        <div class="row">
            <div class="input-group input-group-icon column60">
                <input type="radio" name="gender" value="male" id="gender-male" />
                <label for="gender-male">Male</label>
                <input type="radio" name="gender" value="female" id="gender-female" />
                <label for="gender-female">Female</label>
            </div>
        </div>

        <h4>Password</h4>
        <div class="row">
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-key"></i></div>
            </div>
            <div class="input-group input-group-icon column35">
                <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                <div class="input-icon"><i class="fa fa-key"></i></div>
            </div>
        </div>

        <br />
        <br />
        <div class="row">
            <div class="input-group column10">
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="btn btn-info" />
            </div>
            <div class="input-group column10">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-info" />
            </div>
        </div>
    </div>
</asp:Content>
