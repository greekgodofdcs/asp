<%@ Page Language="C#" AutoEventWireup="true" CodeFile="displaylistbox.aspx.cs" Inherits="displaylistbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Height="91px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="125px">
            
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
