$(document).ready(function () {
    Listar();
});
function Listar() {
    $.ajax({
        type: 'GET',
        url: '/MenuArticulo/ListaArticulos',
        data: null,
        encode: true
    }).done((data) => {
        var articulos = data.data;
        for (i = 0; i < Object.keys(articulos).length; i++) {
            $("#tbyArticulos").append('<tr id=' + articulos[i].id + '><td>' + articulos[i].id + '</td><td>' + articulos[i].descripcion + '</td><td>' + articulos[i].iva + '</td><td>' + articulos[i].miniStock + '</td><td>' + articulos[i].precioVenta + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + articulos[i].id + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + articulos[i].id + '\')" class="btn btn-default"></td></tr>');
        }
    });
}
function Agregar() {
    var iva=21;
    if ($("#rdoIva1").is(":checked"))
        iva = 10;
    let articulo = {
        'id': null,
        'descripcion': $('#txtDescripcion').val(),
        'iva': iva,
        'miniStock': $('#numMiniStock').val(),
        'precioVenta': $('#numPrecioVenta').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuArticulo/AgregarArticulo',
        data: articulo,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Articulo Agregado");
            $("#tbyArticulos").append('<tr id=' + articulos[i].id + '><td>' + articulos[i].id + '</td><td>' + articulos[i].descripcion + '</td><td>' + articulos[i].iva + '</td><td>' + articulos[i].miniStock + '</td><td>' + articulos[i].precioVenta + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + articulos[i].id + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + articulos[i].id + '\')" class="btn btn-default"></td></tr>');
            $('#txtDescripcion').val("");
            $('#numMiniStock').val("");
            $('#numPrecioVenta').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Borrar(a) {
    let articulo = {
        'id': a,
        'descripcion': "0",
        'iva': 0,
        'miniStock': 0,
        'precioVenta': 0
    };
    $.ajax({
        type: 'POST',
        url: '/MenuArticulo/Borrar',
        data: articulo,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Articulo eliminado");
            var id = "#" + a;
            $(id).remove();
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuUsuario/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Modificar(id) {
    var iva = 21;
    if ($("#rdoIva1").is(":checked"))
        iva = 10;
    let articulo = {
        'id': id,
        'descripcion': $('#txtDescripcion').val(),
        'iva': iva,
        'miniStock': $('#numMiniStock').val(),
        'precioVenta': $('#numPrecioVenta').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuArticulo/Modificar',
        data: articulo,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Articulo modificado");
            var idd = "#" + articulo.id;
            $(idd).html("");
            $("#tbyArticulos").append('<td>' + articulo.id + '</td><td>' + articulo.descripcion + '</td><td>' + articulo.iva + '</td><td>' + articulo.miniStock + '</td><td>' + articulo.precioVenta + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + articulo.id + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + articulo.id + '\')" class="btn btn-default"></td>');
            $('#txtDescripcion').val("");
            $('#numMiniStock').val("");
            $('#numPrecioVenta').val("");
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
}