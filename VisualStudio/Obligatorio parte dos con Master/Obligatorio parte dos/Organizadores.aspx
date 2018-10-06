<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Organizadores.aspx.cs" Inherits="Obligatorio_parte_dos.Organizadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <div>
        <h1>Organizadores</h1>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Organizar evento premium" ID="btnIngresarEventoPremium" OnClick="btnIngresarEventoPremium_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Organizar evento normal" ID="btnIngresarEventoNormal" OnClick="btnIngresarEventoNormal_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Lista de Eventos" ID="btnListaEventos" OnClick="btnListaEventos_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Salir" ID="btnRegresar" OnClick="btnRegresar_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
