<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ingresar administrador.aspx.cs" Inherits="Obligatorio_parte_dos.Ingresar_administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Ingresar administrador</h1>
        <asp:Table runat="server" CssClass="table">
            <asp:TableRow>
                <asp:TableCell>
                    Mail
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtMailReg"></asp:TextBox>
                    <asp:Label ID="lbl1" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Contraseña
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox  type="password" runat="server" ID="txtContraseñaReg"></asp:TextBox>
                    <asp:Label ID="lbl2" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" id="btnReg" runat="server" Text="Registrar" OnClick="btnReg_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" id="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
