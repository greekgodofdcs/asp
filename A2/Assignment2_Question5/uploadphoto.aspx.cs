using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;


public partial class uploadphoto : System.Web.UI.Page
{
    String cstr = (ConfigurationManager.ConnectionStrings["conreg"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginuser_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            SqlConnection con = new SqlConnection(cstr);
            string strname = FileUpload1.FileName.ToString();
            string image = "/images/" + strname;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/") + strname);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE registration SET image = '" + image + "' WHERE name = '" + Session["name"] + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Image Uploaded successfully";
            Response.Redirect("Viewprofile.aspx");
        }
        else
        {
            Label1.Text = "Plz upload the image.";
        }
    }
}