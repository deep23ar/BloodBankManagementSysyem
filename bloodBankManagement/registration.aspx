<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="bloodBankManagement.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\reg.css" rel="stylesheet" />
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
                    <asp:HyperLink ID="HyperLink3" NavigateUrl="home.aspx" runat="server">Home</asp:HyperLink>

                </li>
                <li>
                    <asp:HyperLink ID="HyperLink4"  NavigateUrl="stockDetails.aspx" runat="server">Stock Details</asp:HyperLink>

                </li>
                <li>
                    <asp:HyperLink ID="HyperLink5"  NavigateUrl="certificate.aspx" runat="server">Certificate</asp:HyperLink>

                </li>
            </ul>
        </div>
        <div class="right">
                    <asp:HyperLink ID="HyperLink6" class="btn"  NavigateUrl="login.aspx" runat="server">Login</asp:HyperLink>
<asp:HyperLink ID="HyperLink7" class="btn"  NavigateUrl="registration.aspx" runat="server">Register</asp:HyperLink>
            <asp:Label ID="Label9" class="lbluser" runat="server" Text="Label"></asp:Label>
            <asp:Button class="btn" ID="Button3" runat="server" Text="Logout" />

        </div>
    </div>
</div>

        <%--registration form -----------%>

                <div id="container_main">
            
    <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter first name" required="required"></asp:TextBox>
    <asp:Label ID="Label2"  runat="server" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="TextBox2"  runat="server" Type="text" placeholder="Enter last name" required="required"></asp:TextBox>
    <asp:Label ID="Label3"  runat="server" Text="Date of Birth:"></asp:Label>
    <asp:TextBox ID="TextBox3"  runat="server" Type="date" placeholder="Enter date of birth" required="required"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Age:"></asp:Label>
    <asp:TextBox ID="TextBox4"  runat="server" Type="text" placeholder="Enter your age" required="required"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Text="Gender:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>  
    <asp:Label ID="Label6" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="TextBox5" type="password" runat="server" placeholder="Enter password" required="required"></asp:TextBox>
    <asp:Label ID="Label7"  runat="server" Text="Phone No.:"></asp:Label>
    <asp:TextBox ID="TextBox6" Type="text" runat="server" placeholder="Enter phone no" required="required"></asp:TextBox>
                    <asp:Label ID="Label8"  runat="server"  Text="Email:"></asp:Label>
<asp:TextBox ID="TextBox7" type="email" runat="server" placeholder="Enter valid email" required="required"></asp:TextBox>
                    
                    <asp:Button class="btn" ID="Button1"  runat="server" Text="Submit" OnClick="Button1_Click"  />
    <asp:Button class="btn" ID="Button2"  runat="server" Text="Cancel"   />
    
    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
</div>
    </form>
</body>
</html>
