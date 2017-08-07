using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            Label7.Text = Request.QueryString["userid"];
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
     

        TextBox2.Visible = false;
        TextBox3.Visible = false;
        TextBox4.Visible = false;
        
        TextBox7.Visible = false;
        SystemDesc_TextBox.Visible = false;
        TextBox8.Visible = false;
        TextBox9.Visible = false;

        Label21.Visible = false;
        TextBox10.Visible = false;

        Label22.Visible = false;
        P_purchaseDateTextbox.Visible = false;

        Label23.Visible = false;
        DropDownList1.Visible = false;

        Label24.Visible = false;
        P_From.Visible = false;
        P_To.Visible = false;
        From_Textbox.Visible = false;
        To_Textbox.Visible = false;

        Label25.Visible = false;
        TextBox11.Visible = false;

        Label26.Visible = false;
        TextBox12.Visible = false;

        Label27.Visible = false;
        DropDownList2.Visible = false;

        Update_InHouse.Visible = false;
        Update_Purchased.Visible = false;




        ProjectManagerEmail.Visible = false;
        ProjectManagerEmail_Textbox1.Visible = false;

        FocalPointUser.Visible = false;
        FocalPointUser_TextBox.Visible = false;

        FocalPointUserExt.Visible = false;
        FocalPointUserExt_TextBox.Visible = false;

        FocalPointUserEmail.Visible = false;
        FocalPointUserEmail_Textbox.Visible = false;

        VendorEmail.Visible = false;
        VendorEmail_Textbox.Visible = false;

        Label28.Visible = false;
  
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminCreateUser.aspx?userid=" + Label7.Text.ToString());
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageUserAccounts.aspx?userid=" + Label7.Text.ToString());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewRecord.aspx?userid=" + Label7.Text.ToString());
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminManageRecordStatus.aspx?userid=" + Label7.Text.ToString());
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUpdateRecord.aspx?userid=" + Label7.Text.ToString());
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchIn_House.aspx?userid=" + Label7.Text.ToString());
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_Purchased.aspx?userid=" + Label7.Text.ToString());
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label7.Text.ToString());
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

        string name = GridView1.SelectedRow.Cells[1].Text;
        string type = GridView1.SelectedRow.Cells[2].Text;

        Label10.Text = name;
        Label11.Text = type;

        if (Label11.Text.Equals("In-House "))
        {
            Label12.Visible = true;
            TextBox2.Visible = true;

            Label13.Visible = true;
            TextBox3.Visible = true;

            Label14.Visible = true;
            TextBox4.Visible = true;

            ProjectManagerEmail.Visible = true;
            ProjectManagerEmail_Textbox1.Visible = true;

            FocalPointUser.Visible = true;
            FocalPointUser_TextBox.Visible = true;

            FocalPointUserExt.Visible = true;
            FocalPointUserExt_TextBox.Visible = true;

            FocalPointUserEmail.Visible = true;
            FocalPointUserEmail_Textbox.Visible = true;

            Label17.Visible = true;
            Label17.Text = "Implementation Lang.:";
            TextBox7.Visible = true;

            Label18.Visible = true;
            SystemDesc_TextBox.Visible = true;

            Label19.Visible = true;
            Label19.Text = "Version No.:";
            TextBox8.Visible = true;

            Label20.Visible = true;
            Label20.Text = "Special Requirements:";
            TextBox9.Visible = true;

          
            Update_InHouse.Visible = true;
            Update_Purchased.Visible = false;

            Label28.Visible = true;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SystemOwner, ProjectManager, ProjectManagerEXT, ProjectManagerEmail, FocalPointUser, FocalPointUserEXT, FocalPointUserEmail, ImpLang, SystemDescription, VersionNo, SpecialReqs FROM Records WHERE SystemType='" + Label11.Text+"' AND SystemName='"+Label10.Text+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text = dr[0].ToString(); //SystemOwner
                TextBox3.Text = dr[1].ToString(); //ProjectManager
                TextBox4.Text = dr[2].ToString(); //ProjectManagerEXT
                ProjectManagerEmail_Textbox1.Text = dr[3].ToString(); //ProjectManagerEmail
                FocalPointUser_TextBox.Text = dr[4].ToString(); //FocalPointUser
                FocalPointUserExt_TextBox.Text = dr[5].ToString(); //FocalPointUserEXT
                FocalPointUserEmail_Textbox.Text = dr[6].ToString(); //FocalPointUserEmail

                TextBox7.Text = dr[7].ToString(); //Implang
                SystemDesc_TextBox.Text = dr[8].ToString(); //Desc
                TextBox8.Text = dr[9].ToString(); //versionNo
                TextBox9.Text = dr[10].ToString(); //SpecReqs

                dr.Close();
            }
            con.Close();

        }
        else if(Label11.Text.Equals("Purchased"))
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("-- Select --", String.Empty));
                DropDownList1.SelectedIndex = 0;

                DropDownList2.Items.Insert(0, new ListItem("-- Select --", String.Empty));
                DropDownList2.SelectedIndex = 0;
            }

            Label12.Visible = true;
            TextBox2.Visible = true;

            Label13.Visible = true;
            TextBox3.Visible = true;

            Label14.Visible = true;
            TextBox4.Visible = true;

            Label17.Visible = true;
            Label17.Text = "Special Requirements:";
            TextBox7.Visible = true;

            Label18.Visible = true;
            SystemDesc_TextBox.Visible = true;

            Label19.Visible = true;
            Label19.Text = "System Cost:";
            TextBox8.Visible = true;
            
            Label20.Visible = true;
            Label20.Text = "Vendor's Name:&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
            TextBox9.Visible = true;

            Label21.Visible = true;
            Label21.Text = "Vendor's Contact No.:";
            TextBox10.Visible = true;

            Label22.Visible = true;
            P_purchaseDateTextbox.Visible = true;

            Label23.Visible = true;
            DropDownList1.Visible = true;

            Label24.Visible = true;
            P_From.Visible = true;
            P_To.Visible = true;
            From_Textbox.Visible = true;
            To_Textbox.Visible = true;

            Label25.Visible = true;
            TextBox11.Visible = true;

            Label26.Visible = true;

            Label26.Visible = true;
            TextBox12.Visible = true;

            Label27.Visible = true;
            DropDownList2.Visible = true;

            Update_InHouse.Visible = false;
            Update_Purchased.Visible = true;


            ProjectManagerEmail.Visible = true;
            ProjectManagerEmail_Textbox1.Visible = true;

            FocalPointUser.Visible = true;
            FocalPointUser_TextBox.Visible = true;

            FocalPointUserExt.Visible = true;
            FocalPointUserExt_TextBox.Visible = true;

            FocalPointUserEmail.Visible = true;
            FocalPointUserEmail_Textbox.Visible = true;

            VendorEmail.Visible = true;
            VendorEmail_Textbox.Visible = true;

            Label28.Visible = true;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SystemOwner, ProjectManager, ProjectManagerEXT, ProjectManagerEmail, FocalPointUser, FocalPointUserEXT, FocalPointUserEmail, SpecialReqs, SystemDescription,"
            +" SystemCost, VendorName, VendorContactNo, VendorEmail, PurchaseDate, LicenseType, LicenseDateFrom, LicenseDateTo, NoOfLicense,"
            +" IndentNo, IndentType FROM Records WHERE SystemType='" + Label11.Text + "' AND SystemName='" + Label10.Text + "'";
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                TextBox2.Text = drr[0].ToString(); //owner
                TextBox3.Text = drr[1].ToString(); //manager
                TextBox4.Text = drr[2].ToString(); //managerEXT
                ProjectManagerEmail_Textbox1.Text = drr[3].ToString(); //ManagerEmail
                FocalPointUser_TextBox.Text = drr[4].ToString(); //FocalPointUser
                FocalPointUserExt_TextBox.Text = drr[5].ToString(); //FocalPointUserEXT
                FocalPointUserEmail_Textbox.Text = drr[6].ToString(); //FocalPointUserEmail
                TextBox7.Text = drr[7].ToString(); //specReqs
                SystemDesc_TextBox.Text = drr[8].ToString(); //desc
                TextBox8.Text = drr[9].ToString(); //cost
                TextBox9.Text = drr[10].ToString(); //vendorName
                TextBox10.Text = drr[11].ToString(); //VendorContactNo
                VendorEmail_Textbox.Text = drr[12].ToString(); //VendorEmail

                string pur_date = drr[13].ToString();     //purchaseDate
                P_purchaseDateTextbox.Text = Convert.ToDateTime(pur_date).ToString("dd/MM/yyyy");

                DropDownList1.SelectedValue = drr[14].ToString(); //LicenseType

                string date_from = drr[15].ToString(); //License_Date_From
                From_Textbox.Text = Convert.ToDateTime(date_from).ToString("dd/MM/yyyy");

                string date_to = drr[16].ToString(); //License_Date_To
                To_Textbox.Text = Convert.ToDateTime(date_to).ToString("dd/MM/yyyy");

                TextBox11.Text = drr[17].ToString(); //LicenseNo
                TextBox12.Text = drr[18].ToString(); //IndentNo
                DropDownList2.SelectedValue = drr[19].ToString(); //IndentType         

                drr.Close();
            }
            con.Close();

        }
    }
    protected void Update_InHouse_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * FROM Records WHERE SystemName='"+Label10.Text+"' AND SystemType='In-House'";
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateIn-HouseAdminSP";

            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = Label10.Text.Trim();
            cmd.Parameters.Add("@owner", SqlDbType.VarChar, 100).Value = TextBox2.Text.Trim();
            cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = TextBox3.Text.Trim();
            cmd.Parameters.Add("@managerEXT", SqlDbType.Int).Value = TextBox4.Text.Trim();
            cmd.Parameters.Add("@managerEmail", SqlDbType.VarChar, 100).Value = ProjectManagerEmail_Textbox1.Text.Trim();
            cmd.Parameters.Add("@focalPointUser", SqlDbType.VarChar, 100).Value = FocalPointUser_TextBox.Text.Trim();
            cmd.Parameters.Add("@focalPointUserEXT", SqlDbType.Int).Value = FocalPointUserExt_TextBox.Text.Trim();
            cmd.Parameters.Add("@focalPointUserEmail", SqlDbType.VarChar, 100).Value = FocalPointUserEmail_Textbox.Text.Trim();
            cmd.Parameters.Add("@Implang", SqlDbType.VarChar, 200).Value = TextBox7.Text.Trim();
            cmd.Parameters.Add("@systemdesc", SqlDbType.VarChar, 1000).Value = SystemDesc_TextBox.Text.Trim();
            cmd.Parameters.Add("@versionNo", SqlDbType.VarChar, 50).Value = TextBox8.Text.Trim();
            cmd.Parameters.Add("@specialreqs", SqlDbType.VarChar, 200).Value = TextBox9.Text.Trim();

            // con.Open();
            dr.Close();
            cmd.ExecuteNonQuery();
            con.Close();

            GridView1.DataBind();

            string script = "alert(\"Record details has been updated successfully!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }
       
    }
           

    
    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Update_Purchased_Click(object sender, EventArgs e)
    {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Records WHERE SystemName='" + Label10.Text + "' AND SystemType='Purchased'";
            SqlDataReader drrr = cmd.ExecuteReader();
            if (drrr.Read())
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdatePurchased_AdminSP";

                cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = Label10.Text.Trim();
                cmd.Parameters.Add("@owner", SqlDbType.VarChar, 100).Value = TextBox2.Text.Trim();
                cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = TextBox3.Text.Trim();
                cmd.Parameters.Add("@managerEXT", SqlDbType.Int).Value = TextBox4.Text.Trim();
                cmd.Parameters.Add("@managerEmail", SqlDbType.VarChar, 100).Value = ProjectManagerEmail_Textbox1.Text.Trim();
                cmd.Parameters.Add("@focalPointUser", SqlDbType.VarChar, 100).Value = FocalPointUser_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEXT", SqlDbType.Int).Value = FocalPointUserExt_TextBox.Text.Trim();
                cmd.Parameters.Add("@focalPointUserEmail", SqlDbType.VarChar, 100).Value = FocalPointUserEmail_Textbox.Text.Trim();
                cmd.Parameters.Add("@systemdesc", SqlDbType.VarChar, 1000).Value = SystemDesc_TextBox.Text.Trim();
                cmd.Parameters.Add("@specialreqs", SqlDbType.VarChar, 200).Value = TextBox7.Text.Trim();
                cmd.Parameters.Add("@cost", SqlDbType.VarChar, 50).Value = TextBox8.Text.Trim();
                cmd.Parameters.Add("@vendorname", SqlDbType.VarChar, 100).Value = TextBox9.Text.Trim();
                cmd.Parameters.Add("@vendorcontact", SqlDbType.Int).Value = TextBox10.Text.Trim();
                cmd.Parameters.Add("@vendorEmail", SqlDbType.VarChar, 100).Value = VendorEmail_Textbox.Text.Trim();

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


                cmd.Parameters.Add("@NoOfLicense", SqlDbType.Int).Value = TextBox11.Text.Trim();
                cmd.Parameters.Add("@indentNo", SqlDbType.Int).Value = TextBox12.Text.Trim();
                cmd.Parameters.Add("@indentType", SqlDbType.VarChar, 50).Value = DropDownList2.SelectedItem.ToString();

                RequiredFieldValidator val = new RequiredFieldValidator();
                val.ControlToValidate = TextBox10.Text;
                val.ErrorMessage = "**";
                val.ForeColor = System.Drawing.Color.Red;
                //this.Controls.Add(val);


                drrr.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                GridView1.DataBind();

                string script = "alert(\"Record details has been updated successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }
      
    }
