﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="392px" Width="516px"></asp:ListBox>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblEnterName" runat="server" Text="Enter a name: "></asp:Label>
            <asp:TextBox ID="txtNameToFilter" runat="server" Height="19px" Width="196px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
