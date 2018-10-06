<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Eventos de organizador.aspx.cs" Inherits="Obligatorio_parte_dos.Eventos_de_organizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 runat="server" id="hpremium">Lista de eventos premium</h2>
    <asp:Table runat="server" ID="tblPremium" CssClass="table-bordered">
        <asp:TableHeaderRow>
            <asp:TableCell>
                Fecha
            </asp:TableCell>
            <asp:TableCell>
                Descripcion
            </asp:TableCell>
            <asp:TableCell>
                Cliente
            </asp:TableCell>
            <asp:TableCell>
                Asistentes
            </asp:TableCell>
            <asp:TableCell>
                Personas
            </asp:TableCell>
            <asp:TableCell>
                Codigo
            </asp:TableCell>
            <asp:TableCell>
                El turno
            </asp:TableCell>
            <asp:TableCell>
                Aumento
            </asp:TableCell>
            <asp:TableCell>
                Servicios
            </asp:TableCell>
            <asp:TableCell>
                Costo total del evento
            </asp:TableCell>
        </asp:TableHeaderRow>
    </asp:Table>
    <h2 runat="server" id="hNormal">Lista de eventos normales</h2>
    <asp:Table runat="server" ID="tblNormal" CssClass="table-bordered">
        <asp:TableHeaderRow>
            <asp:TableCell>
                Fecha
            </asp:TableCell>
            <asp:TableCell>
                Descripcion
            </asp:TableCell>
            <asp:TableCell>
                Cliente
            </asp:TableCell>
            <asp:TableCell>
                Asistentes
            </asp:TableCell>
            <asp:TableCell>
                Personas
            </asp:TableCell>
            <asp:TableCell>
                Codigo
            </asp:TableCell>
            <asp:TableCell>
                El turno
            </asp:TableCell>
            <asp:TableCell>
                Duracion
            </asp:TableCell>
            <asp:TableCell>
                Servicios
            </asp:TableCell>
            <asp:TableCell>
                Costo total del evento
            </asp:TableCell>
        </asp:TableHeaderRow>
    </asp:Table>
    <asp:Button CssClass="btn btn-danger" runat="server" ID="btnAtras" Text="Regresar" OnClick="btnAtras_Click"/>
</asp:Content>
