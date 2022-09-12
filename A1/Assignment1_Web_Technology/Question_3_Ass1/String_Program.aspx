<%@ Page Language="C#" AutoEventWireup="true" CodeFile="String_Program.aspx.cs" Inherits="stringprg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter any sentence:"></asp:Label>&nbsp;
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
            <br />            
            <br /> 
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Display each Word Separately</asp:ListItem>
                            <asp:ListItem>Count no of characters</asp:ListItem>
                            <asp:ListItem>Check the given string is palindrome or not</asp:ListItem>
                            <asp:ListItem>Check if there any non alphabetic character in string or not</asp:ListItem>
                        </asp:DropDownList>
                  <br /><br />
                        <asp:Button ID="Button1" runat="server" Text="See Result" OnClick="Button1_Click" />
           <br /><br />
            <asp:Label Text="The Result is :" runat="server" />
            <br />
            <br />
        </div>
        
    </form>
</body>
</html>
