<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 143px; top: 34px; position: absolute; width: 218px; height: 22px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 381px; top: 35px; position: absolute; height: 25px; width: 46px" Text="Find" />
        </div>
        <p>
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 22px; width: 115px" Text="Staff Number"></asp:Label>
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 10px; top: 70px; position: absolute; height: 22px; width: 115px" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 143px; top: 66px; position: absolute; width: 218px; height: 22px"></asp:TextBox>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 10px; top: 100px; position: absolute; height: 22px; width: 115px" Text="Staff Email"></asp:Label>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 143px; top: 94px; position: absolute; width: 218px; height: 22px"></asp:TextBox>
        <asp:Label ID="lvlProductNo" runat="server" style="z-index: 1; left: 10px; top: 172px; position: absolute; width: 115px; height: 22px" Text="Product Number"></asp:Label>
        <asp:TextBox ID="txtProductNo" runat="server" style="z-index: 1; left: 143px; top: 170px; position: absolute; width: 218px; height: 22px; bottom: 335px;"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffDate" runat="server" style="z-index: 1; left: 10px; top: 133px; position: absolute; height: 22px; width: 115px; " Text="Staff Date"></asp:Label>
             <asp:TextBox ID="txtStaffDate" runat="server" style="z-index: 1; left: 143px; top: 127px; position: absolute; width: 218px; height: 22px; bottom: 101px;"></asp:TextBox>
            <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 12px; top: 207px; position: absolute; width: 225px; height: 22px" Text="Availability" />
        </p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 12px; top: 284px; position: absolute; height: 23px; width: 39px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 64px; top: 285px; position: absolute; height: 24px; width: 68px" Text="Cancel" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
    </body>
</html>
