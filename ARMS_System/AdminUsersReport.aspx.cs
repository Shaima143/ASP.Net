using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Insert(0, new ListItem("-- Select --", String.Empty));
            DropDownList1.SelectedIndex = 0;
        }

        if (Session["userid"] == null)
        {
            Response.Redirect("startpage.aspx");
        }
        else
        {
            Label3.Text = Request.QueryString["userid"];
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminReports.aspx?userid=" + Label3.Text.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUsersReport.aspx?userid= " + Label3.Text.ToString());
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}