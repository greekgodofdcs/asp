<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userpage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="font-size:xx-large;">
            Welcome
            <asp:Label ID="Label1" runat="server" ForeColor="Blue" Font-Bold="True" Font-Underline="True"></asp:Label>
            !</div>
       <div>
                  <br />
            Hi<asp:Label ID="Label2" runat="server" ForeColor="Blue"></asp:Label>
           
            <br />
            <div style="font-size:xx-large; text-decoration: underline; font-weight: bolder;">
                User Controls :
            </div>
            <br />
            
            <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Black" style="text-decoration:none;" OnClick="LinkButton1_Click">Change Password</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Black" style="text-decoration:none;" OnClick="LinkButton3_Click">Upload Profile Photo</asp:LinkButton>
           <br />
            <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Black" style="text-decoration:none;" OnClick="LinkButton2_Click">View Profile</asp:LinkButton>
           
        </div>
    </form>
</body>
</html>
