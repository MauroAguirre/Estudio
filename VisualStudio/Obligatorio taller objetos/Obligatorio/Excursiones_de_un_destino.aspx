<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Excursiones_de_un_destino.aspx.cs" Inherits="Obligatorio.Excursiones_de_un_destino" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Excursiones de un destino</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <label>Destinos</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlDestinos" CssClass="table" AutoPostBack="true" OnSelectedIndexChanged="ddlDestinos_SelectedIndexChanged"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Excursiones</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlExcursiones" CssClass="table"></asp:DropDownList>
                <asp:Label runat="server" ID="lblExcursiones" >No hay excursiones con ese destino</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnVolver" CssClass="btn btn-primary" OnClick="btnVolver_Click" Text="Regresar"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
