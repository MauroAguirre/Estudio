<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Excursiones_por_fecha.aspx.cs" Inherits="Obligatorio.Excursiones_por_fecha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Excursiones por fecha</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="dte1" Type="date" CssClass="form-control"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="dte2" Type="date" CssClass="form-control"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblExcursiones">No hay Excursiones</asp:Label>
                <asp:DropDownList runat="server" ID="ddlExcursiones" CssClass="table"></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Buscar" ID="btnBuscar" OnClick="btnBuscar_Click" CssClass="btn btn-primary"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Regresar" ID="btnRegresar" OnClick="btnRegresar_Click" CssClass="btn btn-primary"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
