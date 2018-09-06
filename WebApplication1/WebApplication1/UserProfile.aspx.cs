using System;
using System.Configuration;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {




        string strConnString = ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString;
        string str;
        SqlCommand com;
        //SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NewUSER"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label3.Text = "<b><font color=Brown>" + "Welcome " + "</font>" + "<b><font color=red>" + Session["UserName"] + "</font>";
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            str = "select * from NewUser where UserName='" + Session["Id"] + "'";
            com = new SqlCommand(str, con);
            //SqlDataAdapter da = new SqlDataAdapter(com);

            //DataSet ds = new DataSet();

            //da.Fill(ds);

            //lbl_UserName.Text = ds.Tables[0].Rows[0]["UserName"].ToString();

           


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
            //public void MsgBox(String ex, Page pg, Object obj)
            //{
            //    string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            //    Type cstype = obj.GetType();
            //    ClientScriptManager cs = pg.ClientScript;
            //    cs.RegisterClientScriptBlock(cstype, s, s.ToString());
            //}

       
        
        protected void Button2_Click(object sender, EventArgs e)
        {
        //    MsgBox("! Logout successful !", this.Page, this);
        //    Response.Write("<script>alert('logout successful');</script>");
            Response.Redirect("Default.aspx");
        }

        protected void Login1_Authenticate(object sender, System.Web.UI.WebControls.AuthenticateEventArgs e)
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
    }
}