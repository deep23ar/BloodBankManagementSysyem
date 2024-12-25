using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bloodBankManagement
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            HyperLink3.Enabled = false;
            HyperLink4.Enabled = false;
            HyperLink5.Enabled = false;

            Button3.Visible = false;
            Label6.Visible = false;

            if (Session["type"] != null)
            {

                

                if (Session["type"] == "Admin")
                {
                    HyperLink3.Enabled = true;
                    HyperLink4.Enabled = true;
                    HyperLink5.Enabled = true;
                }
                else
                {
                    HyperLink3.Enabled = true;
                    HyperLink4.Enabled = false;
                    HyperLink4.Visible = false;
                    HyperLink5.Enabled = true;
                }
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
           
            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";

            if (DropDownList1.SelectedValue == "User")
            {

                Session["type"] = DropDownList1.SelectedValue;
                Session["name"] = TextBox1.Text+ " " + TextBox2.Text;

                string qry = "SELECT * FROM [user] WHERE fname = @fname and lname = @lname and pass = @pass and email = @email";

                DataSet ds = new DataSet();
                using (con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {

                        cmd.Parameters.AddWithValue("@fname", TextBox1.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@lname", TextBox2.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@email", TextBox3.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@pass", TextBox4.Text.ToString().ToLower().Trim());

                        try
                        {
                            con.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "Record found";
                                lblMsg.ForeColor = System.Drawing.Color.ForestGreen;
                                ClearTextBoxes();
                                Response.Redirect("home.aspx");
                            }
                            else
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "Record not found...";
                                lblMsg.ForeColor = System.Drawing.Color.Red;
                                ClearTextBoxes();
                            }
                        }
                        catch (Exception ex)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = ex.Message.ToString();
                            lblMsg.ForeColor = System.Drawing.Color.Red;
                            ClearTextBoxes();
                        }
                    }

                    con.Close();
                }
            }
            else
            {
                Session["type"] = DropDownList1.SelectedValue;
                Session["name"] = TextBox1.Text + " " + TextBox2.Text;

                string qry = "SELECT * FROM [admin] WHERE fname = @fname and lname = @lname and pass = @pass and email = @email";

                DataSet ds = new DataSet();
                using (con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {

                        cmd.Parameters.AddWithValue("@fname", TextBox1.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@lname", TextBox2.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@email", TextBox3.Text.ToString().ToLower().Trim());
                        cmd.Parameters.AddWithValue("@pass", TextBox4.Text.ToString().ToLower().Trim());

                        try
                        {
                            con.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "Record found";
                                lblMsg.ForeColor = System.Drawing.Color.ForestGreen;
                                ClearTextBoxes();
                                Response.Redirect("home.aspx");
                            }
                            else
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "Record not found...";
                                lblMsg.ForeColor = System.Drawing.Color.Red;
                                ClearTextBoxes();
                            }
                        }
                        catch (Exception ex)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = ex.Message.ToString();
                            lblMsg.ForeColor = System.Drawing.Color.Red;
                            ClearTextBoxes();
                        }
                    }
                }
            }
        }
        private void ClearTextBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            DropDownList1.SelectedIndex = 1;
            

        }
    }
}