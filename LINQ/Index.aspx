 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LINQ.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server" placeholder="Name"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPhone" runat="server" placeholder="Phone"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCnic" runat="server" placeholder="Cnic"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
