<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ranking_pasajeros.aspx.cs" Inherits="Obligatorio.Ranking_pasajeros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ranking de pasajeros</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlPasajeros" CssClass="form-control"></asp:DropDownList>
                <asp:Label runat="server" ID="lblRespuesta">No hay pasajeros en el ranking</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnRegresar" Text="Regresar" CssClass="btn btn-primary" OnClick="btnRegresar_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
