<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductsList" runat="server" Height="429px" Width="317px"></asp:ListBox>
        </div>

        <br />
        
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

        <br />

        <p>Enter a product title: <asp:TextBox ID="txtProductTitle" runat="server"></asp:TextBox></p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
    </form>
</body>
</html>
