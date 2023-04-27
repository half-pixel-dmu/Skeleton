<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="productDeleteForm" runat="server">
        <p>Are you sure you want to delete this record?</p>
    
        <br />
    
        <p>Product Number: <asp:Label ID="lblProductNumber" runat="server" Text=""></asp:Label></p>
    
        <br />
    
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
