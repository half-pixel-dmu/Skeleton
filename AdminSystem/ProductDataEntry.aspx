<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Product Data Entry</h1>
    <p>Create a new Service</p>

    <br />

    <form id="productForm" runat="server">
        
        <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>

        <br /><br />
        
        <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Label ID="lblPrice" runat="server" Text="Price (e.g: 12.5)"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Label ID="lvlAvailability" runat="server" Text="Availability"></asp:Label>
        <asp:CheckBox ID="chkAvailability" runat="server" />
    </form>
</body>
</html>
