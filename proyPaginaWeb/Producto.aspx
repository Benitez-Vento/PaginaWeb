<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="proyPaginaWeb.Producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmProducto" runat="server">
        <asp:Label ID="etiBuscar" runat="server" Text="Buscar"></asp:Label>
        <asp:TextBox ID="txtValorBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

        <asp:GridView ID="gvProductos" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="CODIGO" />
                <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                <asp:BoundField DataField="categoria" HeaderText="CATEGORIA" />
                <asp:BoundField DataField="precio" HeaderText="PRECIO S/." />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
