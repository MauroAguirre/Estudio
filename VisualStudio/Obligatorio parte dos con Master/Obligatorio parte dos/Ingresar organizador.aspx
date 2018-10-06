<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ingresar organizador.aspx.cs" Inherits="Obligatorio_parte_dos.Ingresar_organizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Ingresar organizador</h1>
        <asp:Table runat="server" CssClass="table">
            <asp:TableRow>
                <asp:TableCell>
                    Mail
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtMail"></asp:TextBox>
                    <asp:Label ID="lbl1" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Contraseña
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox  type="password" runat="server" ID="txtContraseña"></asp:TextBox>
                    <asp:Label ID="lbl2" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Nombre
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Telefono
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtTelefono" type="number"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Direccion
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDireccion"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Fecha
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Type="Date" runat="server" ID="dteFecha"></asp:TextBox>
                    <asp:Label ID="lblFecha" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" id="btnReg" runat="server" Text="Registrar" OnClick="btnReg_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button CssClass="btn btn-danger" id="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
