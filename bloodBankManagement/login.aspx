<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="bloodBankManagement.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\login.css" rel="stylesheet" />
</head>
<body class="container-fluid m-3" >
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
            
<asp:Label ID="Label6" class="lbluser" runat="server" Text="Label"></asp:Label>
            <asp:Button class="btn" ID="Button3" runat="server" Text="Logout" />
                    
        </div>
    </div>
</div>

        <%--login form -----------%>

        <div id="container_main">
            <asp:Label ID="Label1"  runat="server" Text="Type:"></asp:Label>
    <asp:DropDownList ID="DropDownList1"  runat="server" >
        <asp:ListItem>Admin</asp:ListItem>
        <asp:ListItem Selected="True">User</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter first name" required="required"></asp:TextBox>
    <asp:Label ID="Label3"  runat="server" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="TextBox2"  runat="server" Type="text" placeholder="Enter last name" required="required"></asp:TextBox>
            <asp:Label ID="Label4"  runat="server" Text="E-mail:"></asp:Label>
<asp:TextBox ID="TextBox3"  runat="server" Type="email" placeholder="Enter email" required="required"></asp:TextBox>
                        <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
<asp:TextBox ID="TextBox4" TextMode="Password"  runat="server" Type="password" placeholder="Enter password" required="required"></asp:TextBox>
    <asp:Button class="btn" ID="Button1"  runat="server" Text="Login" OnClick="Button1_Click" />
    <asp:Button class="btn" ID="Button2"  runat="server" Text="Cancel" OnClick="Button2_Click"  />
    <div id="links">
        <asp:HyperLink ID="HyperLink1" class="fw-bolder" runat="server" NavigateUrl="~/registration.aspx">Register Now</asp:HyperLink> || <asp:HyperLink ID="HyperLink2" class="fw-bolder" NavigateUrl="~/forgotPass.aspx" runat="server">Forgot Password</asp:HyperLink>
    </div>
    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
</div>
    </form>
</body>
</html>
