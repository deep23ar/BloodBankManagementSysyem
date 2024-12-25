<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nav.aspx.cs" Inherits="bloodBankManagement.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blood Bank</title>
    <link href="\css\nav.css" rel="stylesheet" />
    
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
                            <asp:HyperLink ID="HyperLink1" NavigateUrl="" runat="server">Home</asp:HyperLink>

                        </li>
                        <li>
                            <asp:HyperLink ID="HyperLink2"  NavigateUrl="" runat="server">Stock Details</asp:HyperLink>

                        </li>
                        <li>
                            <asp:HyperLink ID="HyperLink3"  NavigateUrl="" runat="server">Certificate</asp:HyperLink>

                        </li>
                    </ul>
                </div>
                <div class="right">
                            <asp:HyperLink ID="HyperLink6" class="btn"  NavigateUrl="login.aspx" runat="server">Login</asp:HyperLink>
<asp:HyperLink ID="HyperLink7" class="btn"  NavigateUrl="registration.aspx" runat="server">Register</asp:HyperLink>
                    <asp:Label ID="Label1" class="lbluser" runat="server" Text="Label"></asp:Label>
                    <asp:Button class="btn" ID="Button1" runat="server" Text="Logout" />
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
