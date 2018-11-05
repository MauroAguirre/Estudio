$(document).ready(function () {
    ListarProveedores();
    ListarArticulosProveedor();
    ListaFacturaCompra();
});
$("#slcProveedores").change(function () {
    ListarArticulosProveedor();
    ResetiarListaEspera();
});
function ListarProveedores() {
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/ListarProveedores',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#slcProveedores").append('<option id=' + proveedores[i].rut + '>' + proveedores[i].nombre + '</option>');
        }
    });
}
function ListarArticulosProveedor() {
    let ArticuloProv = {
        'id': null,
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'articulo': null,
        'costo': null,
        'fecha': null
    };
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/ListarArticulosProveedor',
        data: ArticuloProv,
        encode: true
    }).done((data) => {
        var articulosProv = data.data;
        $("#tbyArticulosProveedor").html("");
        for (i = 0; i < Object.keys(articulosProv).length; i++) {
            $("#tbyArticulosProveedor").append('<tr id=' + articulosProv[i].id + '><td>' + articulosProv[i].articulo.id + " - " + articulosProv[i].articulo.descripcion + '</td><td>' + articulosProv[i].costo + '</td><td><input type="text" id="' + articulosProv[i].id + "_cantidad" + '"/></td><td><input type="button" value="Agregar_Modificar" onclick="Agregar_ModificarListarFacturaEspera(\'' + articulosProv[i].id + '\')")"/></td><td><input type="button" value="Borrar"/></td></tr>');
        }
    });
}
function ResetiarListaEspera()
{
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/ResetiarListaEspera',
        data: null,
        encode: true
    }).done((data) => {
        $("#tbyLineasFacturasParaAgregar").html("");
    });
}
function Agregar_ModificarListarFacturaEspera(artId) {
    let lineaFac = {
        'id': null,
        'cantidad': $("#" + artId + "_cantidad").val(),
        'articuloProveedor': artId,
        'factura': null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuCompra/Agregar_ModificarListarFacturaEspera',
        data: lineaFac,
        encode: true
    }).done((data) => {
        if (data.success) {
            var lineaFac = data.data;
            if (data.modificar) {
                $("#"+lineaFac.articuloProveedor+"fac").html('<td>' + lineaFac.articuloProveedor + '</td><td>' + lineaFac.cantidad + '</td>');
                $("#lblRes").html("Linea de factura modificada");
            }
            else
            {
                $("#lblRes").html("Linea de factura agregada");
                $("#tbyLineasFacturasParaAgregar").append('<tr id=' + lineaFac.articuloProveedor +"fac"+ '><td>' + lineaFac.articuloProveedor + '</td><td>' + lineaFac.cantidad + '</td></tr>');
            }
        }
        else
            $("#lblRes").html("Error en la cantidad");
    });
}
function AgregarCompra()
{
    let compra = {
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'fecha': new Date()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuCompra/AgregarCompra',
        data: compra,
        encode: true
    }).done((data) => {
        $("#lblRes").html("Compra ingresada");
        var comp = data.data;
        $("#tbyCompras").append('<tr><td>' + comp.id + '</td><td>' + comp.proveedor.rut + " - " + comp.proveedor.nombre + '</td><td>' + comp.fecha + '</td><td>holas</td></tr>');
        ResetiarListaEspera();
    });
}
function ListaFacturaCompra()
{
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/ListaFacturaCompra',
        encode: true
    }).done((data) => {
        var facturas = data.data;
        for (i = 0; i < Object.keys(facturas).length; i++) {
            $("#tbyCompras").append('<tr><td>' + facturas[i].id + '</td><td>' + facturas[i].proveedor.rut + " - " + facturas[i].proveedor.nombre + '</td><td>' + facturas[i].fecha + '</td><td>holas</td></tr>');
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuCompra/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}