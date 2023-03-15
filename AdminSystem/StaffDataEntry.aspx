<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    This is the Staff entry page.
        <p>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff Id"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="45px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblRole" runat="server" Text="Role" width="45px"></asp:Label>
            <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmploymentDate" runat="server" Text="Employment Date" width="45px"></asp:Label>
            <asp:TextBox ID="txtEmploymentDate" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="45px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="ChkActive" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
