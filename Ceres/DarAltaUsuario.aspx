<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DarAltaUsuario.aspx.cs" Inherits="DarAltaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Bienvenida" runat="server" 
    Text="Siga los pasos para darse de alta"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<br />
    <br />
    <table class="style9">
        <tr>
            <td>
<asp:Label ID="Nombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextNombre" runat="server"></asp:TextBox>
<asp:Label ID="Error_Nombre" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="ApellidoPrimero" runat="server" Text="Primer Apellido"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextApellido1" runat="server"></asp:TextBox>
<asp:Label ID="Error_PrimerApellido" runat="server" Text="Label" ForeColor="Red" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="ApellidoSegundo" runat="server" Text="Segundo Apellido"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextApellido2" runat="server"></asp:TextBox>
<asp:Label ID="Error_ApellidoSegundo" runat="server" Text="Label" ForeColor="Red" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="FechaNacimiento" runat="server" 
    Text="Fecha de Nacimiento(dd/mm/yyyy)"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextFechaNamicimiento" runat="server"></asp:TextBox>
<asp:Label ID="Error_Nacimiento" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="TextFechaNamicimiento" ErrorMessage="Introduce una fecha" 
                    ForeColor="Red" 
                    ValidationExpression="(0?[1-9]|[12][0-9]|3[01])\/(0?[1-9]|1[012])\/[0-9]{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="Alias" runat="server" Text="Alias"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextAlias" runat="server"></asp:TextBox>
<asp:Label ID="Error_Alias" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="Contraseña" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextContraseña" runat="server"></asp:TextBox>
<asp:Label ID="Error_Contraseña" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
<asp:Label ID="ReContraseña" runat="server" Text="Repite Contraseña"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextReContraseña" runat="server"></asp:TextBox>
<asp:Label ID="Error_ReContraseña" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="Celiaco" runat="server" Text="¿Eres celiaco?" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
<asp:Label ID="CorreoElectronico" runat="server" Text="Correo Electronico"></asp:Label>
            </td>
            <td>
<asp:TextBox ID="TextCorreoElectronico" runat="server"></asp:TextBox>
<asp:Label ID="Error_CorreoElectronico" runat="server" Text="Label" ForeColor="Red" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />

<asp:Label ID="MensajeDePrivilegios" runat="server" 
    Text="Introduce el tipo de privilegio que desea que se le apliquen "></asp:Label>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="Usuario" runat="server" AutoPostBack="True" 
    oncheckedchanged="Usuario_CheckedChanged" Text="Usuario" />
<asp:CheckBox ID="Restaurante" runat="server" AutoPostBack="True" 
    oncheckedchanged="Restaurante_CheckedChanged" Text="Restaurante" />
<asp:CheckBox ID="Especialista" runat="server" AutoPostBack="True" 
    oncheckedchanged="Especialista_CheckedChanged" Text="Especialista" />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Direccion" runat="server" Text="Direccion"></asp:Label>
&nbsp;&nbsp;
<asp:TextBox ID="TextDireccion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Precio" runat="server" Text="Precio medio menu"></asp:Label>
&nbsp;&nbsp;
<asp:TextBox ID="TextPrecio" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TextPrecio" ErrorMessage="No es un precio " ForeColor="Red" 
        ValidationExpression="[0-9][0-9]*(.[0-9][0-9])?"></asp:RegularExpressionValidator>
<br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="N_Colegiado" runat="server" Text="N_Colegiado"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextN_Colegiado" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="TextN_Colegiado" 
        ErrorMessage="No es un numero de colegiado valido" ForeColor="Red" 
        ValidationExpression="[0-9][0-9]*"></asp:RegularExpressionValidator>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="ErrorPrivilegios" runat="server" Text="Label" ForeColor="Red" 
        Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Registrar" runat="server" onclick="Registrar_Click" 
    Text="Registrarse" />
<br />
&nbsp;
</asp:Content>

