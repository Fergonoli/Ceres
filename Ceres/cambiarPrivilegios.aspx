<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cambiarPrivilegios.aspx.cs" Inherits="cambiarPrivilegios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span class="style5">
<p>
        Cambiar privilegios a:</span></p>
<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
    style="font-size: medium">
    <asp:ListItem>Usuario</asp:ListItem>
    <asp:ListItem>Restaurante</asp:ListItem>
    <asp:ListItem>Especialista</asp:ListItem>
    <asp:ListItem>Administrador</asp:ListItem>
</asp:RadioButtonList>
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Aceptar" 
    CssClass="style5" />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
<br class="style5" />
<asp:TextBox ID="NumColegiado" runat="server" CssClass="style5"></asp:TextBox>
    <asp:RegularExpressionValidator ID="ValidadorNColegiado" runat="server" 
        ControlToValidate="NumColegiado" ErrorMessage="Número de colegiado no válido" 
        style="color: #FF0000" ValidationExpression="[0-9][0-9]*"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
<asp:TextBox ID="DirRestaurante" runat="server" CssClass="style5"></asp:TextBox>
    <asp:RegularExpressionValidator ID="ValidadorDirRestaurante" runat="server" 
        ControlToValidate="DirRestaurante" ErrorMessage="Dirección no válida" 
        style="color: #FF0000" 
        ValidationExpression="[a-zA-ZñÑÁ-Úá-ú ][a-zA-ZnÑÁ-Úá-ú ]*, [0-9][0-9]*"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
<asp:TextBox ID="PrecioRestaurante" runat="server" CssClass="style5"></asp:TextBox>
    <asp:RegularExpressionValidator ID="ValidadorPrecioRestaurante0" runat="server" 
        ControlToValidate="PrecioRestaurante" ErrorMessage="El precio no es correcto" 
        style="color: #FF0000" ValidationExpression="[0-9][0-9]*.[0-9][0-9]"></asp:RegularExpressionValidator>
    <br />
<p>
    <asp:Label ID="Label1" runat="server" CssClass="style5"></asp:Label>
</p>
</asp:Content>

