<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductViewer.aspx.cs" Inherits="ProductViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Viewer Page</title>
</head>
<body>
    <h1>Product viewer page</h1>
    
    <p>Number: <asp:Label ID="lblNumber" runat="server" Text=""></asp:Label></p>
    <p>Title: <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></p>
    <p>Description: <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label></p>
    <p>Price: <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label></p>
    <p>Availability: <asp:Label ID="lblAvailability" runat="server" Text=""></asp:Label></p>
    <p>Create Date: <asp:Label ID="lblCreateDate" runat="server" Text=""></asp:Label></p>
    <p>Staff number: <asp:Label ID="lblStaffNo" runat="server" Text=""></asp:Label></p>
</body>
</html>
