<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Administradores.aspx.cs" Inherits="Obligatorio_parte_dos.Administradores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Administradores</h1>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" ID="btnIngresarAdministrador" runat="server" Text="Ingresar Administrador" OnClick="btnIngresarAdministrador_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Ingresar Organizador" OnClick="Unnamed_Click1"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" runat="server" Text="Lista usuarios" OnClick="Unnamed_Click"/>
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
