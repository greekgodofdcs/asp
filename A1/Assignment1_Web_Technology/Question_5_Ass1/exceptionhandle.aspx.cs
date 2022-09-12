using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exceptionhandle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
       {
            int n = Convert.ToInt32(TextBox1.Text);
            Response.Write("Enter value=" + n);http://localhost:55193/exceptionhandle.aspx.cs
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            Response.Write("<br/>"+"we are in finally block");
        }
    }
    protected void Page_Error(object sender, EventArgs e)
    {
        Exception ex = Server.GetLastError();
        Response.Write(ex.Message);
        Context.ClearError();
        Response.Redirect("Error.aspx");
    }
    protected void btnhello_Click(object sender, EventArgs e)
    {
        double n = Math.Pow(Convert.ToInt32(TextBox1.Text), 2);
        Response.Write("square of value=" + n);
    }
}