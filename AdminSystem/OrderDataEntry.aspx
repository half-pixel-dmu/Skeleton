<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #lblCustomerNo {
            height: 45px;
        }
        .auto-style2 {
            font-size: x-large;
            height: 35px;
            margin-bottom: 19px;
        }
        #form1 {
            height: 88px;
            font-size: large;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            height: 35px;
            margin-bottom: 19px;
        }
    </style>
</head>
<body style="height: 39px; font-size: xx-large;">
    <form id="form1" runat="server">
        <p class="auto-style4">
            <strong>Order Data Entry</strong></p>
        <p class="auto-style2">
            Create a new Order</p>
        <p class="auto-style5" id="lblOrderNo">
            Order No<asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; top: 114px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 227px; top: 115px; position: absolute" Text="Find" />
        </p>
        <p class="auto-style5" id="lblCustomerNo">
            Customer No<asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; top: 168px; position: absolute"></asp:TextBox>
        </p>
        <p class="auto-style5" id="lblOrderDate">
            Order Date<asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; top: 232px; position: absolute"></asp:TextBox>
        </p>
        <p class="auto-style5" id="lblProductId">
            Product Id<asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; top: 286px; position: absolute"></asp:TextBox>
        </p>
        <p class="auto-style5" id="lblOrderPrice">
            Order Price<asp:TextBox ID="txtOrderPrice" runat="server" style="z-index: 1; top: 340px; position: absolute"></asp:TextBox>
        </p>
        <p class="auto-style5" id="lblOrderStatus">
            Order Status<asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; top: 394px; position: absolute"></asp:TextBox>
        </p>
        <p class="auto-style5">
            <asp:Button ID="btnCreate" runat="server" style="z-index: 1; left: 20px; top: 455px; position: absolute" Text="Create" OnClick="btnCreate_Click1" />
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 86px; top: 452px; position: absolute" Text="Cancel" />
        </p>
        <p class="auto-style5" id="lblError">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 544px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
