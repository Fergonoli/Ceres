<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="subirReceta.aspx.cs" Inherits="subirReceta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            font-size: x-large;
            color: #0066FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="style7">
        <strong>Subir una receta</strong></p>
    <p>
        Rellena el siguiente formulario para añadir una receta a la base de datos:</p>
    <p>
        Nombre&nbsp;
        <asp:TextBox ID="Nombre_receta" runat="server" Width="286px"></asp:TextBox>
    </p>
    <p>
        Categoría&nbsp;&nbsp;
        <asp:DropDownList ID="tipoCategoria" runat="server">
            <asp:ListItem>Desayuno</asp:ListItem>
            <asp:ListItem>Primer plato</asp:ListItem>
            <asp:ListItem>Segundo plato</asp:ListItem>
            <asp:ListItem>Postre</asp:ListItem>
            <asp:ListItem>Cena</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:FileUpload ID="SubidaImagen" runat="server" style="margin-bottom: 0px" />
    </p>
    <p>
        Ingredientes</p>
    <p>
        <asp:TextBox ID="Ingredientes" runat="server" Height="102px" Width="349px" 
            TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        Elaboración</p>
    <p>
        <asp:TextBox ID="Elaboracion" runat="server" Height="178px" Width="347px" 
            EnableViewState="False" Font-Underline="False" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p style="height: 37px">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Subir" />
    </p>
    <asp:Label ID="Texto_Error" runat="server" BackColor="White" 
        BorderColor="Black" Enabled="False" Font-Size="X-Large" ForeColor="Red" 
        Text="Label"></asp:Label>
    <asp:Label ID="Texto_Solucion" runat="server" Enabled="False" 
        Font-Size="X-Large" ForeColor="#33CC33" Text="Label"></asp:Label>
</asp:Content>

