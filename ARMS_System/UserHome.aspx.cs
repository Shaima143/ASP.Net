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
            cmd.CommandText = "SELECT Name FROM UserDetails WHERE UserID='" + user_id + "'";
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
 
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserAddNewRecord.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserUpdateRecord.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Search_InHouse.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Search_Purchased.aspx?userid=" + Label2.Text.ToString());
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Reports.aspx?userid=" + Label2.Text.ToString());
    }
}