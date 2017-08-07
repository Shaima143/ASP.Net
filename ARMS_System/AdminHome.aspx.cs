using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARMS_Database.mdf;Integrated Security=True");

    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label2.Text = Request.QueryString["userid"];

            var user_id = Request.QueryString["userid"];
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Name FROM UserDetails WHERE UserID='" + user_id+"'";
            SqlDataReader d = cmd.ExecuteReader();
            if (d.Read())
            {
                var name = d[0].ToString();
                Label2.Text = name;
                d.Close();
            }
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminCreateUser.aspx?userid=" + Label2.Text.ToString());
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageUserAccounts.aspx?userid=" + Label2.Text.ToString());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewRecord.aspx?userid="+ Label2.Text.ToString());
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageRecordStatus.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUpdateRecord.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchIn_House.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_Purchased.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label2.Text.ToString());
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx?userid=" + Label2.Text.ToString());
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        //Session.Abandon();
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }
}