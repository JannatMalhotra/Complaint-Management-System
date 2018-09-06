using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class NewAdmin : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text.Trim() == TextBox7.Text.Trim())
            {
                SqlDataReader reader = null;
                myConnection.Open();

                SqlCommand cmd = new SqlCommand("select * from NewAdmin where AdminId=@Id", myConnection);
                cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
                reader = cmd.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    Label8.Text = ("Id exists ");

                }
                else
                {
                    myConnection.Close();
                    if (TextBox1.Text == string.Empty  || TextBox5.Text == string.Empty || TextBox6.Text == string.Empty || TextBox7.Text == string.Empty)
                    {

                        Label8.Text = "All Values are required";

                    }
                    else
                    {
                        myConnection.Open();
                        string query = "Insert into [dbo].[NewAdmin] (AdminName,AdminId,Department,Password) Values (@AdminName,@AdminId,@Department,@Password)";

                        SqlCommand insertCommand = new SqlCommand(query, myConnection);
                        insertCommand.Parameters.AddWithValue("@AdminName", TextBox1.Text);
                        insertCommand.Parameters.AddWithValue("@AdminId", TextBox5.Text);
                        insertCommand.Parameters.AddWithValue("@Department", DdlMonths.SelectedValue);
                        insertCommand.Parameters.AddWithValue("@Password", TextBox7.Text);
                        insertCommand.ExecuteNonQuery();

                        myConnection.Close();
                        Response.Redirect("AdminProfile.aspx");
                    }
                }
                myConnection.Close();
            }
            else
            {
                Label8.Text = ("Password Does not Match");
            }
   
        }

        protected void DdlMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}