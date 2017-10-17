<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EnviarMensajeForo.aspx.cs" Inherits="EnviarMensajeForo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: Calibri; color: #0066FF; font-size: x-large">
        <strong>Enviar un mensaje al foro</strong></p>
    <p style="font-family: Calibri; color: #000000; font-size: medium">
        Tema:</p>
    <p style="font-family: Calibri; color: #000000; font-size: medium">
        <asp:TextBox ID="TextBox3" runat="server" Width="532px" 
            ontextchanged="TextBox3_TextChanged"></asp:TextBox>
    </p>
    <p style="font-family: Calibri; color: #000000; font-size: medium">
        Escribe tu mensaje:</p>
    <p style="font-family: Calibri; color: #000000; font-size: medium">
        <asp:TextBox ID="Mensaje" runat="server" Height="178px" Width="601px" 
            EnableViewState="False" Font-Underline="False" TextMode="MultiLine" 
            ontextchanged="Mensaje_TextChanged"></asp:TextBox>
    </p>
    <p style="font-family: Calibri; color: #000000; font-size: medium">
        <asp:Button ID="Button2" runat="server" Text="Enviar" onclick="Button2_Click" />
    </p>
</asp:Content>

