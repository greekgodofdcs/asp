<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viewprofile.aspx.cs" Inherits="Viewprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <b> User Profile</b>
            <br />
        </div>

        <div>
            <a href="Viewprofile.aspx">Viewprofile.aspx</a>
            <table>
                <tr>  
                  <td><b>User Photo :</b></td>  
                  <td><b>
                      <br />
                      <asp:Image ID="Image1" runat="server" Width="200" Height="200" />
                      <br /></b></td>  
                </tr>
                <tr>  
                  <td><b>User Name :</b></td>  
                  <td> 
                      <asp:Label  
                          ID="lbl_UserName" runat="server" Font-Bold="True"></asp:Label><br /></td>  
                </tr>  
                
                <tr>  
                  <td><b>E-mail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</b></td>  
                  <td><b>
                      <asp:Label ID="lbl_email" runat="server" Font-Bold="True"></asp:Label>
                      <br /></b></td>  
                </tr>  
                <tr>  
                    
                </tr>  
            </table>  
    </div>
    </form>
</body>
</html>
