using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bloodBankManagement
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HyperLink1.Enabled = false;
            HyperLink2.Enabled = false;
            HyperLink3.Enabled = false;

            

            if (Session["type"] != null)
            {
                Label1.Text = Session["name"].ToString();

                HyperLink6.Visible = false;
                HyperLink7.Visible = false;

                if (Session["type"] == "Admin")
                {
                    
                    HyperLink1.Enabled = true;
                    HyperLink2.Enabled = true;
                    HyperLink3.Enabled = true;
                }
                else
                {
                    
                    HyperLink1.Enabled = true;
                    HyperLink2.Enabled = false;
                    HyperLink2.Visible = false;
                    HyperLink3.Enabled = true;
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}