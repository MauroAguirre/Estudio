<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Obligatorio.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Inicio</h2>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Alta de excursion" CssClass="btn btn-primary" OnClick="AltaExcursion"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Alta de contrato" CssClass="btn btn-primary" OnClick="AltaContrato"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Excursiones por destino" CssClass="btn btn-primary" OnClick="ExcursionesDeDestino"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Excursiones contratadas por fecha" CssClass="btn btn-primary" OnClick="ExcursionesPorFecha"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Ranking de pasajeros" CssClass="btn btn-primary" OnClick="Ranking"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
