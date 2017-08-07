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
        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            LabelName.Text = Request.QueryString["userid"];
        }

        TextBox1.Text = Session["systemName"].ToString();

        if (!IsPostBack)
        {
            DropDownList1.Items.Insert(0, new ListItem("-- Select --", String.Empty));
            DropDownList1.SelectedIndex = 0;

            DropDownList2.Items.Insert(0, new ListItem("-- Select --", String.Empty));
            DropDownList2.SelectedIndex = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserAddNewRecord.aspx?userid=" + LabelName.Text.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserUpdateRecord.aspx?userid=" + LabelName.Text.ToString());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Search_InHouse.aspx?userid=" + LabelName.Text.ToString());
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Search_Purchased.aspx?userid=" + LabelName.Text.ToString());
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Reports.aspx?userid=" + LabelName.Text.ToString());
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {
            Session["rb"] = RadioButton1.Checked;
            Response.Redirect("UserAddNewRecord.aspx?userid=" + LabelName.Text.ToString());
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        

    }



    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        RadioButton2.Checked = false;
        SystemOwner_TextBox.Text = "";
        ProjectManager_Textbox.Text = "";
        ProjectManagerEXT_Textbox0.Text = "";
        ProjectManagerEmail_Textbox1.Text = "";
        FocalPointUser_TextBox.Text = "";
        FocalPointUserExt_TextBox.Text = "";
        FocalPointUserEmail_Textbox.Text = "";
        SystemDesc_TextBox.Text = "";
        SpecReqs_TextBox.Text = "";
        Cost_TextBox2.Text = "";
        VendorName_TexBox.Text = "";
        VendorContact_TexBox0.Text = "";
        VendorEmail_Textbox.Text = "";
        P_purchaseDateTextbox.Text = "";
        DropDownList1.ClearSelection();
        From_Textbox.Text = "";
        To_Textbox.Text = "";
        NoOfLicense_TextBox.Text = "";
        Indent_No_TextBox.Text = "";
        DropDownList2.ClearSelection();

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (RadioButton2.Checked)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from Records where SystemName='" + TextBox1.Text + "' AND SystemStatus='Active'";
            da.SelectCommand = cmd;

            int countdoc = (int)cmd.ExecuteScalar();
            if (countdoc > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('The entered system record already exists with an active state, please enter a new system.')</script>");

            }
            else
            {

                cmd.Connection = con;
                cmd.CommandText = "Select UserID from UserDetails where Name='" + LabelName.Text + "'";
                SqlDataReader d = cmd.ExecuteReader();
                d.Read();
                var sid = d[0].ToString();
                d.Close();

                con.Close();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PurchasedRecordSP";

                cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = TextBox1.Text;
                cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = RadioButton2.Text;
                cmd.Parameters.Add("@owner", SqlDbType.VarChar, 100).Value = SystemOwner_TextBox.Text.Trim();
                cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = ProjectManager_Textbox.Text.Trim();
                cmd.Parameters.Add("@managerEXT", SqlDbType.Int).Value = ProjectManagerEXT_Textbox0.Text.Trim();
                cmd.Parameters.Add("@managerEmail", SqlDbType.VarChar, 100).Value = ProjectManagerEmail_Textbox1.Text.Trim();
                cmd.Parameters.Add("@focalPointUser", SqlDbType.VarChar, 100).Value = FocalPointUser_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEXT", SqlDbType.Int).Value = FocalPointUserExt_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEmail", SqlDbType.VarChar, 100).Value = FocalPointUserEmail_Textbox.Text.Trim();
                cmd.Parameters.Add("@systemdesc", SqlDbType.VarChar, 1000).Value = SystemDesc_TextBox.Text.Trim();
                cmd.Parameters.Add("@specialreqs", SqlDbType.VarChar, 200).Value = SpecReqs_TextBox.Text.Trim();
                cmd.Parameters.Add("@cost", SqlDbType.VarChar, 50).Value = Cost_TextBox2.Text.Trim();
                cmd.Parameters.Add("@vendorname", SqlDbType.VarChar, 100).Value = VendorName_TexBox.Text.Trim();
                cmd.Parameters.Add("@vendorcontact", SqlDbType.Int).Value = VendorContact_TexBox0.Text.Trim();
                cmd.Parameters.Add("@VendorEmail", SqlDbType.VarChar, 100).Value = VendorEmail_Textbox.Text.Trim();
              

       
                string purchase_date = P_purchaseDateTextbox.Text;
                DateTime purchased_date_time = new DateTime();
                purchased_date_time = DateTime.ParseExact(purchase_date, "dd/MM/yyyy", null);
                cmd.Parameters.Add("@purchasedate", SqlDbType.Date).Value = purchased_date_time;

                cmd.Parameters.Add("@licensetype", SqlDbType.VarChar, 50).Value = DropDownList1.SelectedItem.ToString();

                string licenseFrom_string = From_Textbox.Text;
                DateTime LicenseFrom = new DateTime();
                LicenseFrom = DateTime.ParseExact(licenseFrom_string, "dd/MM/yyyy", null);
                cmd.Parameters.Add("@l_date_from", SqlDbType.Date).Value = LicenseFrom;

                string licenseTo_string = To_Textbox.Text;
                DateTime LicenseTo = new DateTime();
                LicenseTo = DateTime.ParseExact(licenseTo_string, "dd/MM/yyyy", null);
                cmd.Parameters.Add("@l_date_to", SqlDbType.Date).Value = LicenseTo;


                cmd.Parameters.Add("@NoOfLicense", SqlDbType.Int).Value = NoOfLicense_TextBox.Text.Trim();
                cmd.Parameters.Add("@indentNo", SqlDbType.Int).Value = Indent_No_TextBox.Text.Trim();
                cmd.Parameters.Add("@indentType", SqlDbType.VarChar, 50).Value = DropDownList2.SelectedItem.ToString();

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
                cmd.Parameters.Add("@systemstatus", SqlDbType.VarChar, 50).Value = "Active";
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
}