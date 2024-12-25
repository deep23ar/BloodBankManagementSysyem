using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bloodBankManagement
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            HyperLink3.Enabled = false;
            HyperLink4.Enabled = false;
            HyperLink5.Enabled = false;

            Button3.Visible = false;
            Label9.Visible = false;

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";
            string qry = "INSERT INTO [user](fname, lname, dob, age, gender, pass, mob, email) VALUES(@fname, @lname, @dob, @age, @gender, @pass, @mob, @email)";

            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@fname", TextBox1.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@lname", TextBox2.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@dob", TextBox3.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@age", TextBox4.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@gender", RadioButtonList1.SelectedValue.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@pass", TextBox5.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@mob", TextBox6.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@email", TextBox7.Text.ToString().ToLower().Trim());
                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Inserted Successfully...";
                            lblMsg.ForeColor = System.Drawing.Color.ForestGreen;
                            ClearTextBoxes();
                            Response.Redirect("login.aspx");
                    }
                        else
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record not Inserted...";
                            lblMsg.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = ex.Message.ToString();
                        lblMsg.ForeColor = System.Drawing.Color.Red;
                    }
                    con.Close();
                }
            }
            

        }

        private void ClearTextBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            RadioButtonList1.SelectedIndex = -1; // Clear radio button selection
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";

        }
    }
}