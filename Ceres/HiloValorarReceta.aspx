<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HiloValorarReceta.aspx.cs" Inherits="HiloValorarReceta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                SortExpression="Nombre" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" 
                SortExpression="Categoria" />
            <asp:BoundField DataField="Formulario" HeaderText="Formulario" 
                SortExpression="Formulario" />
            <asp:BoundField DataField="Imagen" HeaderText="Imagen" 
                SortExpression="Imagen" />
        </Columns>
        <HeaderStyle BackColor="#FFCC66" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
        SelectCommand="SELECT Nombre, Categoria, Formulario, Imagen FROM Receta WHERE (Id_Receta = @Id_Receta)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Id_Receta" QueryStringField="Id_Receta" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:HyperLink ID="HyperLinkVolverARecetas" runat="server" Font-Size="Large" 
        NavigateUrl="~/ValorarReceta.aspx">Lista de Recetas</asp:HyperLink>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="LabelRecetaAValorar" runat="server" Font-Bold="True" 
        Font-Italic="True" Font-Size="X-Large" ForeColor="#993333" 
        Text="Por favor, rellene los siguientes campos para valorar la receta:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Puntuación" Font-Bold="True" 
        Font-Size="Large"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxPuntuacion" runat="server" Height="19px" Width="77px" 
        ontextchanged="TextBoxPuntuacion_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="LabelAdecuacion" runat="server" 
        Text="Debes insertar un valor numérico" Visible="False" 
        ForeColor="#FF5050"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorPuntuacion1" runat="server" 
        Text="Debes insertar una Nota" Visible="False" ForeColor="#FF5050"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorPuntuacion" runat="server" 
        Text="La Nota debe estar entre 1 y 10" Visible="False" ForeColor="#FF5050"></asp:Label>
    <br />
    <asp:Label ID="LabelComentario" runat="server" Text="Comentario" 
        Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxComentario" runat="server" Height="99px" Width="455px" 
        ontextchanged="TextBox4_TextChanged" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonValorar" runat="server" Text="Valorar" 
        onclick="ButtonValorar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelMensaje" runat="server" 
        Text="Valoración creada correctamente" Visible="False" Font-Bold="True" 
        Font-Size="Large" ForeColor="#CC6600"></asp:Label>
</asp:Content>

