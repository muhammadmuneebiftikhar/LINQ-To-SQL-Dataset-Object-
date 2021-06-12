<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqToObject.aspx.cs" Inherits="Linq_to_Object.LinqToObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox ID="FootballTeamName" runat="server" placeholder="FootballTeamName"></asp:TextBox>
            <br />
            <asp:TextBox ID="Manager" runat="server" placeholder="Manager"></asp:TextBox>
            <br />
            <asp:TextBox ID="TeamCaptain" runat="server" placeholder="TeamCaptain"></asp:TextBox>
            <br />
            <asp:TextBox ID="ChampionshipWons" runat="server" placeholder="ChampionshipWons"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
