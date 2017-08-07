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
        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label8.Text = Request.QueryString["userid"];
        }

        Label9.Visible = false;
        Label10.Visible = false;
        Label11.Visible = false;
        Label12.Visible = false;
        Label13.Visible = false;
        Label14.Visible = false;
        Label15.Visible = false;

        Button11.Visible = false;
        Button12.Visible = false;

    
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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
     
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;
        Label12.Visible = true;
        Label13.Visible = true;
        Label14.Visible = true;
        Label15.Visible = true;

        string name = GridView1.SelectedRow.Cells[1].Text;
        string type = GridView1.SelectedRow.Cells[2].Text;
        string status = GridView1.SelectedRow.Cells[7].Text;

        Label11.Text = name;
        Label13.Text = type;
        Label15.Text = status;

        Button11.Visible = true;
        Button12.Visible = true;
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        if (Label11.Text =="")
        {
            string script = "alert(\"Please select a row to activate!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }

        else 
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from Records where SystemName='" + Label11.Text + "' AND SystemStatus='Inactive' ";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Records set SystemStatus='Active' WHERE SystemName='" + Label11.Text + "' AND SystemStatus='Inactive'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string script = "alert(\"The selected system has been set to an 'Active' state!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();

                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Label13.Visible = true;
                Label14.Visible = true;
                Label15.Visible = true;
                string name = GridView1.SelectedRow.Cells[1].Text;
                string type = GridView1.SelectedRow.Cells[2].Text;
                string status = GridView1.SelectedRow.Cells[7].Text;

                Label11.Text = name;
                Label13.Text = type;
                Label15.Text = status;

                Button11.Visible = true;
                Button12.Visible = true;
            }
            else
            {
                dr.Close();
                cmd.CommandText = "SELECT * FROM Records where SystemName='" + Label11.Text + "' AND SystemStatus='Active'";
                SqlDataReader drr = cmd.ExecuteReader();
                if (drr.Read())
                {
                    string script = "alert(\"The selected system is already in an 'Active' state!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);

                    GridView1.DataBind();

                    Label9.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label14.Visible = true;
                    Label15.Visible = true;
                    string name = GridView1.SelectedRow.Cells[1].Text;
                    string type = GridView1.SelectedRow.Cells[2].Text;
                    string status = GridView1.SelectedRow.Cells[7].Text;

                    Label11.Text = name;
                    Label13.Text = type;
                    Label15.Text = status;
                }
                else
                {
                    drr.Close();
                    string script = "alert(\"Sorry! Nothing to Activate!!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
            con.Close(); 
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        if (Label11.Text == "")
        {
            string script = "alert(\"Please select a row to De-activate!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }

        else
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from Records where SystemName='" + Label11.Text + "' AND SystemStatus='Active' ";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Records set SystemStatus='Inactive' WHERE SystemName='" + Label11.Text + "' AND SystemStatus='Active'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string script = "alert(\"The selected system has been set to an 'Inactive' state!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);

                GridView1.DataBind();

                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Label13.Visible = true;
                Label14.Visible = true;
                Label15.Visible = true;
                string name = GridView1.SelectedRow.Cells[1].Text;
                string type = GridView1.SelectedRow.Cells[2].Text;
                string status = GridView1.SelectedRow.Cells[7].Text;

                Label11.Text = name;
                Label13.Text = type;
                Label15.Text = status;

                Button11.Visible = true;
                Button12.Visible = true;
            }
            else
            {
                dr.Close();
                cmd.CommandText = "SELECT * FROM Records where SystemName='" + Label11.Text + "' AND SystemStatus='Inactive'";
                SqlDataReader drr = cmd.ExecuteReader();
                if (drr.Read())
                {
                    string script = "alert(\"The selected system is already in an 'Inactive' state!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);

                    GridView1.DataBind();

                    Label9.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label14.Visible = true;
                    Label15.Visible = true;
                    string name = GridView1.SelectedRow.Cells[1].Text;
                    string type = GridView1.SelectedRow.Cells[2].Text;
                    string status = GridView1.SelectedRow.Cells[7].Text;

                    Label11.Text = name;
                    Label13.Text = type;
                    Label15.Text = status;
                }
                drr.Close();
            }
            con.Close();
        }
    }
}