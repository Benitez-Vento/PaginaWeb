<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proyPaginaWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Calculadora</h1>
    <form id="frmCalculadora" runat="server">
        <asp:TextBox ID="txtNum1" runat="server" Width="80px"></asp:TextBox>
        <asp:DropDownList ID="lstOperador" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>x</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtNum2" runat="server" Width="80px"></asp:TextBox>
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
        <asp:TextBox ID="txtResultado" runat="server" Width="80px"></asp:TextBox>
    </form>
    <h3>By M.Garcia</h3>
</body>
</html>
