using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;




namespace bloodBankManagement
{
    
    public partial class certificate : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Enabled = false;
            HyperLink2.Enabled = false;
            HyperLink3.Enabled = false;

            Button1.Visible = false;
            Label4.Visible = false;

            if (Session["type"] != null)
            {
                Label4.Text = Session["name"].ToString();

                Button1.Visible = true;
                Label4.Visible = true;


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

        protected void btnSub_Click(object sender, EventArgs e)
        {
            SqlConnection con;

            Session["donorName"] = TextBox1.Text.ToString().ToUpper().Trim();
            Session["donateDate"] = TextBox3.Text.ToString().Trim();

            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";
            string qry = "SELECT * FROM [donor] WHERE name = @fname and bloodgroup = @bloodtype and collectdate = @cdate";

            DataSet ds = new DataSet();
            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@fname", TextBox1.Text.ToString().ToLower().Trim());
                    
                    cmd.Parameters.AddWithValue("@bloodtype", DropDownList1.SelectedValue.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@cdate", TextBox3.Text.ToString().ToLower().Trim());

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        
                        con.Open();
                        sda.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Label1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString().ToUpper();
                            Label2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString().ToUpper();
                            DateTime collectDate = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[8].ToString().ToUpper());
                            Label3.Text = collectDate.ToString("MM-dd-yyyy");
                            btnPdf.Visible = true;

                            Label9.Visible = false;



                        }
                        else
                        {
                            Label9.Visible = true;
                            Label9.Text = "We couldn't find any matching records. Make sure your details are correct and try again.";
                            Label9.ForeColor = System.Drawing.Color.Red;

                            Label1.Text = string.Empty;
                            Label2.Text = string.Empty;
                            Label3.Text = string.Empty;
                            btnPdf.Visible = false;

                        }

                    }
                    catch(Exception ex)
                    {
                        btnPdf.Visible = false;
                        Label9.Visible = true;
                        Label9.Text = "Error: Unable to establish a connection to the database. Please check your connection settings and try again.";
                        Label9.ForeColor = System.Drawing.Color.Red;
                        //Label9.Text = ex.Message;
                    }

                    }
        } }

        protected void btnPdf_Click(object sender, EventArgs e)
        {
            Response.Redirect("pdf.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            DropDownList1.Text = string.Empty;
            TextBox3.Text = string.Empty;


            Label1.Text = string.Empty;
            Label2.Text = string.Empty;
            Label3.Text = string.Empty;
            btnPdf.Visible = false;
        }
    }
}