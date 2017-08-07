using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing;

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
            Label6.Text = Request.QueryString["userid"];
        }

        Label8.Visible = false;
        Label9.Visible = false;
        Label10.Visible = false;
        Label11.Visible = false;
        Label12.Visible = false;
        Label13.Visible = false;
        Label14.Visible = false;
        Label17.Visible = false;
        Label18.Visible = false;
        Label19.Visible = false;
        Label20.Visible = false;
        Label21.Visible = false;
        Label22.Visible = false;
        Label23.Visible = false;
        Label24.Visible = false;
        Label25.Visible = false;
        Label26.Visible = false;
        Label27.Visible = false;
        Label28.Visible = false;
        Label29.Visible = false;
        Label30.Visible = false;
        Label31.Visible = false;
        Label32.Visible = false;
        Label33.Visible = false;
        Label34.Visible = false;
        Label35.Visible = false;
        Label36.Visible = false;
        Label37.Visible = false;
        Label38.Visible = false;
        Label39.Visible = false;
        Label40.Visible = false;
        Label41.Visible = false;
        Label42.Visible = false;
        Label43.Visible = false;
        Label44.Visible = false;
        Label45.Visible = false;
        Label46.Visible = false;
        Label47.Visible = false;
        Label48.Visible = false;
        Label49.Visible = false;
        Label50.Visible = false;
        Label51.Visible = false;
        Label52.Visible = false;

        ProjectManagerEmail.Visible = false;
        ProjectManagerEmail_InfoLabel.Visible = false;
        FocalPointUserEmail.Visible = false;
        FocalPointUserEmail_InfoLabel.Visible = false;

        VendorEmail.Visible = false;
        VendorEmail_InfoLabel.Visible = false;

        if (!IsPostBack)
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/uploads/"));
            List<ListItem> files = new List<ListItem>();
            foreach (string filePath in filePaths)
            {
                files.Add(new ListItem(Path.GetFileName(filePath), filePath));
            }
            // GridView1.DataSource = files;
            GridView1.DataBind();

            // BindGrid();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminCreateUser.aspx?userid=" + Label6.Text.ToString());
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageUserAccounts.aspx?userid=" + Label6.Text.ToString());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewRecord.aspx?userid=" + Label6.Text.ToString());
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageRecordStatus.aspx?userid=" + Label6.Text.ToString());
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUpdateRecord.aspx?userid=" + Label6.Text.ToString());
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchIn_House.aspx?userid=" + Label6.Text.ToString());
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_Purchased.aspx?userid=" + Label6.Text.ToString());
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label6.Text.ToString());
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("startpage.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;
        Label12.Visible = true;
        Label13.Visible = true;
        Label14.Visible = true;
        Label17.Visible = true;
        Label18.Visible = true;
        Label19.Visible = true;
        Label20.Visible = true;
        Label21.Visible = true;
        Label22.Visible = true;
        Label23.Visible = true;
        Label24.Visible = true;
        Label25.Visible = true;
        Label26.Visible = true;
        Label27.Visible = true;
        Label28.Visible = true;
        Label29.Visible = true;
        Label30.Visible = true;
        Label31.Visible = true;
        Label32.Visible = true;
        Label33.Visible = true;
        Label34.Visible = true;
        Label35.Visible = true;
        Label36.Visible = true;
        Label37.Visible = true;
        Label38.Visible = true;
        Label39.Visible = true;
        Label40.Visible = true;
        Label41.Visible = true;
        Label42.Visible = true;
        Label43.Visible = true;
        Label44.Visible = true;
        Label45.Visible = true;
        Label46.Visible = true;
        Label47.Visible = true;
        Label48.Visible = true;
        Label49.Visible = true;
        Label50.Visible = true;
        Label51.Visible = true;
        Label52.Visible = true;

        ProjectManagerEmail.Visible = true;
        ProjectManagerEmail_InfoLabel.Visible = true;
        FocalPointUserEmail.Visible = true;
        FocalPointUserEmail_InfoLabel.Visible = true;

        VendorEmail.Visible = true;
        VendorEmail_InfoLabel.Visible = true;

        string name = GridView1.SelectedRow.Cells[1].Text;
        string type = GridView1.SelectedRow.Cells[2].Text;
        string owner = GridView1.SelectedRow.Cells[3].Text;
   
        Label10.Text = name;
        Label12.Text = type;
        Label14.Text = owner;
     

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "Select ProjectManager, ProjectManagerExt, ProjectManagerEmail, FocalPointUser, FocalPointUserExt, FocalPointUserEmail, SystemCost, SystemDescription, SpecialReqs, VendorName, VendorContactNo, VendorEmail, " 
                           +"PurchaseDate, LicenseType, LicenseDateFrom, LicenseDateTo, NoOfLicense, IndentNo, IndentType, SystemStatus, UserID, Attachments FROM Records WHERE SystemName='" + Label10.Text + "'";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label18.Text = dr[0].ToString(); //ProjectManager
            Label20.Text = dr[1].ToString(); //projectManagerEXT
            ProjectManagerEmail_InfoLabel.Text = dr[2].ToString(); //ProjectManagerEmail
            Label22.Text = dr[3].ToString(); //focalPointuser
            Label24.Text = dr[4].ToString(); //focalPointuserEXT
            FocalPointUserEmail_InfoLabel.Text = dr[5].ToString(); //focalPointUserEmail
            Label26.Text = dr[6].ToString(); //cost
            Label28.Text = dr[7].ToString(); //description
            Label30.Text = dr[8].ToString(); //specialreqs
            Label32.Text = dr[9].ToString(); //vendorname
            Label34.Text = dr[10].ToString(); //vendorcontactno
            VendorEmail_InfoLabel.Text = dr[11].ToString(); //VendorEmail

           
            string d = dr[12].ToString();     //purchaseDate
            Label36.Text = Convert.ToDateTime(d).ToString("dd/MM/yyyy");

         
            Label38.Text = dr[13].ToString(); //licenseType

            string license_dateF = dr[14].ToString();  //licenseDateFrom
            Label40.Text = Convert.ToDateTime(license_dateF).ToString("dd/MM/yyyy"); 

            string license_date_To = dr[15].ToString();  //licensedateTo
            Label42.Text = Convert.ToDateTime(license_date_To).ToString("dd/MM/yyyy");
            
            Label44.Text = dr[16].ToString(); //NoOflicense
            Label46.Text = dr[17].ToString(); //indentNo
            Label48.Text = dr[18].ToString(); //indentType
            Label50.Text = dr[19].ToString(); //status
            Label52.Text = dr[20].ToString(); //userID
        }
        dr.Close();
        con.Close();

    }

    protected void DownloadFile(object sender, EventArgs e)
    {
        string att = ((sender as LinkButton).CommandArgument);
        byte[] bytes;
        string fileName, contentType;
        string filePath = (sender as LinkButton).CommandArgument;
        //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        // using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select Attachments, FileName, ContentType from Records where SystemName= SystemName";
                cmd.Parameters.AddWithValue("@Attachments", att);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    bytes = (byte[])sdr["Attachments"];
                    contentType = sdr["ContentType"].ToString();
                    fileName = sdr["FileName"].ToString();
                }
                con.Close();
            }
        }
        Response.Clear();
        Response.Buffer = true;
        Response.Charset = "";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = contentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.WriteFile("~/uploads/" + filePath);

        Response.BinaryWrite(bytes);
       // Response.Flush();
        Response.End();

    }
    protected void Button11_Click(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}