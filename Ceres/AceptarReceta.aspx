<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AceptarReceta.aspx.cs" Inherits="AceptarReceta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style2
        {
            text-align: center;
            color: #6699FF;
            font-size: x-large;
            font-family: Calibri;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="style2">
        <strong>RECETAS A CONFIRMAR</strong></div>
    <br class="style6" />
    <br class="style6" /><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Selecciona las recetas que pretendes confirmar:</span><asp:GridView 
        ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="Id_Receta" DataSourceID="ObjectDataSource1" 
        onrowcommand="GridView1_RowCommand"
        style="margin-left: 47px; margin-top: 34px; text-align: center;" AllowPaging="True" 
        AllowSorting="True" Height="327px" Width="1200px" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" CssClass="style6">
        <Columns>
            <asp:BoundField DataField="Id_Receta" HeaderText="ID" HtmlEncode="False" 
                InsertVisible="False" ReadOnly="True" SortExpression="Id_Receta" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                SortExpression="Nombre" >
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" 
                SortExpression="Categoria" />
            <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias" />
            <asp:BoundField DataField="Formulario" HeaderText="Formulario" 
                SortExpression="Formulario" >
            <FooterStyle Width="400px" />
            <ItemStyle Width="60%" />
            </asp:BoundField>
            <asp:ButtonField Text="Agregar" ButtonType="Button" CommandName="Agregar"/>
            <asp:ButtonField ButtonType="Button" Text="Rechazar" CommandName="Rechazar" />
            <asp:ButtonField ButtonType="Button" Text="Modificar" CommandName="Modificar" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByEstado" 
        TypeName="DataSet1TableAdapters.RecetaTableAdapter">
        <SelectParameters>
            <asp:Parameter DefaultValue="3" Name="estado" Type="Int16" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="style6"></asp:Label>
    <br />
    <br />
        <asp:TextBox ID="Error" runat="server" Height="178px" Width="347px" 
            EnableViewState="False" Font-Underline="False" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Enviar" runat="server" onclick="Button2_Click" 
        Text="Enviar a modificar" />
</asp:Content>

