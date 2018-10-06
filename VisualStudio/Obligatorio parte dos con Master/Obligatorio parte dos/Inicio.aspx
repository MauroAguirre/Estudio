<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Obligatorio_parte_dos.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" id="MenuPrincipal">
        <h2>Inicio</h2>
        <asp:Table runat="server" CssClass="table">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server">Mail</asp:Label> 
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtMailLog"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server">Contraseña</asp:Label> 
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox CssClass="form-control" type="password" runat="server" ID="txtContraseñaLog"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" id="btnLog" runat="server" Text="Logiar" OnClick="btnLog_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
