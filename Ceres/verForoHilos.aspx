<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="verForoHilos.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .nuevoEstilo1
        {
            border-style: double;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
        AutoGenerateColumns="False" CssClass="nuevoEstilo1">
        <Columns>
            <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias" >
            <HeaderStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Black" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="Id_Hilo" 
                DataNavigateUrlFormatString="verHilo.aspx?hilo={0}" DataTextField="Asunto" 
                Text="Hilo" HeaderText="Tema" >
            <HeaderStyle BackColor="#FFCC66" ForeColor="Black" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                SortExpression="Fecha" >
            <HeaderStyle BackColor="#FFCC66" ForeColor="Black" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="Id_Hilo" HeaderText="Id_Hilo" 
                SortExpression="Id_Hilo" Visible="False" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
        
    
        
        
        
        SelectCommand="SELECT Usuario.Alias, MensajeForo.Asunto, MensajeForo.Fecha, MensajeForo.Id_Hilo FROM Usuario INNER JOIN MensajeForo ON Usuario.Id_Usuario = MensajeForo.Id_Envia WHERE (MensajeForo.Id_Mensaje_Foro IN (SELECT MIN(Id_Mensaje_Foro) AS Expr1 FROM MensajeForo AS MensajeForo_1 GROUP BY Id_Hilo))"></asp:SqlDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
    SelectMethod="GetDataTablaHilo" 
    TypeName="DataSet1TableAdapters.HilosTableAdapter">
        <InsertParameters>
            <asp:Parameter Name="id_hilo" Type="Int32" />
            <asp:Parameter Name="id_mensaje_principal" Type="Int32" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:Panel ID="Panel2" runat="server" Height="208px">
        <asp:Label ID="InstruccionesCrearTema" runat="server" Font-Bold="True" 
        Font-Italic="True" Font-Size="Larger" ForeColor="#CC6600" 
        style="text-align: center" 
        
    Text="Por favor, rellene los siguientes campos si desea crear un nuevo tema:"></asp:Label>
        <br />
        Asunto<br />
        <asp:TextBox ID="Asunto" runat="server" Width="274px" 
            ontextchanged="Asunto_TextChanged"></asp:TextBox>
        <br />
        Texto<br />
        <asp:TextBox ID="Texto" runat="server" Height="109px" TextMode="MultiLine" 
        Width="274px"></asp:TextBox>
        <br />
        <asp:Button ID="Enviar" runat="server" onclick="Enviar_Click" Text="Enviar" />
    </asp:Panel>
</asp:Content>

