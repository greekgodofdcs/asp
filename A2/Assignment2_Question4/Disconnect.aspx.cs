using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class iud : System.Web.UI.Page
{
    SqlDataAdapter adap;
    DataSet ds;
    static int rindex;
    SqlCommandBuilder cmd;
    string cstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        cstr = ConfigurationManager.ConnectionStrings["disiudmcacn"].ConnectionString;
       if (!IsPostBack)
        {
            load_grid();
        }
    }

    protected void load_grid()
    {
        adap = new SqlDataAdapter("select * from stud", cstr);
        ds = new DataSet();
        adap.Fill(ds);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

        //GridView1.DataSource = ds;
        //GridView1.DataBind();

        ds.Dispose();
        adap.Dispose();

    }
    protected void Btnsave_Click(object sender, EventArgs e)
    {
        adap = new SqlDataAdapter("select * from stud", cstr);
        ds = new DataSet();
        adap.Fill(ds);

        DataRow dr = ds.Tables[0].NewRow();
        dr[0] = Convert.ToInt16(txtrno.Text);
        dr["sname"] = txtname.Text;
        dr[2] = txtcourse.Text;
        dr[3] = Convert.ToInt64(txtmno.Text);
        dr[4] = txtemail.Text;

        ds.Tables[0].Rows.Add(dr);

        SqlCommandBuilder cb = new SqlCommandBuilder(adap);
        adap.UpdateCommand = cb.GetDeleteCommand();

        adap.Update(ds);

        cb.Dispose();
        ds.Dispose();
        adap.Dispose();

        load_grid();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
   {
        rindex = GridView1.SelectedIndex;
        txtrno.Text = GridView1.SelectedRow.Cells[0].Text;
        txtname.Text = GridView1.SelectedRow.Cells[1].Text;
        txtcourse.Text = GridView1.SelectedRow.Cells[2].Text;
        txtmno.Text = GridView1.SelectedRow.Cells[3].Text;
        txtemail.Text = GridView1.SelectedRow.Cells[4].Text;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        adap = new SqlDataAdapter("select * from Stud", cstr);
        cmd = new SqlCommandBuilder(adap);
        ds = new DataSet();
        adap.Fill(ds);
        DataRow dr = ds.Tables[0].Rows[rindex];
        dr.BeginEdit();
      
        dr[1] = txtname.Text;
        dr[2] = txtcourse.Text;
        dr[3] = txtmno.Text;
        dr[4] = txtemail.Text;
        dr.EndEdit();
        adap.Update(ds);
        //load_grid();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

    protected void Btndelete_Click(object sender, EventArgs e)
    {
        adap = new SqlDataAdapter("select * from Stud", cstr);
        cmd = new SqlCommandBuilder(adap);
        ds = new DataSet();
        adap.Fill(ds);
        DataRow dr = ds.Tables[0].Rows[Convert.ToInt32(txtrno.Text) - 1];
        ds.Tables[0].Rows.Remove(dr);
        adap.Update(ds);
        //load_grid();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}