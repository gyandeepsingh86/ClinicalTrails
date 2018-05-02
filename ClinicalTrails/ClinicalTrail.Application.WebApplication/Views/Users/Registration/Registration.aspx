<%@ Page Title="User Registration Form" Language="C#" MasterPageFile="~/MasterPages/LoginAndRegistrationMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ClinicalTrail.Application.WebApplication.Views.Users.Registration.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="lblCeneterMasterTitle" runat="server" Text="Please Enter all the required user details"></asp:Label>
        </div>
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

            <h4>Password</h4>
            <div class="row">
                <div class="input-group input-group-icon column35">
                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-key"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtPassword" ControlToValidate="txtPassword" ErrorMessage="Please enter Password!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPassword"
                        ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,10}"
                        ErrorMessage="Password must contain: Minimum 8 and Maximum 10 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character"
                        ForeColor="Red" Display="Dynamic" />
                </div>
                <div class="input-group input-group-icon column30">
                    <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-key"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtConfirmPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Please enter the password again to confirm!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator ID="Regex5" runat="server" ControlToValidate="txtConfirmPassword"
                        ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,10}"
                        ErrorMessage="Password must contain: Minimum 8 and Maximum 10 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character"
                        ForeColor="Red" Display="Dynamic" />
                    <asp:CompareValidator ID="comptxtConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" CssClass="ValidationError" ControlToCompare="txtPassword"
                        ErrorMessage="Password and Confirm Password Should be same" ToolTip="Password must be the same" Display="Dynamic" />
                </div>
            </div>

            <h4>Gender</h4>
            <div class="row">
                <div class="input-group input-group-icon column35">
                    <asp:RadioButtonList ID="rbGender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="input-group input-group-icon">
                        <asp:ListItem Text="Male" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Trans-Gender" Value="2"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>

            <h4>Date of Birth</h4>
            <div class="row">
                <div class="input-group input-group-icon column35">
                    <asp:TextBox ID="txtDOB" runat="server" placeholder="Date of Birth"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-calendar"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtDOB" ControlToValidate="txtDOB" ErrorMessage="Please enter the Date!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtDOB" ControlToValidate="txtDOB" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"
                        ErrorMessage="*Valid characters: Date only for DD/MM/YYYY" CssClass="alert-danger" Display="Dynamic" />
                    <script src="../../../Scripts/jquery-ui-1.12.1.min.js"></script>
                    <script src="../../../Scripts/jquery.globalize/globalize.js"></script>
                    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
                    <script type="text/javascript">
                        $(document).ready(function () {
                            $('#MainContent_txtDOB').datepicker({
                                format: "dd/mm/yyyy"
                            });
                        });
                    </script>
                </div>
            </div>

            <h4>Email</h4>
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

            <h4>Address</h4>
            <div class="row">
                <div class="input-group input-group-icon column65">
                    <asp:TextBox ID="txtStreetAddress" runat="server"  placeholder="Please enter the street address"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-location-arrow"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtStreetAddress" ControlToValidate="txtStreetAddress" ErrorMessage="Please enter the Street Address!" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="input-group input-group-icon column35">
                    <asp:TextBox ID="txtPostcode" runat="server"  placeholder="Enter Pincode"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-map"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtPostcode" ControlToValidate="txtPostcode" ErrorMessage="Please enter the Post Code!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtPostcode" ControlToValidate="txtPostcode" ValidationExpression="\b[0-9]{6}\b" ErrorMessage="*Valid characters: Numaric. (Only 6)" CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
            <div class="row">
                <div class="input-group input-group-icon column35">
                    <asp:TextBox ID="txtCity" runat="server"  placeholder="Enter City"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-circle"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtCity" ControlToValidate="txtCity" ErrorMessage="Please enter the City!" CssClass="alert-danger" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ID="revtxtCity" ControlToValidate="txtCity" ValidationExpression="^[a-zA-Z''-'\s]{1,30}$" ErrorMessage="*Valid characters: Alphabets. (Max 30)" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class=" input-group input-group-icon column30">
                    <asp:TextBox ID="txtState" runat="server"  placeholder="Enter State"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-star"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtState" ControlToValidate="txtState" ErrorMessage="Please enter the State!" CssClass="alert-danger" Display="Dynamic" />
                </div>
                <div class="input-group input-group-icon column35">
                    <asp:TextBox ID="txtCountry" runat="server"  placeholder="Enter Country"></asp:TextBox>
                    <div class="input-icon"><i class="fa fa-arrows"></i></div>
                    <asp:RequiredFieldValidator runat="server" ID="rfvtxtCountry" ControlToValidate="txtCountry" ErrorMessage="Please enter the Country!" CssClass="alert-danger" Display="Dynamic" />
                </div>
            </div>
            <br />
            <br />
            <div class="row align-content-center">
                <div class="input-group column10">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="btn btn-info" />
                </div>
                <div class="input-group column10">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-info" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
