<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQ_to_Dataset.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="auto-style1">
            <asp:TextBox ID="txtDID" runat="server" placeholder="Department ID"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <asp:TextBox ID="txtDName" runat="server" placeholder="Department Name"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtDLocation" runat="server" placeholder="Department Location"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
         <div class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" Width="1015px">
        </asp:GridView>
         </div>
    </form>
</body>
</html>
