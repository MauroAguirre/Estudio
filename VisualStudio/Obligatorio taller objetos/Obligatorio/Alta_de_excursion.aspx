<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Alta_de_excursion.aspx.cs" Inherits="Obligatorio.Alta_de_excursion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Alta de excursion</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableCell>
                <label>Codigo</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigo"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Descripcion</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtDescripcion"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Fecha de comienzo</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" CssClass="form-control" Type="date" ID="dteFecha"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Dias de traslado</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numDiasTraslado"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Maximo de pasajeros</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numMaximoPasajeros"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Costo de los dias de traslado</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numCostoDiasTraslado"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Eliga el tipo de excursion</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlTipoExcursion" OnSelectedIndexChanged="ddlTipoExcursion_SelectedIndexChanged" AutoPostBack="true" >
                    <asp:ListItem text="nacional"></asp:ListItem>
                    <asp:ListItem Text="internacional"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="trwDescuento">
            <asp:TableCell>
                <label>Descuento</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numDescuento"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" text="Agregar excursion" ID="btnAgregarExcursion" OnClick="btnAgregarExcursion_Click" CssClass="btn btn-primary"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" text="Regresar" ID="btnRegresar" OnClick="btnRegresar_Click" CssClass="btn btn-primary"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblRespuesta"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <h2>Destinos para elegir</h2>
    <asp:Table runat="server" CssClass="table">
        <asp:TableHeaderRow>
            <asp:TableCell>
                <label>Lugar</label>
            </asp:TableCell>
            <asp:TableCell>
                <label>Dias de estadia</label>
            </asp:TableCell>
            <asp:TableCell>
                <label>Seleccion</label>
            </asp:TableCell>
            <asp:TableCell>
                <label>Eliminar</label>
            </asp:TableCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Canelones</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numCanelonesDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarCanelones" OnClick="btnAgregarCanelones_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarCanelones" OnClick="btnEliminarCanelones_Click"/>
            </asp:TableCell> 
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Cancun</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numCancunDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarCancun" OnClick="btnAgregarCancun_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarCancun" OnClick="btnEliminarCancun_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Baticano</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numBaticanoDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarBaticano" OnClick="btnAgregarBaticano_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarBaticano" OnClick="btnEliminarBaticano_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Bs. As.</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numBsAsDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarBsAs" OnClick="btnAgregarBsAs_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarBsAs" OnClick="btnEliminarBsAs_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>Bahia</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numBahiaDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarBahia" OnClick="btnAgregarBahia_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarBahia" OnClick="btnEliminarBahia_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <label>San Carlos</label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" Type="number" CssClass="form-control" ID="numSanCarlosDias"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Agregar" CssClass="btn btn-info" ID="btnAgregarSanCarlos" OnClick="btnAgregarSanCarlos_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" ID="btnEliminarSanCarlos" OnClick="btnEliminarSanCarlos_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <h2>Destinos elegidos</h2>
    <asp:GridView runat="server" ID="gvwDestinosElegidos" CssClass="table">
    </asp:GridView>
</asp:Content>
