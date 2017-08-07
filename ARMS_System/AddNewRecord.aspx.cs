using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARMS_Database.mdf;Integrated Security=True");

    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["rb"] != null)
        {
            //If exists then set the value
            RadioButton1.Checked = Convert.ToBoolean(Session["rb"]);           
        }

        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label8.Text = Request.QueryString["userid"];

            Session["systemName"] = TextBox1.Text.ToString();
        }

        Session["userid"] = Label8.Text;
     
        SystemOwner.Visible = false;
        SystemOwner_TextBox.Visible = false;
        Label9.Visible = false;

        ProjectManager.Visible = false;
        ProjectManager_Textbox.Visible = false;

        ProjectManagerEXT.Visible = false;
        ProjectManagerEXT_Textbox0.Visible = false;

        ProjectManagerEmail.Visible = false;
        ProjectManagerEmail_Textbox1.Visible = false;

        FocalPointUser.Visible = false;
        FocalPointUser_TextBox.Visible = false;

        FocalPointUserExt.Visible = false;
        FocalPointUserExt_TextBox.Visible = false;

        FocalPointUserEmail.Visible = false;
        FocalPointUserEmail_Textbox.Visible = false;

        ImpLang.Visible = false;
        ImpLang_TextBox.Visible = false;

        SystemDescription.Visible = false;
        SystemDesc_TextBox.Visible = false;

        VersionNo.Visible = false;
        VersionNo_TextBox.Visible = false;

        SpecialReqs.Visible = false;
        SpecialReqs_Textbox.Visible = false;

        Attachments.Visible = false;
        FileUpload1.Visible = false;

        Button11.Visible = false;
        Button12.Visible = false;
       


       if (RadioButton1.Checked)
        {
            SystemOwner.Visible = true;
            SystemOwner_TextBox.Visible = true;
            Label9.Visible = true;

            ProjectManager.Visible = true;
            ProjectManager_Textbox.Visible = true;

            ProjectManagerEXT.Visible = true;
            ProjectManagerEXT_Textbox0.Visible = true;

            ProjectManagerEmail.Visible = true;
            ProjectManagerEmail_Textbox1.Visible = true;

            FocalPointUser.Visible = true;
            FocalPointUser_TextBox.Visible = true;

            FocalPointUserExt.Visible = true;
            FocalPointUserExt_TextBox.Visible = true;

            FocalPointUserEmail.Visible = true;
            FocalPointUserEmail_Textbox.Visible = true;

            ImpLang.Visible = true;
            ImpLang_TextBox.Visible = true;

            SystemDescription.Visible = true;
            SystemDesc_TextBox.Visible = true;

            VersionNo.Visible = true;
            VersionNo_TextBox.Visible = true;

            SpecialReqs.Visible = true;
            SpecialReqs_Textbox.Visible = true;

            Attachments.Visible = true;
            FileUpload1.Visible = true;

            Button11.Visible = true;
            Button12.Visible = true;
           
        }
    }
    
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {
            SystemOwner.Visible = true;
            SystemOwner_TextBox.Visible = true;
            Label9.Visible = true;

            ProjectManager.Visible = true;
            ProjectManager_Textbox.Visible = true;

            ProjectManagerEXT.Visible = true;
            ProjectManagerEXT_Textbox0.Visible = true;

            ProjectManagerEmail.Visible = true;
            ProjectManagerEmail_Textbox1.Visible = true;

            FocalPointUser.Visible = true;
            FocalPointUser_TextBox.Visible = true;

            FocalPointUserExt.Visible = true;
            FocalPointUserExt_TextBox.Visible = true;

            FocalPointUserEmail.Visible = true;
            FocalPointUserEmail_Textbox.Visible = true;

            ImpLang.Visible = true;
            ImpLang_TextBox.Visible = true;

            SystemDescription.Visible = true;
            SystemDesc_TextBox.Visible = true;

            VersionNo.Visible = true;
            VersionNo_TextBox.Visible = true;

            SpecialReqs.Visible = true;
            SpecialReqs_Textbox.Visible = true;

            Attachments.Visible = true;
            FileUpload1.Visible = true;

            Button11.Visible = true;
            Button12.Visible = true;
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
            Session["systemName"] = TextBox1.Text.ToString();

            Session["userid"] = Label8.Text;

            Response.Redirect("AdminAddRecordPurchased.aspx?userid=" + Label8.Text.ToString());
        
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from Records where SystemName='" + TextBox1.Text + "' AND SystemStatus='Active'";
            da.SelectCommand = cmd;

            int countdoc = (int)cmd.ExecuteScalar();
            if (countdoc > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('The entered system record already exists with an active state, please enter a new system.')</script>");
                //Label9.Text = "**" + TextBox2.Text + " already exists";
            }
            else
            {
                //con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select UserID from UserDetails where Name='" + Label8.Text + "'";
                SqlDataReader d = cmd.ExecuteReader();
                d.Read();
                var sid = d[0].ToString();
                d.Close();
                con.Close();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "In-HouseRecordSP"; 

                cmd.Parameters.Add("@name", SqlDbType.VarChar, 510).Value = TextBox1.Text;
                cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = RadioButton1.Text;
                cmd.Parameters.Add("@owner", SqlDbType.VarChar, 100).Value = SystemOwner_TextBox.Text.Trim();
                cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = ProjectManager_Textbox.Text.Trim();
                cmd.Parameters.Add("@managerEXT", SqlDbType.Int).Value = ProjectManagerEXT_Textbox0.Text.Trim();
                cmd.Parameters.Add("@managerEmail", SqlDbType.VarChar,100).Value = ProjectManagerEmail_Textbox1.Text.Trim();
                cmd.Parameters.Add("@focalPointUser", SqlDbType.VarChar, 100).Value = FocalPointUser_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEXT", SqlDbType.Int).Value = FocalPointUserExt_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEmail", SqlDbType.VarChar,100).Value = FocalPointUserEmail_Textbox.Text.Trim();
                cmd.Parameters.Add("@Implang", SqlDbType.VarChar, 200).Value = ImpLang_TextBox.Text.Trim();
                cmd.Parameters.Add("@systemdesc", SqlDbType.VarChar, 1000).Value = SystemDesc_TextBox.Text.Trim();
                cmd.Parameters.Add("@versionNo", SqlDbType.VarChar,50).Value = VersionNo_TextBox.Text.Trim();
                cmd.Parameters.Add("@specialreqs", SqlDbType.VarChar, 200).Value = SpecialReqs_Textbox.Text.Trim();      
              
                if (FileUpload1.HasFile)
                {
                    string strdata = @"~\uploads\" + FileUpload1.FileName;
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(strdata));

                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    string contentType = FileUpload1.PostedFile.ContentType;
                    using (Stream fs = FileUpload1.PostedFile.InputStream)
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            byte[] bytes = br.ReadBytes((Int32)fs.Length);
                            cmd.Parameters.AddWithValue("@attachments", FileUpload1.FileBytes);
                            cmd.Parameters.AddWithValue("@filename", filename);
                            cmd.Parameters.AddWithValue("@contentType", contentType);


                        }
                    }
       
                }

                cmd.Parameters.Add("@systemstatus", SqlDbType.VarChar,50).Value = "Active";
                cmd.Parameters.Add("@userid", SqlDbType.Int).Value = Convert.ToInt32(sid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string script = "alert(\"A new record has been created successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        RadioButton1.Checked = false;
        SystemOwner_TextBox.Text = "";
        ProjectManager_Textbox.Text = "";
        ProjectManagerEXT_Textbox0.Text = "";
        ProjectManagerEmail_Textbox1.Text = "";
        FocalPointUser_TextBox.Text = "";
        FocalPointUserExt_TextBox.Text = "";
        FocalPointUserEmail_Textbox.Text = "";
        ImpLang_TextBox.Text = "";
        SystemDesc_TextBox.Text = "";
        VersionNo_TextBox.Text = "";
        SpecialReqs_Textbox.Text = "";
        
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


    

   
}