using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bloodBankManagement
{
    public partial class bloodDonationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Label1.Visible = false;

            if (Session["type"] != null)
            {
                Label1.Text = Session["name"].ToString();

                
                Label1.Visible = true;

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


        protected void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";
            string qry = "INSERT INTO [donor](name, age, gender, bloodgroup, email, mob, disease, other, collectdate) VALUES(@name, @age, @gender, @bloodgroup, @email, @mob, @disease, @other, @cdate)";

            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@age", txtAge.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@gender", DropDownListgender.SelectedValue.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@bloodgroup", DropDownListbloodType.SelectedValue.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@mob", txtPhone.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@disease", txtHealthStatus.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@other", txtMedications.Text.ToString().ToLower().Trim());
                    cmd.Parameters.AddWithValue("@cdate", txtDate.Text.ToString());
                    //cmd.Parameters.AddWithValue("@edate", DateTime.Now.AddDays(365));
                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Response.Write("<script>alert('Registration Successfully completed......')</script>");
                            ClearTextBoxes();
                        }
                        else
                        {
                            Response.Write("<script>alert('Registration not Successfull. Try Again....')</script>");
                            ClearTextBoxes();
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    con.Close();
                }
            }


        }

        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtAge.Text = "";
            DropDownListgender.SelectedIndex = -1;
            DropDownListbloodType.SelectedIndex = -1;
            txtDate.Text = "";
            txtEmail.Text = ""; 
            txtPhone.Text = "";
            txtHealthStatus.Text = "";
            txtMedications.Text = "";
            CheckBoxconsent.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
    
}