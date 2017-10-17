<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ValorarReceta.aspx.cs" Inherits="ValorarReceta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="LabelValorarReceta" runat="server" Font-Bold="True" 
        Font-Italic="True" Font-Size="Large" ForeColor="#993333" 
        Text="Selecciona la receta a Valorar"></asp:Label>
    <asp:GridView ID="GridView1_ValorarReceta" runat="server" DataSourceID="SqlDataSource2" 
        AutoGenerateColumns="False" BorderStyle="Dotted">
        <Columns>
         
             <asp:HyperLinkField DataNavigateUrlFields="Id_Receta" 
                DataNavigateUrlFormatString="HiloValorarReceta.aspx?Id_Receta={0}" 
                HeaderText="Nombre" DataTextField="Nombre">
            <HeaderStyle BackColor="#FFCC66" ForeColor="Black" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" 
                SortExpression="Categoria" />
            <asp:BoundField DataField="Formulario" HeaderText="Formulario" 
                SortExpression="Formulario" />
            <asp:BoundField DataField="Imagen" HeaderText="Imagen" 
                SortExpression="Imagen" />
            <asp:BoundField DataField="Id_Receta" HeaderText="Id_Receta" 
                SortExpression="Id_Receta" Visible="False" />
        </Columns>
        <HeaderStyle BackColor="#FF9933" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
        SelectCommand="SELECT Receta.Id_Receta, Receta.Nombre, Receta.Categoria, Receta.Formulario, Receta.Imagen FROM Receta INNER JOIN Receta_Confirmada ON Receta.Id_Receta = Receta_Confirmada.Id_Receta">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server">
    </asp:AccessDataSource>
</asp:Content>

