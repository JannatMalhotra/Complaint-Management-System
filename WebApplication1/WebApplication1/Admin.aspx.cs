using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("select * from NewAdmin where AdminId=@AdminId and Password=@Password", myConnection);

            cmd.Parameters.AddWithValue("@AdminId", TextBox1.Text);
            cmd.Parameters.AddWithValue("Password", TextBox2.Text);
            rdr = cmd.ExecuteReader();

            if (rdr != null && rdr.HasRows)
            {
                Response.Redirect("AdminProfile.aspx");
                Response.Write("<script>alert('Login successful');</script>");
            }
            else
            {
                Label3.Text = "Incorrect UerId and Password";
                Label3.ForeColor = System.Drawing.Color.Red;
            }           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminForget.aspx");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("NewAdmin.aspx");
        }
    }
}