<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID Number  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <br />
        <asp:Label ID="lblSupplierCompanyName" runat="server" Text="Company Name   "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierPhoneNumber" runat="server" Text="Phone Number   "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierVatNumber" runat="server" Text="VAT number   "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfRegistration" runat="server" Text="Date Registered    "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierDeliveryDay" runat="server" Text="Delivery Day    "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkSupplierActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
