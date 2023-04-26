<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderLst" runat="server" OnSelectedIndexChanged="lstOrderLst_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 61px; position: absolute; height: 600px; width: 786px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 729px; position: absolute" Text="add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 144px; top: 732px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 1020px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 269px; top: 732px; position: absolute" Text="Delete" />
        <asp:Label ID="LblOrderNo" runat="server" style="z-index: 1; left: 54px; top: 850px; position: absolute" Text="Enter a Order Number:"></asp:Label>
        <asp:TextBox ID="TxtboxOrderNo" runat="server" style="z-index: 1; left: 446px; top: 858px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 36px; top: 938px; position: absolute" Text="Apply" />
    </form>
</body>
</html>
