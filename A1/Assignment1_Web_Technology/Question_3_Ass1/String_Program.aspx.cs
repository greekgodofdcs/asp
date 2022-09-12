using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class stringprg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Display each Word Separately")
        {
            string[] separate = TextBox1.Text.Split();
            foreach (var data in separate)
            {
                Label lbl = new Label();
                lbl.Text = data + "<br>";
                form1.Controls.Add(lbl);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Count no of characters")
        {
            Label lbl = new Label();
            lbl.Text = "Total No. Of Characters Are : " + TextBox1.Text.Length.ToString();
            form1.Controls.Add(lbl);
        }
        else if (DropDownList1.SelectedItem.Text == "Check the input string is palindrome or not")
        {
            string str, revstr = "";
            str = TextBox1.Text;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr += str[i].ToString();
            }

            if (revstr == str)
            {
                Label lbl = new Label();
                lbl.Text = "<b>String Is Palindrome : </b>" + str + "  <b>Reverse String : </b>" + revstr;
                form1.Controls.Add(lbl);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "<b>String Is Not Palindrome : </b>" + str + "\n <b>Reverse String : </b>" + revstr;
                form1.Controls.Add(lbl);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Check if there any non alphabetic character in string or not")
        {
            string str = TextBox1.Text;
            if (Regex.IsMatch(str, @"^[a-zA-z]+([\s][a-zA-Z]+)*$"))
            {
                Label lbl = new Label();
                lbl.Text = "String Is Alphabatic";
                form1.Controls.Add(lbl);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "String Is Not Alphabatic";
                form1.Controls.Add(lbl);
            }
        }
    }
}//"^[a-zA-Z]*$"
   