$(document).ready(function () {
    ListarArticulosConStock();
    ListaFacturaVenta();
});
function ListarArticulosConStock()
{
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/ListarArticulosConStock',
        encode: true
    }).done((data) => {
        if (data.success) {
            var articuloStocks = data.lista;
            $("#tbyArticulos").html("");
            for (i = 0; i < Object.keys(articuloStocks).length; i++) {
                $("#tbyArticulos").append('<tr><td>' + articuloStocks[i].articulo.id + " - " + articuloStocks[i].articulo.descripcion + '</td><td>' + articuloStocks[i].articulo.precioVenta + '</td><td>' + articuloStocks[i].stock + '</td><td>' + articuloStocks[i].articulo.miniStock + '</td><td><input type="number" id="' + articuloStocks[i].articulo.id + '"/></td><td><input type="button" value="Agregar_Modificar" onclick="AgregarListaEsperaFactura(' + articuloStocks[i].articulo.id + ',' + articuloStocks[i].articulo.precioVenta + ')" /></td></td><td><input type="button" value="Borrar_linea" onclick="BorrarListaEsperaFactura(' + articuloStocks[i].articulo.id + ',' + articuloStocks[i].articulo.precioVenta+')" /></td></tr>');
            }
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
}
function AgregarListaEsperaFactura(id,precio)
{
    let articuloStock = {
        'id': id,
        'stock': $("#" + id).val(),
        'precio': $("#" + id).val()*precio,
        'articulo':null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/AgregarListaEsperaFactura',
        data: articuloStock,
        encode: true
    }).done((data) => {
        if (data.success) {
            if (!data.cambio)
                alert("El articulo queda por debajo del nivel minimo de stock");
            var articuloStock = data.data;
            if (data.modificar) {
                $("#lblRes").html("Linea modificada");
                $("#" + id + "fac").html('<td> ' + articuloStock.id + '</td><td>' + articuloStock.stock + '</td><td>' + articuloStock.precio + '</td>');
            }
            else
            {
                $("#lblRes").html("Linea agregada");
                $("#tbyLineasFacturasParaAgregar").append('<tr id="' + articuloStock.id + "fac" + '"><td> ' + articuloStock.id + '</td><td>' + articuloStock.stock + '</td><td>' + articuloStock.precio + '</td><tr>');
            }
            ResetiarTotal();
        }
        else {
            if (data.cambio)
                $("#lblRes").html("Error en los datos");
            else
                $("#lblRes").html("No hay suficientes productos");
        }
    });
}
function BorrarListaEsperaFactura(id)
{
    let articuloStock = {
        'id': id,
        'stock': null,
        'articulo': null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/BorrarListaEsperaFactura',
        data: articuloStock,
        encode: true
    }).done((data) => {
        $("#" + id + "fac").remove();
        $("#lblRes").html("Linea eliminada");
        ResetiarTotal();
    });
}
function AgregarVenta()
{
    let venta = {
        'descripcion': $("#txtDescripcion").val(),
        'fecha': new Date()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/AgregarVenta',
        data: venta,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Venta ingresada");
            var vent = data.data;
            var fecha = data.fecha;
            var total = data.total;
            $("#tbyVentas").append('<tr><td>' + vent.id + '</td><td>' + vent.descripcion + '</td><td>' + fecha + '</td><td>' + total + '</td><td><input type="button" class="btn btn-default" value="Imprimir" onclick="Imprimir(' + facturas[i].id +')"/></td></tr>');
            ResetearListaEsperaFactura();
            ListarArticulosConStock();
        }
        else
            $("#lblRes").html("Error en la venta");
    });
}
function ResetiarTotal()
{
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/ResetiarTotal',
        data: null,
        encode: true
    }).done((data) => {
        if (data.success) {
            var precio = data.data;
            $("#lblTotal").html(precio);
        }
    });
}
function ResetearListaEsperaFactura()
{
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/ResetearListaEsperaFactura',
        data: null,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#tbyLineasFacturasParaAgregar").html("");
            ResetiarTotal();
        }
    });
}
function ListaFacturaVenta() {
    $.ajax({
        type: 'GET',
        url: '/MenuVenta/ListaFacturaVenta',
        data: null,
        encode: true
    }).done((data) => {
        var facturas = data.data;
        var fechas = data.fechas;
        var totales = data.totales;
        $("#tbyVentas").html("");
        for (i = 0; i < Object.keys(facturas).length; i++) {
            $("#tbyVentas").append('<tr><td>' + facturas[i].id + '</td><td>' + facturas[i].descripcion + '</td><td>' + fechas[i] + '</td><td>' + totales[i] + '</td><td><input type="button" class="btn btn-default" value="Imprimir" onclick="Imprimir(' + facturas[i].id +')"/></td></tr>');
        }
    });
}
function Imprimir(id) {
    let facturaTipo = {
        'factura': id,
        'compra': false
    };
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/Imprimir',
        data: facturaTipo,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}