<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Alta_de_contrato.aspx.cs" Inherits="Obligatorio.Alta_de_contrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Alta de contrato</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <label>Cliente</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlClientes"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Excursion</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlExcursiones"></asp:DropDownList>
                <asp:Label runat="server" ID="lblDisponible">No existen excursiones disponibles</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-primary" ID="btnAgregar" OnClick="btnAgregar_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Regresar" CssClass="btn btn-primary" ID="btnRegresar" OnClick="btnRegresar_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
