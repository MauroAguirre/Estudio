$(document).ready(function () {
    Lista();
});
$("#slcArticulos").change(function () {
    Buscar();
});
function Lista() {
    $.ajax({
        type: 'GET',
        url: '/MenuDefensa/ListaArticulos',
        data: null,
        encode: true
    }).done((data) => {
        var articulos = data.data;
        for (i = 0; i < Object.keys(articulos).length; i++) {
            $("#slcArticulos").append('<option id=' + articulos[i].id+'>' + articulos[i].id + '</option>');
        }
        Buscar();
    });
}
function Buscar() {
    var id = $("#slcArticulos").val();
    let articulo = {
        'activo': null,
        'id': id,
        'descripcion': null,
        'iva': null,
        'miniStock': null,
        'precioVenta': null
    };
    $.ajax({
        type: 'GET',
        url: '/MenuDefensa/Buscar',
        data: articulo,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#tbyProveedores").html("");
            var prov = data.data;
            for (i = 0; i < Object.keys(prov).length; i++) {
                $("#tbyProveedores").append('<tr><td>' + prov[i].proveedor.nombre + '</td><td>' + prov[i].proveedor.rut + '</td><td>' + prov[i].proveedor.descripcion + '</td><td>' + prov[i].contactos[0] + '</td><td>' + prov[i].contactos[1] + '</td><td>' + prov[i].contactos[2] + '</td><td>' + prov[i].contactos[3] + '</td></tr>');
            }
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuDefensa/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}