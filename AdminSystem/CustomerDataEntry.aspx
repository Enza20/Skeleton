<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the customer entry page
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" ></asp:TextBox>
        <br />
        <div>
            <asp:Label ID="lblCustomerFullName" runat="server" Text="Full Name" width="230px"></asp:Label>
            <asp:TextBox ID="txtCustomerFullName" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="lblCustomerPhoneNumber" runat="server" Text="Phone Number" width="230px"></asp:Label>
        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerBillingAddress" runat="server" Text="Billing Address" width="230px"></asp:Label>
            <asp:TextBox ID="txtCustomerBillingAddress" runat="server" ></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOfRegistration" runat="server" Text="Registration Date" width="230px"></asp:Label>
        <asp:TextBox ID="txtDateOfRegistration" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkIsAllowed" runat="server" Text="Verified" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
        <asp:Label ID="lblError" runat="server" width="230px"></asp:Label>
        </p>
    </form>
</body>
</html>
