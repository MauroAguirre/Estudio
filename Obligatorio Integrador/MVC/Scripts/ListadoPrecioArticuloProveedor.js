$(document).ready(function () {
    ListarProveedores();
});
$("#slcProveedores").change(function () {
    ListarArticulosProveedor();
});
$("#slcArticulos").change(function () {
    ListarPrecios();
});
function ListarProveedores() {
    $.ajax({
        type: 'GET',
        url: '/MenuListadoPrecioArticuloProveedor/ListarProveedores',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#slcProveedores").append('<option id=' + proveedores[i].rut + '>' + proveedores[i].nombre + '</option>');
        }
        ListarArticulosProveedor();
    });
}
function ListarArticulosProveedor() {
    let proveedor = {
        'rut': $("#slcProveedores option:selected").attr("id"),
        'nombre': null,
        'descripcion': null,
        'contactos': null,
        'activo': true
    };
    $.ajax({
        type: 'GET',
        url: '/MenuListadoPrecioArticuloProveedor/ListarArticulosProveedor',
        data: proveedor,
        encode: true
    }).done((data) => {
        var articulos = data.data;
        $("#slcArticulos").html("");
        for (i = 0; i < Object.keys(articulos).length; i++) {
            $("#slcArticulos").append('<option id=' + articulos[i].articulo.id + '>' + articulos[i].articulo.id + " - " + articulos[i].articulo.descripcion + '</option>');
        }
        ListarPrecios();
    });
}
function ListarPrecios()
{
    let articuloProv = {
        'id': null,
        'costo': null,
        'fecha': null,
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'articulo': $("#slcArticulos option:selected").attr("id")
    };
    $.ajax({
        type: 'GET',
        url: '/MenuListadoPrecioArticuloProveedor/ListarPrecios',
        data: articuloProv,
        encode: true
    }).done((data) => {
        var articulos = data.data;
        var fechas = data.fechas;
        $("#tbyPrecios").html("");
        for (i = 0; i < Object.keys(articulos).length; i++) {
            $("#tbyPrecios").append('<tr><td>' + articulos[i].id + '</td><td>' + articulos[i].costo + '</td><td>' + fechas[i] +'</td></tr>');
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