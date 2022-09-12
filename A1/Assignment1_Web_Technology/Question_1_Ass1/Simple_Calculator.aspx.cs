using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simcalc : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnplus_Click(object sender, EventArgs e)
    {
        int sum = Int32.Parse(txt1.Text) + Int32.Parse(txt2.Text);
        txtresult.Text = Convert.ToString(sum);
    }

    protected void btnmin_Click(object sender, EventArgs e)
    {
        int min = Int32.Parse(txt1.Text) - Int32.Parse(txt2.Text);
        txtresult.Text = Convert.ToString(min);
    }

    protected void btnmul_Click(object sender, EventArgs e)
    {
        int mul = Int32.Parse(txt1.Text) * Int32.Parse(txt2.Text);
        txtresult.Text = Convert.ToString(mul);
    }

    protected void btndiv_Click(object sender, EventArgs e)
    {
        int div = Int32.Parse(txt1.Text) / Int32.Parse(txt2.Text);
        txtresult.Text = Convert.ToString(div);
    }

    protected void btnclear_Click(object sender, EventArgs e)
    {
        txt1.Text = "";
        txt2.Text = "";
        txtresult.Text = ""; 
    }
}