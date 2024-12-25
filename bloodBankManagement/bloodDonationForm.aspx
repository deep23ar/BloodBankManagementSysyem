<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bloodDonationForm.aspx.cs" Inherits="bloodBankManagement.bloodDonationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\bloodDonationForm.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
                <div id="container_nav" >
            <div id="nav" >
                <div class="left">
                    <div>
                        <img  src="\img\blood-logo.png" />
                    </div>
                    <ul>
                        <li>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl="home.aspx" runat="server">Home</asp:HyperLink>

                        </li>
                        <li>
                            <asp:HyperLink ID="HyperLink2"  NavigateUrl="stockDetails.aspx" runat="server">Stock Details</asp:HyperLink>

                        </li>
                        <li>
                            <asp:HyperLink ID="HyperLink3"  NavigateUrl="certificate.aspx" runat="server">Certificate</asp:HyperLink>

                        </li>
                    </ul>
                </div>
                <div class="right">
                            <asp:HyperLink ID="HyperLink6" class="btn"  NavigateUrl="login.aspx" runat="server">Login</asp:HyperLink>
<asp:HyperLink ID="HyperLink7" class="btn"  NavigateUrl="registration.aspx" runat="server">Register</asp:HyperLink>
                    <asp:Label ID="Label1" class="lbluser" runat="server" Text="Label"></asp:Label>
                    <asp:Button class="btn" ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" style="height: 26px" />
                </div>
            </div>
        </div>


        <%--form section--%>


        <div class="container_form">
            <h1>Blood Donation Registration Form</h1>

            <div class="form-container">
                <!-- Personal Details Section -->
                <div class="form-section">
                    <h2>Personal Information</h2>
                    <label for="fullName">Full Name:</label>
                    <asp:TextBox ID="txtName" type="text" runat="server" placeholder="Enter your full name" required="required"></asp:TextBox>
                    

                    <label for="age">Age:</label>
                    <asp:TextBox ID="txtAge" type="number" runat="server" placeholder="Enter your age" required="required"></asp:TextBox>
                    

                    <label for="gender">Gender:</label>
                    <asp:DropDownList ID="DropDownListgender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    

                    <label for="bloodType">Blood Type:</label>
                    <asp:DropDownList ID="DropDownListbloodType" runat="server">
                        <asp:ListItem>A+</asp:ListItem>
                        <asp:ListItem>B+</asp:ListItem>
                        <asp:ListItem>O+</asp:ListItem>
                        <asp:ListItem>AB+</asp:ListItem>
                        <asp:ListItem>A-</asp:ListItem>
                        <asp:ListItem>B-</asp:ListItem>
                        <asp:ListItem>O-</asp:ListItem>
                        <asp:ListItem>AB-</asp:ListItem>
                    </asp:DropDownList>
                    
                    <label for="date">Select Date:</label>
                    <asp:TextBox ID="txtDate" type="date" runat="server"  required="required"></asp:TextBox>


                </div>

                <!-- Contact Details Section -->
                <div class="form-section">
                    <h2>Contact Information</h2>
                    <label for="email">Email:</label>
                    <asp:TextBox ID="txtEmail" type="email" runat="server" placeholder="Enter your email" required="required"></asp:TextBox>
                    

                    <label for="phone">Phone Number:</label>
                    <asp:TextBox ID="txtPhone" type="tel" runat="server" placeholder="Enter your phone number" required="required"></asp:TextBox>
                    
                </div>

                <!-- Health Information Section -->
                <div class="form-section">
                    <h2>Health Information</h2>
                    <label for="healthStatus">Do you have any health conditions? (e.g., heart disease, diabetes):</label>
                    <asp:TextBox ID="txtHealthStatus"  runat="server" placeholder="Enter any health conditions" rows="4" TextMode="MultiLine"></asp:TextBox>
                    

                    <label for="medications">Are you currently taking any medications?</label>
                    <asp:TextBox ID="txtMedications"  runat="server" placeholder="Enter medications you're taking" rows="4" TextMode="MultiLine"></asp:TextBox>
                    
                </div>

                <!-- Consent Section -->
                <div class="form-section">
                    <label for="consent">
                        <asp:CheckBox ID="CheckBoxconsent" Text="I agree to donate blood voluntarily and understand the process." runat="server" required />
                        
                    </label>
                </div>

                <!-- Submit Button -->
                <div class="form-section">
                    <asp:Button ID="submitButton" type="submit" runat="server" Text="Register" OnClick="submitButton_Click" />
                    <%--<asp:input type="submit" value="Register" id="submitButton" runat="server" OnClick="SubmitButton_Click" />--%>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
