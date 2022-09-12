using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void custvalidate_servervalidate(object source, ServerValidateEventArgs args)
    {
        if(args.Value=="")
        {
            args.IsValid = false;
        }
        else
        {
            int Number;
            bool isNumber = int.TryParse(args.Value, out Number);
            if(isNumber && Number>0 && Number%2==0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}