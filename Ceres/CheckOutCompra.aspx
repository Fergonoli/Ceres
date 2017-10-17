<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CheckOutCompra.aspx.cs" Inherits="CheckOutCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
    
        
        SelectCommand="SELECT [Linea Pedido].[Numero de linea], Producto.Nombre, [Linea Pedido].Cantidad, Producto.Precio FROM [Linea Pedido] INNER JOIN Pedido ON [Linea Pedido].[Numero pedido] = Pedido.[Numero Pedido] INNER JOIN Producto ON [Linea Pedido].[Id Producto] = Producto.[Id Producto] INNER JOIN Usuario ON Pedido.[Id usuario] = Usuario.Id_Usuario WHERE (Usuario.Alias = @Alias)">
    <SelectParameters>
        <asp:CookieParameter CookieName="UserName" Name="Alias" />
    </SelectParameters>
</asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
        AutoGenerateColumns="False" DataKeyNames="Numero de linea" 
        AllowPaging="True" onselectedindexchanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Numero de linea" HeaderText="Numero de linea" 
            ReadOnly="True" SortExpression="Numero de linea" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
            SortExpression="Nombre" />
        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" 
            SortExpression="Cantidad" />
        <asp:BoundField DataField="Precio" HeaderText="Precio" 
            SortExpression="Precio" />
        <asp:ButtonField CommandName="borrar" Text="borrar" />
    </Columns>
</asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
    <asp:Label ID="LabelConfirma" runat="server" 
        Text="Su pedido se ha procesado correctamente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="ButtonConfirmacion" runat="server" Text="Confirmar Compra" 
        onclick="ButtonConfirmacion_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
</asp:Content>

