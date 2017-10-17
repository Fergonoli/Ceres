<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MensajePrivado.aspx.cs" Inherits="MostrarMensajeForo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Destinatario" runat="server" Text="Destinatario"></asp:Label>
    <br />
    <asp:TextBox ID="EscribirDestinatario" runat="server" Width="417px"></asp:TextBox>
    <br />
    <asp:Label ID="LabelNoDestinatario" runat="server" 
        style="font-weight: 700; font-size: large; color: #FF0000" 
        Text="No existe el destinatario" Visible="False"></asp:Label>
    <br />
    Asunto<br />
    <asp:TextBox ID="EscribeAsunto" runat="server" Width="416px"></asp:TextBox>
    <br />
    <asp:Label ID="LabelAsunto" runat="server" style="color: #FF0000" 
        Text="No has introducido un asunto"></asp:Label>
    <br />
    <asp:Label ID="Texto" runat="server" Text="Mensaje"></asp:Label>
    <br />
    <asp:TextBox ID="EscribeMensaje" runat="server" Height="211px" 
        TextMode="MultiLine" Width="496px"></asp:TextBox>
    <br />
    <asp:Label ID="LabelMensaje" runat="server" style="color: #FF0000" 
        Text="No has introducido ningún mensaje"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="EnviarMensajePrivado" runat="server" 
        Text="Enviar Mensaje Privado" onclick="EnviarMensajePrivado_Click" />
    <br />
</asp:Content>

