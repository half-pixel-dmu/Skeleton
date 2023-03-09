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
        <asp:Label ID="lblCustomerNo" runat="server" Text="Customer No" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>

        <br />
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email Address" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Home Address" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerDateJoined" runat="server" Text="Date Joined" width="118px"></asp:Label>
        <asp:TextBox ID="txtCustomerDateJoined" runat="server" OnTextChanged="TextBox1_TextChanged" width="168px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Customer Confirmed"/>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

    </form>
</body>
</html>
