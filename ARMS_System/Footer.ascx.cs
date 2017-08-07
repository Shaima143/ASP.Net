using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Footer : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Copyright © 2017 Sultan Qaboos University Hospital";
        Label1.ForeColor = System.Drawing.Color.White;

        Label2.Text = "Hospital Information Systems Directorate";
        Label2.ForeColor = System.Drawing.Color.White;

        Label3.Text = "Application Section";
        Label3.ForeColor = System.Drawing.Color.White;
    }
}