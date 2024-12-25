<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="certificate.aspx.cs" Inherits="bloodBankManagement.certificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\certificate.css" rel="stylesheet" />
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
            
<asp:Label ID="Label4" class="lbluser" runat="server" Text="Label"></asp:Label>
            <asp:Button class="btn" ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
        </div>
    </div>
</div>

        <%--certificate--%>

        <div id="container_main">
            <div id="heading">
                <h2>Download Certificate</h2>

            </div>
    <div  id="form-body">
        <label>First Name:</label>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your full name"></asp:TextBox>
        
        <label>Blood Group:</label>
            <asp:DropDownList ID="DropDownList1"  runat="server" >
    <asp:ListItem>A+</asp:ListItem>
    <asp:ListItem>A-</asp:ListItem>
    <asp:ListItem>B+</asp:ListItem>
<asp:ListItem>B-</asp:ListItem>
    <asp:ListItem>AB+</asp:ListItem>
<asp:ListItem>AB-</asp:ListItem>
    <asp:ListItem>O+</asp:ListItem>
<asp:ListItem>O-</asp:ListItem>
</asp:DropDownList>
        <label>Date:</label>
        <asp:TextBox ID="TextBox3" runat="server" type="date" ></asp:TextBox>
    </div>
    <div class="buttons">
        <asp:Button ID="btnSub" runat="server" Text="Search" OnClick="btnSub_Click" />
        <asp:Button ID="btnReset" runat="server" Text="Clear" OnClick="btnReset_Click" />
    </div>
    <div id="lblMsg">
        <asp:Label ID="Label9" runat="server" Text="" Visible="False"></asp:Label>

    </div>
</div>
        
<div id="data-table" >
    <table>
        <tr>
            <th>Name</th>
            <th>Collect Date</th>
            <th>Blood Group</th>
            <th>Download Certificate</th>
        </tr>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
            <td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
            <td><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
            
            <td><asp:Button ID="btnPdf" runat="server" Text="Button" Visible="False" OnClick="btnPdf_Click" /></td>
        </tr>
        
    </table>
    
    

</div>
    </form>
</body>
</html>
