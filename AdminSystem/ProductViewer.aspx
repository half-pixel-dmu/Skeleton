<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductViewer.aspx.cs" Inherits="ProductViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Viewer Page</title>
</head>
<body>
    <h1>Product viewer page</h1>
    
    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblAvailability" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblStaffNo" runat="server" Text=""></asp:Label>
</body>
</html>
