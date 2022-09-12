<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('login.jpg'); height: 795px;">
               <br />
                <br />
            <div style="width: 678px; height: 147px; margin-left: 108px">
        <table>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="Username:" Font-Bold="True" Font-Size="XX-Large" ForeColor="Yellow"></asp:Label>
                    </td>
                 <td>
                     <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label2" runat="server" Text="Password:" Font-Bold="True" Font-Size="XX-Large" ForeColor="Yellow"></asp:Label>
                    </td>
                 <td>
                     <asp:TextBox ID="txtpass" TextMode="Password" runat="server" ></asp:TextBox>
                     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/forgetpass.aspx" ForeColor="Fuchsia">Forget Password</asp:HyperLink>  
                </td>
            </tr>
             <tr>
                 <td>
                     <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>  
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/registration.aspx" ForeColor="Yellow">Registration Page</asp:HyperLink>  
    </div>
        </div>
    
    </form>
</body>
</html>
