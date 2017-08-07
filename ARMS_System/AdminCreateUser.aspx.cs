using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARMS_Database.mdf;Integrated Security=True");

    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label13.Text = "";

        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label15.Text = Request.QueryString["userid"];  
        }
    }
   
    protected void Button11_Click(object sender, EventArgs e)
    {
         con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from UserDetails where UserID='" + TextBox1.Text + "'";
            da.SelectCommand = cmd;

            int countdoc = (int)cmd.ExecuteScalar();
            if (countdoc > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Failed to add new user!"
                +" The selected user already exists!')</script>");

                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                CheckBox1.Checked = false;
            }
            else
            {
                con.Close();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewUserSP";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text.Trim();
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = TextBox2.Text.Trim();
                cmd.Parameters.Add("@ext", SqlDbType.Int).Value = TextBox3.Text.Trim();
                cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = TextBox8.Text.Trim();
                cmd.Parameters.Add("@section", SqlDbType.VarChar, 50).Value = TextBox7.Text.Trim();
                cmd.Parameters.Add("@dept", SqlDbType.VarChar, 50).Value = TextBox4.Text.Trim();
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = TextBox5.Text.Trim();
                cmd.Parameters.Add("@desi", SqlDbType.VarChar, 50).Value = TextBox6.Text.Trim();
                cmd.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = "Active";
                cmd.Parameters.Add("@roleid", SqlDbType.Int).Value = CheckBox1.Checked ? "1" : "2";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                CheckBox1.Checked = false;

                string script = "alert(\"New user created successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        CheckBox1.Checked = false;
    }
   
    protected void Button14_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT Name, Ext, Password, Section, Dept, Email, Designation FROM test WHERE userid = '" + TextBox1.Text + "'";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox2.Text = dr[0].ToString();
            TextBox3.Text = dr[1].ToString();
            TextBox8.Text = dr[2].ToString();
            TextBox7.Text = dr[3].ToString();
            TextBox4.Text = dr[4].ToString();
            TextBox5.Text = dr[5].ToString();
            TextBox6.Text = dr[6].ToString();
        }
        else
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox8.Text = "";
            TextBox7.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            Label13.Text = "Sorry, No such User ID Exists!";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminCreateUser.aspx?userid=" + Label15.Text.ToString());
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageUserAccounts.aspx?userid=" + Label15.Text.ToString());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewRecord.aspx?userid=" + Label15.Text.ToString());
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageRecordStatus.aspx?userid=" + Label15.Text.ToString());
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUpdateRecord.aspx?userid=" + Label15.Text.ToString());
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchIn_House.aspx?userid=" + Label15.Text.ToString());
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_Purchased.aspx?userid=" + Label15.Text.ToString());
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label15.Text.ToString());
    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }
}