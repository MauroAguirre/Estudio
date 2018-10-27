$(document).ready(function () {
    Listar();
});
function Listar() {
    $.ajax({
        type: 'GET',
        url: '/MenuProveedor/Lista',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#tbyProveedores").append('<tr id=' + proveedores[i].rut + '><td>' + proveedores[i].rut + '</td><td>' + proveedores[i].nombre + '</td><td>' + proveedores[i].descripcion + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + proveedores[i].rut + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + proveedores[i].rut + '\')" class="btn btn-default"></td></tr>');
        }
    });
}
function Agregar() {
    let proveedor = {
        'rut': $('#txtRut').val(),
        'nombre': $('#txtNombre').val(),
        'descripcion': $('#txtDescripcion').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuProveedor/Agregar',
        data: proveedor,
        encode: true
    }).done((data) => {
        if (data.success) {
            var nuevo = data.data;
            $("#lblRes").html("Proveedor Agregado");
            $("#tbyProveedores").append('<tr id=' + nuevo.rut + '><td>' + nuevo.rut + '</td><td>' + nuevo.nombre + '</td><td>' + nuevo.descripcion + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + nuevo.rut + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + nuevo.rut + '\')" class="btn btn-default"></td></tr>');
            $('#txtRut').val("");
            $('#txtNombre').val("");
            $('#txtDescripcion').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Borrar(a) {
    let proveedor = {
        'rut': a,
        'nombre': "das",
        'descripcion': "dsad"
    };
    $.ajax({
        type: 'POST',
        url: '/MenuProveedor/Borrar',
        data: proveedor,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Proveedor eliminado");
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
        url: '/MenuProveedor/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Modificar(rut) {
    let proveedor = {
        'rut': rut,
        'nombre': $('#txtNombre').val(),
        'descripcion': $('#txtDescripcion').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuProveedor/Modificar',
        data: proveedor,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Proveedor modificado");
            var idd = "#" + proveedor.rut;
            $(idd).html("");
            $(idd).append('<td>' + proveedor.rut + '</td><td>' + proveedor.nombre + '</td><td>' + proveedor.descripcion + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + proveedor.rut + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + proveedor.rut + '\')" class="btn btn-default"></td>');
            $('#txtRut').val("");
            $('#txtNombre').val("");
            $('#txtDescripcion').val("");
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
}