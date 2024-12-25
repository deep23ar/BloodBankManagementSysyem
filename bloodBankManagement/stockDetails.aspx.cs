using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace bloodBankManagement
{
    public partial class stockDetails : System.Web.UI.Page
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

            
                //showDetails();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }

        public void showDetails()
        {
            SqlConnection con;
            
            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";
            string qry = "SELECT bloodgroup, collectdate FROM [donor]";

            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {


                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        con.Open();
                        sda.Fill(dt);

                        

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                
                                TableRow tr = new TableRow();

                                // Blood Group Cell
                                TableCell bloodGroupCell = new TableCell
                                {
                                    Text = row["bloodgroup"].ToString()
                                };
                                tr.Cells.Add(bloodGroupCell);

                                // Collection Date Cell
                                TableCell collectDateCell = new TableCell
                                {
                                    Text = Convert.ToDateTime(row["collectdate"]).ToString("MM-dd-YYYY")
                                };
                                tr.Cells.Add(collectDateCell);

                                // Expiry Date Cell
                                DateTime collectDate = Convert.ToDateTime(row["collectdate"]);
                                DateTime expDate = collectDate.AddDays(365); // Assuming expiry is one year from collection
                                TableCell expDateCell = new TableCell
                                {
                                    Text = expDate.ToString("MM-dd-YYYY")
                                };
                                tr.Cells.Add(expDateCell);

                                // Add TableRow to Table
                                
                                dataTableBody.Rows.Add(tr);
                            }
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    finally
                    {
                        // Ensure that the connection is always closed
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                    
                }
            }
        }


        protected void btnReset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";

            Label9.Text = "";
            Label9.Visible = false;

            ViewState["bloodtype"] = null;
            ViewState["date"] = null;

            
        }

        protected void btnSub_Click1(object sender, EventArgs e)
        {
            SqlConnection con;

            ViewState["bloodtype"] = TextBox1.Text.ToString().ToLower().Trim();
            ViewState["date"] = TextBox2.Text.ToString().ToLower().Trim();

            string conStr = "Data Source=DESKTOP-6502DHA\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False";
            con = new SqlConnection(conStr);

            if (ViewState["bloodtype"] == "" && ViewState["date"] == "")
            {
                showDetails();
            }

            if (!string.IsNullOrEmpty(ViewState["bloodtype"]?.ToString()))
            {
                string qry = "SELECT bloodgroup, collectdate FROM [donor] WHERE bloodgroup=@bloodtype";


                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@bloodtype", ViewState["bloodtype"].ToString());

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        con.Open();
                        sda.Fill(dt);

                        

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                
                                TableRow tr = new TableRow();

                                // Blood Group Cell
                                TableCell bloodGroupCell = new TableCell
                                {
                                    Text = row["bloodgroup"].ToString()
                                };
                                tr.Cells.Add(bloodGroupCell);

                                // Collection Date Cell
                                TableCell collectDateCell = new TableCell
                                {
                                    Text = Convert.ToDateTime(row["collectdate"]).ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(collectDateCell);

                                // Expiry Date Cell
                                DateTime collectDate = Convert.ToDateTime(row["collectdate"]);
                                DateTime expDate = collectDate.AddDays(365); // Assuming expiry is one year from collection
                                TableCell expDateCell = new TableCell
                                {
                                    Text = expDate.ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(expDateCell);

                                // Add TableRow to Table
                                
                                dataTableBody.Rows.Add(tr);
                            }

                            Label9.Text = "";
                            Label9.Visible = false;

                        }
                        else
                        {
                            Label9.Visible = true;
                            Label9.Text = "Data is not found!";
                            Label9.ForeColor = System.Drawing.Color.Red;


                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    finally
                    {
                        // Ensure that the connection is always closed
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }

                }

            }

            if (!string.IsNullOrEmpty(ViewState["date"]?.ToString()))
            {
                string qry = "SELECT bloodgroup, collectdate FROM [donor] WHERE collectdate=@date";

                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@date", ViewState["date"].ToString());

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        con.Open();
                        sda.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                

                                TableRow tr = new TableRow();

                                // Blood Group Cell
                                TableCell bloodGroupCell = new TableCell
                                {
                                    Text = row["bloodgroup"].ToString()
                                };
                                tr.Cells.Add(bloodGroupCell);

                                // Collection Date Cell
                                TableCell collectDateCell = new TableCell
                                {
                                    Text = Convert.ToDateTime(row["collectdate"]).ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(collectDateCell);

                                // Expiry Date Cell
                                DateTime collectDate = Convert.ToDateTime(row["collectdate"]);
                                DateTime expDate = collectDate.AddDays(365); // Assuming expiry is one year from collection
                                TableCell expDateCell = new TableCell
                                {
                                    Text = expDate.ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(expDateCell);

                                // Add TableRow to Table
                                
                                dataTableBody.Rows.Add(tr);
                            }

                            Label9.Text = "";
                            Label9.Visible = false;

                        }
                        else
                        {
                            Label9.Visible = true;
                            Label9.Text = "Data is not found!";
                            Label9.ForeColor = System.Drawing.Color.Red;

                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    finally
                    {
                        // Ensure that the connection is always closed
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }

                }

            }

            if (!string.IsNullOrEmpty(ViewState["bloodtype"]?.ToString()) && !string.IsNullOrEmpty(ViewState["date"]?.ToString()))
            {
                string qry = "SELECT bloodgroup, collectdate FROM [donor] WHERE bloodgroup = @bloodtype AND collectdate = @date";

                
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                    // Explicitly set parameter types
                    cmd.Parameters.AddWithValue("@bloodtype", ViewState["bloodtype"].ToString());
                    cmd.Parameters.AddWithValue("@date", ViewState["date"].ToString());

                    

                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            con.Open();
                            sda.Fill(dt);

                            // Clear previous rows in the table (if needed)
                            dataTableBody.Rows.Clear();

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                TableHeaderRow th = new TableHeaderRow();
                                // Blood Group Heading
                                TableHeaderCell bloodGroupTh = new TableHeaderCell
                                {
                                    Text = "Blood Group"

                                };
                                th.Cells.Add(bloodGroupTh);

                                // Collect Date Heading
                                TableHeaderCell CdateTh = new TableHeaderCell
                                {
                                    Text = "Collection Date"
                                };
                                th.Cells.Add(CdateTh);

                                // Expiry Date Heading
                                TableHeaderCell EdateTh = new TableHeaderCell
                                {
                                    Text = "Expiry Date"
                                };
                                th.Cells.Add(EdateTh);


                                TableRow tr = new TableRow();

                                // Blood Group Cell
                                TableCell bloodGroupCell = new TableCell
                                {
                                    Text = row["bloodgroup"].ToString()
                                };
                                tr.Cells.Add(bloodGroupCell);

                                // Collection Date Cell
                                TableCell collectDateCell = new TableCell
                                {
                                    Text = Convert.ToDateTime(row["collectdate"]).ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(collectDateCell);

                                // Expiry Date Cell
                                DateTime collectDate = Convert.ToDateTime(row["collectdate"]);
                                DateTime expDate = collectDate.AddDays(365); // Assuming expiry is one year from collection
                                TableCell expDateCell = new TableCell
                                {
                                    Text = expDate.ToString("MM-dd-yyyy")
                                };
                                tr.Cells.Add(expDateCell);

                                // Add TableRow to Table
                                dataTableBody.Rows.Add(th);
                                dataTableBody.Rows.Add(tr);
                            }

                            Label9.Text = "";
                            Label9.Visible = false;

                        }
                        else
                        {
                            Label9.Visible = true;
                            Label9.Text = "Data is not found!";
                            Label9.ForeColor = System.Drawing.Color.Red;

                        }
                    }
                        catch (Exception ex)
                        {
                            // Log the exception details instead of just writing them to the response
                            System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                            Response.Write("An error occurred while fetching data. Please try again later.");
                    }
                   
                }
                
            }
            //else
            //{
            //    Label9.Visible = true;
            //    Label9.Text = "Please provide valid blood type and date!";
            //    Label9.ForeColor = System.Drawing.Color.Red;
            //}




            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
        }
    }
}