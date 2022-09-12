using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

public partial class AllHobbyDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["hobby"] != null)
            {
                ArrayList hobby = new ArrayList();
                hobby = (ArrayList)Session["hobby"];
                for (int i = 0; i < hobby.Count; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = hobby[i].ToString() + "<br>";
                    form1.Controls.Add(lbl);
                }
            }
        }
    }
}