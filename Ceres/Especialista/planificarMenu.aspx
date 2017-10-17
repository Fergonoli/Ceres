<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="planificarMenu.aspx.cs" Inherits="planificarMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        font-family: Calibri;
        color: #3333CC;
        font-size: larger;
    }
    .style6
    {
        font-size: medium;
        font-family: Calibri;
    }
    .style7
    {
        font-family: Calibri;
    }
    .style8
    {
        font-family: Calibri;
        color: #3333CC;
        font-size: x-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="style8">
        <strong>Planificar menú</strong></p>
    <p class="style6">
        Elige el desayuno:<asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
    </p>
    <p>
        <asp:SqlDataSource ID="datosDesayuno" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT Receta_Confirmada.Id_Receta, Receta.Nombre 
FROM Receta_Confirmada INNER JOIN Receta ON Receta_Confirmada.Id_Receta = Receta.Id_Receta
WHERE (Receta.Categoria = 'Desayuno')"></asp:SqlDataSource>
        <asp:GridView ID="tablaDesayuno" runat="server" AutoGenerateColumns="False" 
            DataSourceID="datosDesayuno" onrowcommand="tablaDesayuno_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" CssClass="style4" 
            CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" 
            style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaDesayuno" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        </p>
    <p class="style4">
        &nbsp;</p>
    <span class="style4"><span class="style7">Elige el primer plato de la comida:</span><asp:Label 
        ID="Label2" runat="server" Text="Label2"></asp:Label>
    <br />
    </span>
        <asp:SqlDataSource ID="datosPlato1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT Receta_Confirmada.Id_Receta, Receta.Nombre 
FROM Receta_Confirmada INNER JOIN Receta ON Receta_Confirmada.Id_Receta = Receta.Id_Receta
WHERE (Receta.Categoria = 'Primer plato')"></asp:SqlDataSource>
        <asp:GridView ID="tablaPlato1" runat="server" AutoGenerateColumns="False" 
            datasourceid="datosPlato1" onrowcommand="tablaPlato1_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
        CssClass="style4" CellPadding="4" ForeColor="#333333" GridLines="None" 
    AllowSorting="True" style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaPlato1" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
    <br />
    <span class="style4"><span class="style7">Elige el segundo plato de la comida:</span><asp:Label 
        ID="Label3" runat="server" Text="Label3"></asp:Label>
    <br />
    </span>
        <asp:SqlDataSource ID="datosPlato2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT Receta_Confirmada.Id_Receta, Receta.Nombre 
FROM Receta_Confirmada INNER JOIN Receta ON Receta_Confirmada.Id_Receta = Receta.Id_Receta
WHERE (Receta.Categoria = 'Segundo plato')"></asp:SqlDataSource>
        <asp:GridView ID="tablaPlato2" runat="server" AutoGenerateColumns="False" 
            datasourceid="datosPlato2" onrowcommand="tablaPlato2_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
        CssClass="style4" CellPadding="4" ForeColor="#333333" GridLines="None" 
    AllowSorting="True" style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaPlato2" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <span class="style4"><span class="style7">Elige el postre de la comida:<asp:Label 
        ID="Label4" runat="server" Text="Label4"></asp:Label>
    <br />
</span>
    </span>
        <asp:SqlDataSource ID="datosPostre1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT Receta_Confirmada.Id_Receta, Receta.Nombre 
FROM Receta_Confirmada INNER JOIN Receta ON Receta_Confirmada.Id_Receta = Receta.Id_Receta
WHERE (Receta.Categoria = 'Postre')"></asp:SqlDataSource>
        <asp:GridView ID="tablaPostre1" runat="server" AutoGenerateColumns="False" 
            datasourceid="datosPostre1" onrowcommand="tablaPostre1_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
        CssClass="style4" CellPadding="4" ForeColor="#333333" GridLines="None" 
    AllowSorting="True" style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaPostre1" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <span class="style4"><span class="style7">Elige el plato de la cena:</span><asp:Label 
        ID="Label5" runat="server" Text="Label5"></asp:Label>
    <br />
</span><br />
        <asp:SqlDataSource ID="datosPlato3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT Receta_Confirmada.Id_Receta, Receta.Nombre 
FROM Receta_Confirmada INNER JOIN Receta ON Receta_Confirmada.Id_Receta = Receta.Id_Receta
WHERE (Receta.Categoria = 'Cena')"></asp:SqlDataSource>
        <asp:GridView ID="tablaPlato3" runat="server" AutoGenerateColumns="False" 
            datasourceid="datosPlato3" onrowcommand="tablaPlato3_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
        CssClass="style4" CellPadding="4" ForeColor="#333333" GridLines="None" 
    AllowSorting="True" style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaPlato3" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <span class="style4"><span class="style7">Elige el postre de la cena:</span><asp:Label 
        ID="Label6" runat="server" Text="Label6"></asp:Label>
    <br />
</span>
    <asp:Label ID="Label7" runat="server" Text="Label7"></asp:Label>
    <asp:Label ID="Label8" runat="server" Text="Label8"></asp:Label>
    <br />
        <asp:GridView ID="tablaPostre2" runat="server" AutoGenerateColumns="False" 
            datasourceid="datosPostre1" onrowcommand="tablaPostre2_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
        CssClass="style4" CellPadding="4" ForeColor="#333333" GridLines="None" 
    AllowSorting="True" style="font-family: Calibri">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id_Receta" HeaderText="Código" 
                    SortExpression="Id_Receta" />
                <asp:BoundField DataField="Nombre" HeaderText="Receta" 
                    SortExpression="Nombre" />
                <asp:ButtonField ButtonType="Button" CommandName="insertaPostre2" 
                    Text="Agregar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <p>
        <asp:Button ID="subirMenu" runat="server" onclick="subirMenu_Click" 
            Text="Subir Menú" />
    
    </p>
</asp:Content>

