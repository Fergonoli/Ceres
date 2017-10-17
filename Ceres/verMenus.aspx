<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="verMenus.aspx.cs" Inherits="verMenus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            color: #3366FF;
            font-size: x-large;
            font-family: Calibri;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="style9">
        <strong>Visualización de Menús</strong></p>
    <p>
        <asp:SqlDataSource ID="SqlMenus" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT        Menu.Fecha_creacion, Menu.Id_Menu, Receta_1.Nombre AS Expr1, Receta_2.Nombre AS Expr2, Receta_3.Nombre AS Expr3, Receta_4.Nombre AS Expr4, 
                         Receta_5.Nombre AS Expr5, Receta_6.Nombre AS Expr6, Usuario.Alias
FROM            Menu INNER JOIN
                         Usuario ON Menu.Id_Usuario_Creador = Usuario.Id_Usuario INNER JOIN
                         Receta AS Receta_1 ON Menu.idReceta1 = Receta_1.Id_Receta INNER JOIN
                         Receta AS Receta_2 ON Menu.idReceta2 = Receta_2.Id_Receta INNER JOIN
                         Receta AS Receta_3 ON Menu.idReceta3 = Receta_3.Id_Receta INNER JOIN
                         Receta AS Receta_4 ON Menu.idReceta4 = Receta_4.Id_Receta INNER JOIN
                         Receta AS Receta_5 ON Menu.idReceta5 = Receta_5.Id_Receta INNER JOIN
                         Receta AS Receta_6 ON Menu.idReceta6 = Receta_6.Id_Receta
WHERE Usuario.Alias=@Alias">
            <SelectParameters>
                <asp:CookieParameter CookieName="UserName" Name="Alias" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="Id_Menu" DataSourceID="SqlMenus" 
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Fecha_creacion" HeaderText="Fecha de creación" 
                    SortExpression="Fecha_creacion" />
                <asp:BoundField DataField="Id_Menu" HeaderText="Menú" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id_Menu" />
                <asp:BoundField DataField="Expr1" HeaderText="Desayuno" 
                    SortExpression="Expr1" />
                <asp:BoundField DataField="Expr2" HeaderText="1er plato comida" 
                    SortExpression="Expr2" />
                <asp:BoundField DataField="Expr3" HeaderText="2º plato comida" 
                    SortExpression="Expr3" />
                <asp:BoundField DataField="Expr4" HeaderText="Postre comida" 
                    SortExpression="Expr4" />
                <asp:BoundField DataField="Expr5" HeaderText="Cena" 
                    SortExpression="Expr5" />
                <asp:BoundField DataField="Expr6" HeaderText="Postre cena" 
                    SortExpression="Expr6" />
                <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Volver a inicio" />
    </p>
</asp:Content>

