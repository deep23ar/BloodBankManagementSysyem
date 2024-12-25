<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="bloodBankManagement.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="\css\nav.css" rel="stylesheet" />
    <link href="\css\home.css" rel="stylesheet" />
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
                    <asp:Button class="btn" ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
                </div>
            </div>
        </div>

         <%--body section--%>

        <div id="container_main">
            <div id="sec_1" class="section">
        <asp:Image ID="Image1" ImageUrl="~/img/hero.jpg" runat="server" />
        <h1>"Be the reason someone smiles today—donate blood and spread hope."</h1>
        <a href="bloodDonationForm.aspx" class="hero-btn">Donate Now</a>
    </div>
        </div>

        <%--review container--%>

        <div class="review-container">
        <h2>Blood Camp Reviews</h2>
            <div class="reviews">
                <div class="review">
                    <strong>"The camp was great overall, but the waiting time could be reduced to make it even better."</strong>
                    <p>-John Doe</p>
                </div>
            <div class="review">
    <strong>"It would be helpful to have more signage and directions at the venue for first-timers like me."</strong>
    <p>-Jane Smith</p>
</div>
                        <div class="review">
    <strong>"The staff was friendly, but the registration process was slightly slow. Improving this would enhance the experience."
</strong> 
    <p>-Mei Ling</p>
</div>
                </div>
    </div>

        <%--social work containt--%>

        <div class="container_socialwork">
            <h1>Our Social Work in the Last 10 Years</h1>

            <div id="socialWorkContent">
                <div class="social-work-item">
    <h3>Annual Blood Donation Marathon - 2021</h3>
    <p><strong>Date:</strong> August 5, 2021</p>
    <p><strong>Description:</strong> A marathon event to encourage blood donation, with free health checkups.</p>
    <p><strong>Impact:</strong> Over 300 participants, 150 liters of blood donated.</p>
</div>
                <div class="social-work-item">
    <h3>Health Awareness Campaign - 2022</h3>
    <p><strong>Date:</strong> May 10, 2022</p>
    <p><strong>Description:</strong> Educational campaign focused on promoting the importance of blood donation.</p>
    <p><strong>Impact:</strong> Engaged over 5,000 people, with 500+ new donors registered.</p>
</div>

                <div class="social-work-item">
    <h3>Blood Donation Drive - Winter 2023</h3>
    <p><strong>Date:</strong> December 15, 2023</p>
    <p><strong>Description:</strong> A large-scale blood donation drive organized in the city center.</p>
    <p><strong>Impact:</strong> Collected over 200 liters of blood, saved over 1,000 lives.</p>
</div>





            </div>

            </div>
        <%--footer section--%>

        <footer id="footer">
    <div class="footer-container">
        <div class="footer-section">
            <h3>About Us</h3>
            <p>Your trusted partner in saving lives through blood donation. Together, we can make a difference!</p>
        </div>
        <div class="footer-section">
            <h3>Contact Us</h3>
            <p>Phone: +123 456 7890</p>
            <p>Email: info@bloodbank.com</p>
            <p>Address: 123 Blood Bank Street, Cityville</p>
        </div>
        <div class="footer-section">
            <h3>Quick Links</h3>
            <ul>
                <li><asp:HyperLink ID="HyperLink4" NavigateUrl="~/home.aspx" runat="server">Home</asp:HyperLink></li>
                <li>
                    <asp:HyperLink ID="HyperLink5" NavigateUrl="~/registration.aspx" runat="server">Donate Blood</asp:HyperLink></li>
                <li>
                    <asp:HyperLink ID="HyperLink8" NavigateUrl="#" runat="server">Contact</asp:HyperLink></li>
                <li>
                    <asp:HyperLink ID="HyperLink9" NavigateUrl="#" runat="server">Certificate</asp:HyperLink></li>
            </ul>
        </div>
    </div>
    <div class="footer-bottom">
        <p>&copy; 2024 Blood Bank. All rights reserved.</p>
    </div>
</footer>



    </form>
</body>
</html>
