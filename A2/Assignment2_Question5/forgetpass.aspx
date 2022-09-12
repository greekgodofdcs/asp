<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetpass.aspx.cs" Inherits="forgetpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <table>
                <tr>
                    <td colspan="3" style="font-size:xx-large; font-weight:bolder; text-align:center;" class="auto-style1">Change Password</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        Current Password : </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="oldpass" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        New
                        Password&nbsp;&nbsp; :
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="newpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        Conform New Password:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="cnewpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Login.aspx">Login page</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="changepass" runat="server" Font-Bold="True" Font-Size="Large" Height="39px" Text="Change" Width="128px" OnClick="changepass_Click" />
                    </td>
                </tr>
            </table>           
                   
        </div>
    </form>
</body>
</html>

