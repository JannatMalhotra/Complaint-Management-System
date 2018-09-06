using System;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RegisterComplaint.aspx");
        }

        protected void LinkButton4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Complaint where UserId=@UserId", myConnection);
            cmd.Parameters.AddWithValue("@UserId", TextBox3.Text);
            reader = cmd.ExecuteReader();

            if (reader != null && reader.HasRows)
            {
                Label7.Text = ("Complaint Already Registered ");
                Label8.Text = ("Delete  already registered Complaint");

            }
            else
            {
                myConnection.Close();
                myConnection.Open();

                string query = "Insert into [dbo].[Complaint] (Userid,Type,Category,SubCategory,Details) Values (@Userid,@Type,@Category,@SubCategory,@Details)";

                SqlCommand insertCommand = new SqlCommand(query, myConnection);
                insertCommand.Parameters.AddWithValue("@Type", RadioButtonList1.SelectedValue);

                insertCommand.Parameters.AddWithValue("@Userid", TextBox3.Text);
                insertCommand.Parameters.AddWithValue("@Category", DropDownList0.SelectedValue);
                insertCommand.Parameters.AddWithValue("@SubCategory", DropDownList1.SelectedValue);
                insertCommand.Parameters.AddWithValue("@Details", TextBox1.Text);

                insertCommand.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("SELECT * INTO Complaint FROM NewUser WHERE id = ", myConnection);

                myConnection.Close();


                Response.Redirect("UserProfile.aspx");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}