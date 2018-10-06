<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ingresar evento normal.aspx.cs" Inherits="Obligatorio_parte_dos.Ingresar_evento_normal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Descripcion</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="txtDescripcion"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Cliente</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="txtCliente"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Asistentes</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" ID="numAsistentes"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Personas</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" ID="numPersonas"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">duracion</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" ID="numDuracion"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Turno</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" ID="ddlTurno" CssClass="form-control"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Fecha</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="date" ID="dteFecha"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button CssClass="btn btn-danger" id="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button CssClass="btn btn-danger" id="Regresar" runat="server" Text="Regresar" OnClick="Regresar_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <h2>Servicios disponibles</h2>
    <asp:Table runat="server" ID="tblServiciosDisponibles" CssClass="table-bordered">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Costo por persona</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Nombre</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Cantidad</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnAgregarBebidas" Text="Agregar" OnClick="btnAgregarBebidas_Click" CssClass="btn btn-danger"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">40</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Bebida</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" type="number" ID="numBebidas"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnAgregarComidas" Text="Agregar" OnClick="btnAgregarComidas_Click" CssClass="btn btn-danger"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">100</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Comida</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" type="number" ID="numComidas"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" ID="btnAgregarSonido" OnClick="btnAgregarSonido_Click" CssClass="btn btn-danger"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">70</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server">Musica</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" type="number" ID="numSonido" ></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <h2>Servicios elegidos</h2>
    <asp:GridView runat="server" ID="gvwServiciosElegidos" AutoGenerateDeleteButton="true" OnRowDeleting="gvwServiciosElegidos_RowDeleting" >
    </asp:GridView>
</asp:Content>
