using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class forgetpass : System.Web.UI.Page
{
    String cstr = (ConfigurationManager.ConnectionStrings["conreg"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void changepass_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(cstr);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM registration WHERE pass='" + oldpass.Text + "'", con);
        cmd.Connection = con;
        int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
        if (OBJ > 0)
        {
            if (newpass.Text == cnewpass.Text)
            {
                SqlConnection con1 = new SqlConnection(cstr);
                SqlCommand cmd1 = new SqlCommand("UPDATE registration SET pass = '" + newpass.Text + "' WHERE name = '" + Session["name"] + "'", con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
            }
            else
            {
                Label2.Text = "New and conform password does not match..!";
            }
        }
        else
        {
            Label1.Text = "Password is invalid..!!";
        }
    }
}
