<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblStaffNo" runat="server" Text="Staff Number"></asp:Label>
            <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        
        <p>
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </p>
        
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Staff Email"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lvlProductNo" runat="server" Text="Product Number"></asp:Label>
            <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblStaffDate" runat="server" Text="Staff Date"></asp:Label>
             <asp:TextBox ID="txtStaffDate" runat="server"></asp:TextBox>
        </p>

        <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />

        <br />
        <br />
        
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
    </form>
    </body>
</html>
