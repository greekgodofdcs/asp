<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('login.jpg'); height: 745px;">
        <br />
        <br />
        <div style="width: 673px; height: 157px; margin-left: 88px">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx" ForeColor="Yellow" Font-Size="XX-Large">Login Page</asp:HyperLink>
        <br /><br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/registration.aspx" ForeColor="Yellow" Font-Size="XX-Large">Registration Page</asp:HyperLink> 
            </div>
    </div>
    </form>
</body>
</html>
