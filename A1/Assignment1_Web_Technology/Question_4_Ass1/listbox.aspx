<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listbox.aspx.cs" Inherits="listbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Hobby:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txthobby" runat="server"></asp:TextBox>
        
        <br />
        
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <br />
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
        <br />
        <br />
        <asp:Button ID="btnnext" runat="server" OnClick="btnnext_Click" Text="Next Page" />
    </div>
    </form>
</body>
</html>
