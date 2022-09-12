using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

public partial class listbox : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(txthobby.Text);
    }

    protected void btnnext_Click(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList();
        foreach (var item in ListBox1.Items)
        {
            list.Add(item);
        }
        Session["list"] = list;
        Response.Redirect("./DisplayListBox.aspx");
    }

}