<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stockDetails.aspx.cs" Inherits="bloodBankManagement.stockDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\stockdetails.css" rel="stylesheet" />
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
            <asp:Label ID="Label4" class="lbluser" runat="server" Text=""></asp:Label>
            <asp:Button class="btn" ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />

        </div>
    </div>
</div>

        <%--stock details--%>

        <div id="container_main">
    <div  id="form-body">
        <label>Blood Group</label>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter blood group"></asp:TextBox>
        <label>Collect Date</label>
        <asp:TextBox ID="TextBox2" runat="server" type="date" ></asp:TextBox>
        
    </div>
    <div class="buttons">
        <asp:Button ID="btnSub" runat="server" Text="Search" OnClick="btnSub_Click1"  />
        <asp:Button ID="btnReset" runat="server" Text="Clear" OnClick="btnReset_Click" />
    </div>
    <div id="lblMsg">
        <asp:Label ID="Label9" runat="server" Text="" Visible="False"></asp:Label>

    </div>
</div>
        <div id="heading">
            <h2>Stock Details</h2>

        </div>
<div id="data-table" >
    <asp:Table ID="dataTableBody" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Blood Group</asp:TableHeaderCell>
            <asp:TableHeaderCell>Collection Date</asp:TableHeaderCell>
            <asp:TableHeaderCell>Expiry Date</asp:TableHeaderCell>
        </asp:TableHeaderRow>
                
                
            </asp:Table>
    
</div>

    </form>
</body>
</html>
