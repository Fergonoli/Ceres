<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="distribuirAlimento.aspx.cs" Inherits="distribuirAlimento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style2
        {
        }
        .style3
        {
            text-align: left;
        }
        .style7
        {
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="Solicitante"></asp:Label>
        </td>
        <td class="style2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:Label ID="Label2" runat="server" Text="Categoría"></asp:Label>
        </td>
        <td class="style2">
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="categoria" 
                DataValueField="categoria" CausesValidation="True">
                <asp:ListItem>....</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT DISTINCT categoria FROM alimento"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="style2" rowspan="2">
            <asp:Label ID="Alimento" runat="server" Text="Nombre de Alimento"></asp:Label>
        </td>
        <td class="style2" rowspan="2">
            <asp:TextBox ID="TextBox2" runat="server" CausesValidation="True"></asp:TextBox>
        </td>
        <td class="style2" rowspan="2">
            <asp:Label ID="Label4" runat="server" Text="Fecha de Solicitud"></asp:Label>
        </td>
        <td class="style3">
            <asp:Calendar ID="Caducidad" runat="server" Visible="False"></asp:Calendar>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Button ID="Desplegar" runat="server" onclick="Button4_Click" 
                Text="Desplegar Calendario" />
        </td>
    </tr>
</table>
    <br />
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="Button1" runat="server" style="text-align: center" 
                    Text="Buscar" onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="style1">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Noencontrado" runat="server" ForeColor="#CC3300" 
                    style="text-align: left" Text="No se ha encontrado ninguna solicitud" 
                    Visible="False"></asp:Label>
            </td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: right" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" 
                    AutoGenerateColumns="False" DataKeyNames="id_solicitud" 
                    DataSourceID="ObjectDataSource1" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id_solicitud" HeaderText="ID_Solicitud" 
                            ReadOnly="True" SortExpression="id_solicitud" />
                        <asp:BoundField DataField="nombre" HeaderText="Usuario" 
                            SortExpression="nombre" />
                        <asp:BoundField DataField="eMail" HeaderText="eMail" SortExpression="eMail" />
                        <asp:BoundField DataField="telefono" HeaderText="Teléfono" 
                            SortExpression="telefono" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                        <asp:CommandField HeaderText="Selección solicitud" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="Label7" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDatabyBuscar" 
                    TypeName="DataSetCU3TableAdapters.SolicitudTableAdapter">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="categoria" PropertyName="SelectedValue" 
                            Type="String" DefaultValue="-" />
                        <asp:ControlParameter ControlID="TextBox2" Name="nombre" PropertyName="Text" 
                            Type="String" DefaultValue="asdf" />
                        <asp:ControlParameter ControlID="Caducidad" Name="fecha" 
                            PropertyName="SelectedDate" Type="DateTime" DefaultValue="12/12/2022" />
                        <asp:ControlParameter ControlID="TextBox1" Name="solicitante" 
                            PropertyName="Text" Type="String" DefaultValue="asdf" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td rowspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td rowspan="3">
                <br />
                <asp:GridView ID="GridView2" runat="server" 
                    AutoGenerateColumns="False" DataKeyNames="id_lineaSolicitud" 
                    DataSourceID="SqlDataSource2" >
                    <Columns>
                        <asp:BoundField DataField="id_lineaSolicitud" HeaderText="ID" 
                            InsertVisible="False" ReadOnly="True" SortExpression="id_lineaSolicitud" />
                        <asp:BoundField DataField="nombre" HeaderText="Alimento" 
                            SortExpression="nombre" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad solicitada" 
                            SortExpression="cantidad" />
                        <asp:TemplateField HeaderText="Cantidad donada"></asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT linea_solicitud.id_lineaSolicitud, alimento.nombre, linea_solicitud.cantidad FROM linea_solicitud INNER JOIN alimento ON linea_solicitud.id_alimento = alimento.id_alimento INNER JOIN solicitud ON linea_solicitud.id_solicitud = solicitud.id_solicitud WHERE (solicitud.id_solicitud = @id_solcitud)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="Label7" Name="id_solcitud" 
                            PropertyName="Text" DbType="Int64" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <span class="style7">
                <asp:Label ID="Label8" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label11" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label12" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label13" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label14" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label15" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label16" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label17" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label18" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label19" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label20" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label21" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label22" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label23" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label24" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label25" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label26" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label27" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label28" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label29" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label30" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label31" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label32" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label33" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label34" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label35" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label36" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label37" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label38" runat="server" Text="0" Visible="False"></asp:Label>
                <asp:Label ID="Label39" runat="server" Text="0" Visible="False"></asp:Label>
                </span>
            </td>
            <td rowspan="3">
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Marca" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Cantidad" Visible="False"></asp:Label>
            </td>
            <td colspan="2">
                <br />
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource3" 
                    onselectedindexchanged="GridView3_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Producto" 
                            SortExpression="nombre" />
                        <asp:BoundField DataField="fecha_caducidad" HeaderText="Fecha caducidad" 
                            SortExpression="fecha_caducidad" />
                        <asp:BoundField DataField="peso" HeaderText="Cantidad disponible" 
                            SortExpression="peso" />
                        <asp:CommandField HeaderText="Seleccionar producto" ShowSelectButton="True" />
                        <asp:TemplateField HeaderText="Cantidad donada"></asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    
                    
                    
                    
                    SelectCommand="SELECT producto.nombre, producto.fecha_caducidad, producto.peso FROM linea_solicitud INNER JOIN producto ON linea_solicitud.id_alimento = producto.id_alimento WHERE (linea_solicitud.id_lineaSolicitud IN (@l1,@l2,@l3,@l4,@l5,@l6,@l7,@l8,@l9,@l10,@l11,@l12,@l13,@l14,@l15,@l16,@l17,@l18,@l19,@l20,@l21,@l22,@l23,@l24,@l25,@l26,@l27,@l28,@l29,@l30)) ORDER BY linea_solicitud.id_alimento ASC">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="Label8" DefaultValue="0" Name="l1" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label11" DefaultValue="0" Name="l2" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label12" DefaultValue="0" Name="l3" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label13" DefaultValue="0" Name="l4" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label14" DefaultValue="0" Name="l5" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label15" DefaultValue="0" Name="l6" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label16" DefaultValue="0" Name="l7" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label17" DefaultValue="0" Name="l8" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label18" DefaultValue="0" Name="l9" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label19" DefaultValue="0" Name="l10" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label20" DefaultValue="0" Name="l11" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label21" DefaultValue="0" Name="l12" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label22" DefaultValue="0" Name="l13" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label23" DefaultValue="0" Name="l14" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label24" DefaultValue="0" Name="l15" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label25" DefaultValue="0" Name="l16" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label26" DefaultValue="0" Name="l17" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label27" DefaultValue="0" Name="l18" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label28" DefaultValue="0" Name="l19" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label29" DefaultValue="0" Name="l20" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label30" DefaultValue="0" Name="l21" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label31" DefaultValue="0" Name="l22" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label32" DefaultValue="0" Name="l23" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label33" DefaultValue="0" Name="l24" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label34" DefaultValue="0" Name="l25" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label35" DefaultValue="0" Name="l26" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label36" DefaultValue="0" Name="l27" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label37" DefaultValue="0" Name="l28" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label38" DefaultValue="0" Name="l29" 
                            PropertyName="Text" />
                        <asp:ControlParameter ControlID="Label39" DefaultValue="0" Name="l30" 
                            PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <asp:TextBox ID="Cantidad" runat="server" Visible="False" Width="81px" 
                    ValidationGroup="[0-9]">0</asp:TextBox>
                <asp:Button ID="Button2" runat="server" Height="24px" Text="+" Visible="False" 
                    Width="40px" onclick="Button2_Click"/>
                <asp:Button ID="Button3" runat="server" Text="-" Visible="False" Width="40px" onclick="Button3_Click" 
                    />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="Cantidad" 
                    ErrorMessage="Ha de introducir una cantidad válida" 
                    ValidationExpression="[0-9]*.?[0-9]{0,2}" ForeColor="Red"></asp:RegularExpressionValidator>
            &nbsp;<asp:Label ID="Label10" runat="server" style="color: #FF0000" Text="Label" 
                    Visible="False"></asp:Label>
                <br />
                <asp:Button ID="Button5" runat="server"
                    Text="Aceptar cantidad" Visible="False" onclick="Button5_Click" />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Button ID="Button4" runat="server" style="text-align: center" 
                    Text="Rechazar Solicitud" Width="146px"
                    Visible="False" onclick="Button4_Click1" />
            </td>
            <td style="text-align: right">
                <asp:Button ID="aceptar" runat="server" style="text-align: justify" 
                    Text="Aceptar Solicitud" Visible="False" onclick="aceptar_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Label ID="Resultado" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

