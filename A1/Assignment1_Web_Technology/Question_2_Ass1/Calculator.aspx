<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtans" runat="server" Height="39px" Width="252px" BackColor="#FFFFCC" BorderStyle="Solid"></asp:TextBox>
        <br />
        <asp:Button ID="btn1" runat="server" Height="32px" OnClick="btn1_Click" style="margin-top: 0px" Text="1" Width="77px" />
        <asp:Button ID="btn2" runat="server" Height="32px" OnClick="btn2_Click" Text="2" Width="77px" />
        <asp:Button ID="btn3" runat="server" Height="32px" OnClick="btn3_Click" Text="3" Width="101px" />
        <br />
        <asp:Button ID="btn4" runat="server" Height="32px" OnClick="btn4_Click" Text="4" Width="77px" />
        <asp:Button ID="btn5" runat="server" Height="32px" OnClick="btn5_Click" Text="5" Width="77px" />
        <asp:Button ID="btn6" runat="server" Height="32px" OnClick="btn6_Click" Text="6" Width="101px" />
        <br />
        <asp:Button ID="btn7" runat="server" Height="32px" OnClick="btn7_Click" Text="7" Width="76px" />
        <asp:Button ID="btn8" runat="server" Height="32px" OnClick="btn8_Click" Text="8" Width="77px" />
        <asp:Button ID="btn9" runat="server" Height="32px" OnClick="btn9_Click" Text="9" Width="101px" />
        <br />
        <asp:Button ID="btnplus" runat="server" Height="32px" OnClick="btnplus_Click" Text="+" Width="77px" />
        <asp:Button ID="btnmin" runat="server" Height="32px" Text="-" Width="77px" OnClick="btnmin_Click" />
        <asp:Button ID="btnmul" runat="server" Height="32px" Text="*" Width="101px" OnClick="btnmul_Click" />
        <br />
        <asp:Button ID="btn0" runat="server" Height="32px" OnClick="btn0_Click" Text="0" Width="56px" />
        <asp:Button ID="btndiv" runat="server" Height="32px" Text="/" Width="72px" OnClick="btndiv_Click" />
        <asp:Button ID="btnok" runat="server" Height="32px" OnClick="btnok_Click" Text="=" Width="61px" />
        <asp:Button ID="btnclear" runat="server" Height="32px" Text="Clear" Width="67px" OnClick="btnclear_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
