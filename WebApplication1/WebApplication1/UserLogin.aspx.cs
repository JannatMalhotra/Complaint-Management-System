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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string id = TextBox1.Text.Trim();
            myConnection.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("select * from NewUser where Id=@Id and Password=@Password", myConnection);

            cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
            cmd.Parameters.AddWithValue("Password", TextBox2.Text);
            rdr = cmd.ExecuteReader();

            if (rdr != null && rdr.HasRows)
            {
                Session["Id"] = id;
                Response.Redirect("UserProfile.aspx");
            }
            else
            {
                Label3.Text = "Incorrect UerId and Password";
                Label3.ForeColor = System.Drawing.Color.Red;
            }

        }
            protected void LinkButton1_Click(object sender, EventArgs e)
        {


            Response.Redirect("NewUser.aspx");

        }
               
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgetPassword.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}