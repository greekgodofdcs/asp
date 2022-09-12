using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Viewprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String cstr = (ConfigurationManager.ConnectionStrings["conreg"].ConnectionString);
        SqlConnection con = new SqlConnection(cstr);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM registration WHERE name = '" + Session["name"] + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Image1.ImageUrl = ds.Tables[0].Rows[0]["image"].ToString();
        lbl_UserName.Text = ds.Tables[0].Rows[0]["name"].ToString();
        lbl_email.Text = ds.Tables[0].Rows[0]["email"].ToString();
    }
}