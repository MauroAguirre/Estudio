<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Lista de usuarios.aspx.cs" Inherits="Obligatorio_parte_dos.Lista_de_usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="btnListaRegresar" runat="server" CssClass="btn btn-danger" Text="Regresar" OnClick="btnListaRegresar_Click"/>
        <h2>Lista de administradores</h2>
        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlAdministradores"></asp:DropDownList>
        <h2>Lista de organizadores</h2>
        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlOrganizadores"></asp:DropDownList>
    </div>
</asp:Content>
