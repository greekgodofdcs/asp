<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="website" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('login.jpg'); height: 745px;">
       <table>
           <tr>
               <td>
                   <h1 style="color: #FFFFFF">Registration Page</h1>
               </td>
           </tr>
               <tr>
                   <td style="color: #FFFFFF">     
                       <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>&nbsp;&nbsp;
                       </td>
                   <td>
                       <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                   </td>
               </tr>
            <tr>
                   <td style="color: #FFFFFF">     
                       <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>&nbsp;&nbsp;
                   </td>
                <td>
                       <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                   </td>
                   
             </tr>
           <tr>
                   <td style="color: #FFFFFF">     
                       <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp;
                   </td>
                    <td>
                         <asp:TextBox ID="txtpass" TextMode="Password" runat="server"></asp:TextBox>
                     </td>  
             </tr>
           <tr>
                   <td style="color: #FFFFFF">     
                       <asp:Label ID="Label4" runat="server" Text="Cpassword:"></asp:Label>&nbsp;&nbsp;
                   </td>
                    <td>
                         <asp:TextBox ID="txtcpass" TextMode="Password" runat="server"></asp:TextBox>
                     </td>  
             </tr>
          
           <tr>
                   <td style="color: #FFFFFF">     
                       <asp:Label ID="Label6" runat="server" Text="email:"></asp:Label>&nbsp;&nbsp;
                   </td>
                    <td>
                         <asp:TextBox ID="txtemail" TextMode="email" runat="server"></asp:TextBox>
                     </td>  
             </tr>
            <tr>
                   <td style="color: #FFFFFF">     
                       &nbsp;&nbsp;
                   </td>
                    <td>
                        <br />
                       <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx" ForeColor="Yellow">Login Page</asp:HyperLink>
                     </td>  
             </tr>
           
       </table>
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        <br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;
                                
    </div>
    </form>
</body>
</html>
