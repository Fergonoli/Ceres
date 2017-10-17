<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="aceptarCambio.aspx.cs" Inherits="aceptarCambio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="cambioAceptado" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Volver al inicio</asp:HyperLink>
    </p>
</asp:Content>

