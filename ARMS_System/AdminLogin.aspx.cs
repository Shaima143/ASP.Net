using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARMS_Database.mdf;Integrated Security=True");

    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        Session["userid"] = TextBox1.Text;

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT Name FROM UserDetails WHERE UserID=" + TextBox1.Text;
        SqlDataReader d = cmd.ExecuteReader();
        if (d.Read())
        {
            string name = d[0].ToString();
            Session["name"] = name.ToString();
            d.Close();
        }     
        con.Close();


        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "Select * from UserDetails WHERE UserID=" + TextBox1.Text + " AND Password='" + TextBox2.Text + "' AND Status='Active' AND RoleID='1'";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("AdminHome.aspx?userid="+TextBox1.Text);

        }

        else
        {
            dr.Close();
            cmd.CommandText = "Select * from UserDetails WHERE UserID=" + TextBox1.Text + " AND Password='" + TextBox2.Text + "' AND Status='Inactive'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
               string script = "alert(\"Login Failed! Your account has been deactivated by an admin\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);

            }
            drr.Close();
                cmd.CommandText ="Select * from UserDetails WHERE UserID=" + TextBox1.Text +" AND Password='" + TextBox2.Text +"' AND Status='Active' AND RoleID='2'";
                SqlDataReader drrr =cmd.ExecuteReader();
                if (drrr.Read())
                {
                    string script = "alert(\"Login Failed! You do not have Administrative privileges!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }

                else
                    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and/or Password')</script>");
            TextBox1.Text = "";
            drrr.Close();
        }
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("startpage.aspx");
    }
}