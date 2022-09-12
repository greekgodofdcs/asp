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
        Label1.Text = Session["name"].ToString();
        Label2.Text = Session["name"].ToString();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgetpass.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewprofile.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("uploadphoto.aspx");
    }
}