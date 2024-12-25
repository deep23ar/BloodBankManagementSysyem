using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bloodBankManagement
{
    public partial class pdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["donorName"] == null && Session["donateDate"] == null)
            {
                Response.Redirect("certificate.aspx");
            }

        }
    }
}