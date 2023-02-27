<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="118px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Home Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

    </form>
</body>
</html>
