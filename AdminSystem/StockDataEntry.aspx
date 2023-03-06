<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="StockID" width="91px"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDescription" runat="server" Text="Description" width="91px"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="91px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID" width="91px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblExpiryDate" runat="server" Text="Expiry Date" width="91px"></asp:Label>
            <asp:TextBox ID="txtExpiryDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductPrice" runat="server" Text="Product Price" width="91px"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCanPurchase" runat="server" Text="Can Purchase?"></asp:Label>
            <asp:CheckBox ID="chkCanPurchase" runat="server" Text="True" />
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
