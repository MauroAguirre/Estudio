<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Obligatorio_parte_dos.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Estilos.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Eventos 2017</h1>
        <div runat="server" id="MenuPrincipal">
            <h2>Inicio</h2>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        Mail
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="Mail"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="pedro" runat="server" ControlToValidate="Mail" ErrorMessage="Mal"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Contraseña
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox  runat="server" ID="Contraseña"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="dos" runat="server" ControlToValidate="Contraseña" ValidationExpression="^[1-9]+$" ErrorMessage="numeritos"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button runat="server" Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click"/>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button runat="server" Text="Registrar" ID="btnRegistrar" OnClick="btnRegistrar_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
