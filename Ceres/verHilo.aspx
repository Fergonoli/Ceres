<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="verHilo.aspx.cs" Inherits="verHilo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" >
        
        <Columns>
            <asp:BoundField DataField="Alias" SortExpression="Alias" HeaderText="Alias" >
            <HeaderStyle BackColor="#FFCC66" ForeColor="Black" HorizontalAlign="Center" 
                VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Mensaje">
                <HeaderStyle BackColor="#FFCC66" HorizontalAlign="Center" 
                    VerticalAlign="Middle" />
                <ItemStyle Wrap="True" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
            <asp:BoundField DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha" >
            <HeaderStyle BackColor="#FFCC66" HorizontalAlign="Center" 
                VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" 
        SelectCommand="SELECT Usuario.Alias, MensajeForo.Asunto, MensajeForo.Texto, MensajeForo.Fecha FROM MensajeForo INNER JOIN Usuario ON MensajeForo.Id_Envia = Usuario.Id_Usuario WHERE (MensajeForo.Id_Hilo = @idEntrada)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="" Name="idEntrada" 
                QueryStringField="hilo" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <asp:Panel ID="Panel2" runat="server" Height="250px">
        Rellena los campos para responder a este Tema<br />
        <br />
        Asunto:<br />
        <asp:TextBox ID="Asunto" runat="server" Width="295px"></asp:TextBox>
        <br />
        Texto:<br />
        <asp:TextBox ID="Texto" runat="server" Height="122px" Width="297px" 
        TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Responder" runat="server" onclick="Responder_Click" 
        Text="Responder" />
    </asp:Panel>
    <br />
    <br />
</asp:Content>

