<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DarAltaProducto.aspx.cs" Inherits="DarAltaProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label_Introduccion_Identificador" runat="server" 
        Text="Introduce el identificador del producto"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label_IdProducto" runat="server" Text="Codigo de barras"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Id_Producto" runat="server" ></asp:TextBox>
    <asp:Button ID="Comprobar" runat="server" onclick="Comprobar_Click" 
        Text="Comprobar" />
    <br />
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="TextBox_Id_Producto" 
        ErrorMessage="El código de barras debe ser de 8 digitos" ForeColor="Red" 
        ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
    &nbsp;
    <asp:Label ID="ErrorCodigo" runat="server" ForeColor="Red" 
        Text="El campo código está vacío" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label_Introduccion_Formulario" runat="server" 
        Text="Introduzca los datos del producto"></asp:Label>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label_Imagen_Producto" runat="server" Text="Ruta de la Imagen"></asp:Label>
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label_Nombre_Producto" runat="server" Text="Nombre Producto"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Nombre_Producto" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label_Error_Nombre_Producto" runat="server" ForeColor="Red" 
        Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload_Imagen_Producto" runat="server" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label_Error_Imagen" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label_Descripcion_producto" runat="server" Text="Descripcion"></asp:Label>
    <br />
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Descripcion_Producto" runat="server" Height="204px" 
        Width="552px" TextMode="MultiLine"></asp:TextBox>
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label_Error_Descripcion" runat="server" ForeColor="Red" 
        Text="Label"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label_Stock" runat="server" Text="Stock"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Stock" runat="server"></asp:TextBox>
    <asp:Label ID="Label_Error_Stock" runat="server" ForeColor="Red" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label_Precio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="TextBox_Precio" runat="server"></asp:TextBox>
    <asp:Label ID="Label_Error_Precio" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RegularExpressionValidator 
        ID="RegularExpressionValidator3" runat="server" 
        ControlToValidate="TextBox_Stock" ErrorMessage="Stock no válido" 
        ForeColor="Red" ValidationExpression="[1-9][0-9]*"></asp:RegularExpressionValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TextBox_Precio" ErrorMessage="Precio no valido" 
        ForeColor="Red" ValidationExpression="[0-9]?[0-9]?[0-9],[0-9][0-9]"></asp:RegularExpressionValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label_Nombre_Proveedor" runat="server" 
        Text="Nombre del Proveedor"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Nombre_Proveedor" runat="server"></asp:TextBox>
    <asp:Label ID="Label_Error_Proveedor" runat="server" ForeColor="Red" 
        Text="Label"></asp:Label>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button_Añadir" runat="server" Text="Añadir" 
        onclick="Button_Añadir_Click" />
    <br />
    <br />
</asp:Content>

