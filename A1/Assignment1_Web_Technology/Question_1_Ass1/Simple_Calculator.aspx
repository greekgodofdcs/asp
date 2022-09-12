<%@ Page Language="C#" AutoEventWireup="true" CodeFile="simple_Calculator.aspx.cs" Inherits="simcalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Number1"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnplus" runat="server" OnClick="btnplus_Click" Text="+" />
&nbsp;
        <asp:Button ID="btnmin" runat="server" OnClick="btnmin_Click" Text="-" />
&nbsp;
        <asp:Button ID="btnmul" runat="server" OnClick="btnmul_Click" Text="*" />
&nbsp;&nbsp;
        <asp:Button ID="btndiv" runat="server" OnClick="btndiv_Click" Text="/" />
&nbsp;&nbsp;
        <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" Text="clear" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtresult" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
