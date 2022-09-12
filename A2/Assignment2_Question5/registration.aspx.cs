using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

public partial class website : System.Web.UI.Page
{
    //SqlConnection cn;
    //SqlCommand cmd;
    //SqlDataReader rd;
    //String str;

    String cstr = (ConfigurationManager.ConnectionStrings["conreg"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            load_Data();
        }
    }
    protected void load_Data()
    {
        
       /* cmd = new SqlCommand();
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        str = "select * from registration";
        cmd.CommandText = str;

        rd = cmd.ExecuteReader();

        GridView1.DataSource = rd;
        GridView1.DataBind();

        rd.Close();
        cmd.Dispose();
        cn.Close();
        cn.Dispose();*/
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(cstr);

        SqlCommand cmd1 = new SqlCommand("INSERT INTO registration VALUES(@id, @name, @password, @cpassword, @email, @image)", con1);
        cmd1.CommandType = CommandType.Text;
        cmd1.Parameters.AddWithValue("@id", Convert.ToInt64(txtid.Text));
        cmd1.Parameters.AddWithValue("@name", txtname.Text);
        cmd1.Parameters.AddWithValue("@password", txtpass.Text);
        cmd1.Parameters.AddWithValue("@cpassword", txtcpass.Text);
        cmd1.Parameters.AddWithValue("@email", txtemail.Text);
        cmd1.Parameters.AddWithValue("@image", "");
        con1.Open();
        cmd1.ExecuteNonQuery();
        Session["name"] = txtname.Text;
        con1.Close();

        lblmsg.Text = "User Registered Successfully..!!";
        txtname.Text = "";
        txtpass.Text = "";
        txtcpass.Text = "";
        txtemail.Text = ""; 

    }
}
