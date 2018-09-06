using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                if (TextBox6.Text.Trim() == TextBox7.Text.Trim())
                {
                    SqlDataReader reader = null;
                    myConnection.Open();

                    SqlCommand cmd = new SqlCommand("select * from NewUser where Id=@Id", myConnection);
                    cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
                    reader = cmd.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    Label8.Text = ("Id exists ");

                }
                else
                {
                    myConnection.Close();
                    if (TextBox1.Text == string.Empty  ||  TextBox3.Text == string.Empty || TextBox4.Text == string.Empty || TextBox5.Text == string.Empty || TextBox6.Text == string.Empty )
                    {
                       
                        Label8.Text = "All Values are required";

                    }
                    else
                    {
                        myConnection.Open();
                        string query = "Insert into [dbo].[NewUser] (UserName,Department,Email,Phone,Id,Password) Values (@UserName,@Department,@Email,@Phone,@Id,@Password)";

                        SqlCommand insertCommand = new SqlCommand(query, myConnection);
                        insertCommand.Parameters.AddWithValue("@UserName", TextBox1.Text);
                        insertCommand.Parameters.AddWithValue("@Department", DdlMonths.SelectedValue);
                        insertCommand.Parameters.AddWithValue("@Email", TextBox3.Text);
                        insertCommand.Parameters.AddWithValue("@Phone", TextBox4.Text);
                        insertCommand.Parameters.AddWithValue("@Id", TextBox5.Text);
                        insertCommand.Parameters.AddWithValue("@Password", TextBox7.Text);
                        insertCommand.ExecuteNonQuery();

                        Response.Redirect("UserProfile.aspx");
                    }
                }
                    myConnection.Close();
                }
                else
                {
                    Label8.Text = ("Password Does not Match");
                }
          
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DdlMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}