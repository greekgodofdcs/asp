using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculator : System.Web.UI.Page
{
    Calculate _Calculate;
    protected void Page_Load(object sender, EventArgs e)
    {
        _Calculate = new Calculate();
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        if (txtans.Text == string.Empty)
        {
            Response.Write("Value is Empty!!");
        }
        else
        {
            ViewState["Value2"] = txtans.Text;
            txtans.Text = string.Empty;
            try
            {
                if ((string)ViewState["Operation"] == "Addition")
                {
                    txtans.Text = _Calculate.Add(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Subtraction")
                {
                    txtans.Text = _Calculate.Subtract(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Multiplication")
                {
                    txtans.Text = _Calculate.Multiply(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Division")
                {
                    txtans.Text = _Calculate.Divide(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else Response.Write("Value is Empty!!");
            }
            catch (FormatException)
            {
                Response.Write("Value is Empty!!");
            }
        }
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "1";
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "2";
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "3";
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "4";
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "5";
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "6";
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "7";
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "8";
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "9";
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        txtans.Text = txtans.Text + "0";
    }

    protected void btnplus_Click(object sender, EventArgs e)
    {
        if (txtans.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = txtans.Text;
            ViewState["Operation"] = "Addition";
            txtans.Text = string.Empty;
        }
    }

    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtans.Text = "";
    }

    protected void btnmin_Click(object sender, EventArgs e)
    {
        if (txtans.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = txtans.Text;
            ViewState["Operation"] = "Subtraction";
            txtans.Text = string.Empty;
        }
    }

    protected void btnmul_Click(object sender, EventArgs e)
    {
        if (txtans.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = txtans.Text;
            ViewState["Operation"] = "Multiplication";
            txtans.Text = string.Empty;
        }
    }

    protected void btndiv_Click(object sender, EventArgs e)
    {
        if (txtans.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = txtans.Text;
            ViewState["Operation"] = "Division";
            txtans.Text = string.Empty;
        }
    }
}
public class Calculate
    {
        public int Add(int Value1, int Value2)
        {
            return Value1 + Value2;
        }
        public int Subtract(int Value1, int Value2)
        {
            return Value1 - Value2;
        }
        public int Multiply(int Value1, int Value2)
        {
            return Value1 * Value2;
        }
        public double Divide(int Value1, int Value2)
        {
            return Value1 / Value2;
        }
    }