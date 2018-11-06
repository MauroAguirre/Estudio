$(document).ready(function () {
    ListarArticulosConStock();
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
            for (i = 0; i < Object.keys(articuloStocks).length; i++) {
                $("#tbyArticulos").append('<tr><td>' + articuloStocks[i].articulo.id + " - " + articuloStocks[i].articulo.descripcion + '</td><td>' + articuloStocks[i].articulo.precioVenta + '</td><td>' + articuloStocks[i].stock + '</td><td>' + articuloStocks[i].articulo.miniStock + '</td><td><input type="number" id="' + articuloStocks[i].articulo.id + '"/></td><td><input type="button" value="Agregar_Modificar" onclick="AgregarListaEsperaFactura(' + articuloStocks[i].articulo.id + ')" /></td></td><td><input type="button" value="Borrar_linea" onclick="BorrarListaEsperaFactura(' + articuloStocks[i].articulo.id +')" /></td></tr>');
            }
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
}
function AgregarListaEsperaFactura(id)
{
    let articuloStock = {
        'id': id,
        'stock': $("#" + id).val(),
        'articulo':null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/AgregarListaEsperaFactura',
        data: articuloStock,
        encode: true
    }).done((data) => {
        if (data.success) {
            var articuloStock = data.data;
            if (data.modificar) {
                $("#lblRes").html("Linea modificada");
                $("#"+id+"fac").html('<td> ' + articuloStock.id + '</td><td>' + articuloStock.stock + '</td>');
            }
            else
            {
                $("#lblRes").html("Linea agregada");
                $("#tbyLineasFacturasParaAgregar").append('<tr id="' + articuloStock.id + "fac" + '"><td> '+ articuloStock.id + '</td><td>' + articuloStock.stock + '</td><tr>');
            }
        }
        else {
            $("#lblRes").html("Error en los datos");
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
    });
}
function AgregarVenta()
{
    $.ajax({
        type: 'POST',
        url: '/MenuVenta/AgregarVenta',
        data: null,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Se agrego la compra");
            ResetearListaEsperaFactura();
        }
        else {
            $("#lblRes").html("Error en los datos");
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
        }
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