<%@ Page Language="C#" AutoEventWireup="true" CodeFile=" Disconnect.aspx.cs" Inherits="iud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Rollno"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtrno" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtrno" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text="Enter Student Name"></asp:Label>
         &nbsp;
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtname" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
          <asp:Label ID="Label3" runat="server" Text="Enter Course"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtcourse" runat="server"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label4" runat="server" Text="Enter Mobileno"></asp:Label>
         &nbsp;
        <asp:TextBox ID="txtmno" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmno" ErrorMessage="*" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
          <asp:Label ID="Label5" runat="server" Text="Enter emailid"></asp:Label>
          &nbsp;
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        
        <br />
        <br />
        <asp:Button ID="Btnsave" runat="server" Text="Save" OnClick="Btnsave_Click" />
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
&nbsp;
        <asp:Button ID="Btndelete" runat="server" OnClick="Btndelete_Click" Text="Delete" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
