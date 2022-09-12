<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uploadphoto.aspx.cs" Inherits="uploadphoto" %>

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
                    <td colspan="3" style="font-size:xx-large; font-weight:bolder; text-align:center;" class="auto-style1">Upload User Photo</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        Select Photo : </td>
                    <td class="auto-style8">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" ForeColor="Lime"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="loginuser" runat="server" Font-Bold="True" Font-Size="Large" Height="39px" Text="Upload" Width="128px" OnClick="loginuser_Click"  />
                    </td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
