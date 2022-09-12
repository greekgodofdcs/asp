<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_Map.aspx.cs" Inherits="imagemap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/image1.jpg" OnClick="ImageMap1_Click" Width="80%">
            <asp:RectangleHotSpot AlternateText="goggle" Bottom="41" HotSpotMode="Navigate" Left="200" NavigateUrl="http://www.goggle.com" Right="600" Top="80" />
            <asp:CircleHotSpot AlternateText="amazon" HotSpotMode="Navigate" NavigateUrl="http://www.amazon.com" Radius="41" X="139" Y="50" />
        </asp:ImageMap>
    
    </div>
    </form>
</body>
</html>
