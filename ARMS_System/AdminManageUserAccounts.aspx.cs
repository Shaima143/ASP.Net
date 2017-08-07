using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARMS_Database.mdf;Integrated Security=True");

    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        Button11.Visible = false;
        Button12.Visible = false;
        Button15.Visible = false;
        Button16.Visible = false;

        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label8.Text = Request.QueryString["userid"];
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminCreateUser.aspx?userid=" + Label8.Text.ToString());
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageUserAccounts.aspx?userid=" + Label8.Text.ToString());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewRecord.aspx?userid=" + Label8.Text.ToString());
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageRecordStatus.aspx?userid=" + Label8.Text.ToString());
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUpdateRecord.aspx?userid=" + Label8.Text.ToString());
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchIn_House.aspx?userid=" + Label8.Text.ToString());
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_Purchased.aspx?userid=" + Label8.Text.ToString());
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label8.Text.ToString());
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Button11.Visible = true;
        Button12.Visible = true;
        Button15.Visible = true;
        Button16.Visible = true;

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from UserDetails where UserID='" + TextBox1.Text + "' AND Status='Inactive' ";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            con.Close();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE UserDetails set Status='Active' WHERE UserID=" + TextBox1.Text + " AND Status='Inactive'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert(\"The user account has been Activated successfully!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            GridView1.DataBind();
        }
        else
        {
            dr.Close();
            cmd.CommandText = "SELECT * FROM UserDetails where UserID='" + TextBox1.Text + "' AND Status='Active'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                string script = "alert(\"The user account is already Active!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();
            }
            drr.Close();
        }  
        con.Close(); 
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        Button11.Visible = true;
        Button12.Visible = true;
        Button15.Visible = true;
        Button16.Visible = true;

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from UserDetails where UserID='" + TextBox1.Text + "' AND Status='Active' ";
        SqlDataReader dr2 = cmd.ExecuteReader();
        if (dr2.Read())
        {
            con.Close();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE UserDetails set Status='Inactive' WHERE UserID=" + TextBox1.Text + " AND Status='Active'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert(\"The user account has been De-activated successfully!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            GridView1.DataBind();
        }
        else
        {
            dr2.Close();
            cmd.CommandText = "SELECT * FROM UserDetails where UserID='" + TextBox1.Text + "' AND Status='Inactive'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                string script = "alert(\"The user account is already Inactive!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();
            }
            drr.Close();
        }
        con.Close(); 

    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        Button11.Visible = true;
        Button12.Visible = true;
        Button15.Visible = true;
        Button16.Visible = true;


            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from UserDetails where UserID='" + TextBox1.Text + "'";
            da.SelectCommand = cmd;

            int countdoc = (int)cmd.ExecuteScalar();
            if (countdoc > 0)
            {
                da.SelectCommand = cmd;
                da.Fill(ds);
               // GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
            else
            {
                string script = "alert(\"Sorry! No such User ID is found!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                Button11.Visible = false;
                Button12.Visible = false;
                Button15.Visible = false;
                Button16.Visible = false;
            }
    }



    protected void Button15_Click(object sender, EventArgs e)
    {
        Button11.Visible = true;
        Button12.Visible = true;
        Button15.Visible = true;
        Button16.Visible = true;



        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from UserDetails where UserID='" + TextBox1.Text + "' AND RoleID='2' ";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            con.Close();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE UserDetails set RoleID='1' WHERE UserID=" + TextBox1.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert(\"The user account has been assigned administrative privileges successfully!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            GridView1.DataBind();
        }
        else
        {
            dr.Close();
            cmd.CommandText = "SELECT * FROM UserDetails where UserID='" + TextBox1.Text + "' AND RoleID='1'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                string script = "alert(\"The user account has already been assigned administrative privileges!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();
            }
            drr.Close();
        }
        con.Close(); 

    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        Button11.Visible = true;
        Button12.Visible = true;
        Button15.Visible = true;
        Button16.Visible = true;



        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from UserDetails where UserID='" + TextBox1.Text + "' AND RoleID='1' ";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            con.Close();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE UserDetails set RoleID='2' WHERE UserID=" + TextBox1.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert(\"Successful alteration of user account to Non-Administrative Role!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            GridView1.DataBind();
        }
        else
        {
            dr.Close();
            cmd.CommandText = "SELECT * FROM UserDetails where UserID='" + TextBox1.Text + "' AND RoleID='2'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                string script = "alert(\"The user account is already having a Non-Administrative Role!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();
            }
            drr.Close();
        }
        con.Close(); 
    }
}