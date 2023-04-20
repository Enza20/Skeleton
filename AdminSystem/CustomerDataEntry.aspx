<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    This is the customer entry page<br />
&nbsp;<asp:Label ID="lblCustomerId" runat="server" Text="Customer Number" height="22px" width="128px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" height="22px" width="128px" ></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click1" style="margin-top: 26px" Text="Find" />
        <br />
        <br />
        <div>
            <asp:Label ID="lblCustomerFullName" runat="server" Text="Full Name" width="128px" height="22px"></asp:Label>
            <asp:TextBox ID="txtCustomerFullName" runat="server" height="22px" width="128px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="lblCustomerPhoneNumber" runat="server" Text="Phone Number" width="128px" height="22px"></asp:Label>
        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server" height="22px" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerBillingAddress" runat="server" Text="Billing Address" width="128px" height="22px"></asp:Label>
            <asp:TextBox ID="txtCustomerBillingAddress" runat="server" height="22px" width="128px" ></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOfRegistration" runat="server" Text="Registration Date" width="128px" height="22px"></asp:Label>
        <asp:TextBox ID="txtDateOfRegistration" runat="server" height="22px" width="128px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkIsAllowed" runat="server" Text="Verified" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
        <asp:Label ID="lblError" runat="server" width="230px"></asp:Label>
        </p>
    </form>
</body>
</html>
