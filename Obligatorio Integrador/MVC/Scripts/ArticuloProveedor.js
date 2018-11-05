$(document).ready(function () {
    ListarProveedores();
    ListarArticulos();
    ListarArticulosProveedor();
});
$("#slcProveedores").change(function () {
    ListarArticulosProveedor();
});
function Agregar() {
    let ArticuloProv = {
        'activo': true,
        'id':null,
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'articulo': $("#slcArticulos option:selected").attr("id"),
        'costo': $('#numCosto').val(),
        'fecha': null
    };
    $.ajax({
        type: 'POST',
        url: '/MenuArticuloProveedor/Agregar',
        data: ArticuloProv,
        encode: true
    }).done((data) => {
        if (data.success) {
            var articulosProv = data.data;
            var fecha = data.fecha;
            $("#lblRes").html("Articulo del proveedor agregado");
            $("#tbyArticulosProveedor").append('<tr id=' + articulosProv.id + '><td>' + articulosProv.articulo.id + " - " + articulosProv.articulo.descripcion + '</td><td>' + articulosProv.costo + '</td><td>' + fecha + '</td></tr>');
            $('#numCosto').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function ListarProveedores() {
    $.ajax({
        type: 'GET',
        url: '/MenuArticuloProveedor/ListarProveedores',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#slcProveedores").append('<option id=' + proveedores[i].rut + '>' + proveedores[i].nombre + '</option>');
        }
    });
}
function ListarArticulos() {
    $.ajax({
        type: 'GET',
        url: '/MenuArticuloProveedor/ListarArticulos',
        data: null,
        encode: true
    }).done((data) => {
        var articulos = data.data;
        for (i = 0; i < Object.keys(articulos).length; i++) {
            $("#slcArticulos").append('<option id=' + articulos[i].id + '>' + articulos[i].id + " - " + articulos[i].descripcion+ '</option>');
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
        url: '/MenuArticuloProveedor/ListarArticulosProveedor',
        data: ArticuloProv,
        encode: true
    }).done((data) => {
        $("#tbyArticulosProveedor").html("");
        var articulosProv = data.data;
        var fechas = data.fechas;
        for (i = 0; i < Object.keys(articulosProv).length; i++) {
            $("#tbyArticulosProveedor").append('<tr id=' + articulosProv[i].id + '><td>' + articulosProv[i].articulo.id + " - " + articulosProv[i].articulo.descripcion + '</td><td>' + articulosProv[i].costo + '</td><td>' + fechas[i] + '</td></tr>');
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuArticuloProveedor/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}