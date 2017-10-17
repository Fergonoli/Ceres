<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="verCatalogo.aspx.cs" Inherits="verCatalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
            SelectCommand="SELECT Nombre, Imagen, Precio, Stock, [Id Producto] FROM Producto WHERE (Stock &gt; 0)">
        </asp:SqlDataSource>
    </p>
    <p>
        Catálogo de productos</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            DataKeyNames="Id Producto" DataSourceID="SqlDataSource1" ForeColor="Black" 
            GridLines="Vertical" onselectedindexchanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="Imagen" HeaderText="Imagen" 
                    SortExpression="Imagen" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" 
                    SortExpression="Precio" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                <asp:HyperLinkField 
                    Text="Acceder" DataNavigateUrlFields="Id Producto" 
                    DataNavigateUrlFormatString="~/DetallesProducto.aspx?id={0}" />
                <asp:BoundField DataField="Id Producto" HeaderText="Id Producto" 
                    ReadOnly="True" SortExpression="Id Producto" Visible="False" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/imagenes/carrito.png" 
            NavigateUrl="~/CheckOutCompra.aspx">Ver Carrito</asp:HyperLink>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

