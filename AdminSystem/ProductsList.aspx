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

        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
