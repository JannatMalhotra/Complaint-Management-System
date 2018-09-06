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
    public partial class AddCat : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
       
        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ManageComplaint.aspx");
        }     
protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCat.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSub.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            Button4.Visible = true;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            cmd = new SqlCommand();
            cmd = new SqlCommand("delete from Department where Department='" + DropDownList1.SelectedItem.ToString() + "'", myConnection);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            Label3.Text = "Value deleted";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            myConnection.Open();

            string query = "Insert into [dbo].[Department] (Department) Values (@Department)";

            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@Department", TextBox1.Text);
            
            
            insertCommand.ExecuteNonQuery();

            myConnection.Close();
            Label2.Text = "Value Added";
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminProfile.aspx");
        }
    }
    }
