$(document).ready(function () {
    ListarProveedores();
    ListarArticulosProveedor();
    ListaFacturaCompra();
});
$("#slcProveedores").change(function () {
    ListarArticulosProveedor();
    ResetiarListaEspera();
    ListaFacturaCompra();
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
            $("#tbyArticulosProveedor").append('<tr id=' + articulosProv[i].id + '><td>' + articulosProv[i].articulo.id + " - " + articulosProv[i].articulo.descripcion + '</td><td>' + articulosProv[i].costo + '</td><td><input type="text" id="' + articulosProv[i].articulo.id + "_cantidad" + '"/></td><td><input type="button" value="Agregar_Modificar" onclick="Agregar_ModificarListarFacturaEspera(\'' + articulosProv[i].articulo.id + '\',\'' + articulosProv[i].costo + '\')")"/></td><td><input type="button" value="Borrar" onclick="Borrar_lineafacturaespera(\'' + articulosProv[i].articulo.id + '\',\'' + articulosProv[i].costo + '\')"/></td></tr>');
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
        $("#lblTotal").html("0");
    });
}
function CambiarTotal() {
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/CambiarTotal',
        data: null,
        encode: true
    }).done((data) => {
        var costo = data.data;
        $("#lblTotal").html(costo);
    });
}
function Agregar_ModificarListarFacturaEspera(artId,costo) {
    let lineaFac = {
        'id': null,
        'cantidad': $("#" + artId + "_cantidad").val(),
        'articulo': artId,
        'precio': $("#" + artId + "_cantidad").val()*costo,
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
                $("#" + lineaFac.articulo).html('<td>' + lineaFac.articulo + '</td><td>' + lineaFac.cantidad + '</td><td>' + lineaFac.precio + '</td>');
                $("#lblRes").html("Linea de factura modificada");
            }
            else
            {
                $("#lblRes").html("Linea de factura agregada");
                $("#tbyLineasFacturasParaAgregar").append('<tr id=' + lineaFac.articulo + '><td>' + lineaFac.articulo + '</td><td>' + lineaFac.cantidad + '</td><td>' + lineaFac.precio + '</td></tr>');
            }
            CambiarTotal();
        }
        else
            $("#lblRes").html("Error en la cantidad");
    });
}
function Borrar_lineafacturaespera(id)
{
    let lineaFac = {
        'id': null,
        'cantidad': null,
        'articulo': id,
        'factura': null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuCompra/Borrar_lineafacturaespera',
        data: lineaFac,
        encode: true
    }).done((data) => {
        $("#lblRes").html("Linea de factura borrada");
        $("#" + id).remove();
        CambiarTotal();
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
        if (data.success) {
            $("#lblRes").html("Compra ingresada");
            var comp = data.data;
            var fecha = data.fecha;
            var total = data.total;
            $("#tbyCompras").append('<tr><td>' + comp.id + '</td><td>' + comp.proveedor.rut + " - " + comp.proveedor.nombre + '</td><td>' + fecha + '</td><td>' + total + '</td><td><input type="button" class="btn btn-default" value="Imprimir" onclick="Imprimir(' + comp.id+')"/></td></tr>');
            ResetiarListaEspera();
        }
        else
            $("#lblRes").html("Error en la compra");
    });
}
function ListaFacturaCompra()
{
    let compra = {
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'fecha': new Date()
    };
    $.ajax({
        type: 'GET',
        url: '/MenuCompra/ListaFacturaCompra',
        data: compra,
        encode: true
    }).done((data) => {
        var facturas = data.data;
        var fechas = data.fechas;
        var totales = data.totales;
        $("#tbyCompras").html("");
        for (i = 0; i < Object.keys(facturas).length; i++) {
            $("#tbyCompras").append('<tr><td>' + facturas[i].id + '</td><td>' + facturas[i].proveedor.rut + " - " + facturas[i].proveedor.nombre + '</td><td>' + fechas[i] + '</td><td>' + totales[i] + '</td><td><input type="button" class="btn btn-default" value="Imprimir" onclick="Imprimir(' + facturas[i].id +')"/></td></tr>');
        }
    });
}
function Imprimir(id)
{
    let facturaTipo = {
        'factura': id,
        'compra':true
    };
    $.ajax({
        type: 'POST',
        url: '/MenuCompra/Imprimir',
        data: facturaTipo,
        encode: true
    }).done((data) => {
        window.location.href = data;
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