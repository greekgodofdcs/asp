using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    String cstr = (ConfigurationManager.ConnectionStrings["conreg"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(cstr);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*)FROM registration WHERE name='" + txtuname.Text + "' AND pass='" + txtpass.Text + "'", con);
        cmd.Connection = con;
        int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
        if (OBJ > 0)
        {
            Session["name"] = txtuname.Text;
            Response.Redirect("userpage.aspx");
        }
        else
        {
            Label1.Text = "Username and Password is Invalid..!!";
        }
    }
}