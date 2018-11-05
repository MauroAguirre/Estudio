$(document).ready(function () {
    ListarProveedores();
    var rut = $("#slcProveedores option:selected").attr("id");
    ListarContactos(rut);
});
$("#slcProveedores").change(function () {
    var rut = $("#slcProveedores option:selected").attr("id");
    ListarContactos(rut);
});
function ListarProveedores() {
    $.ajax({
        type: 'GET',
        url: '/MenuContacto/ListarProveedores',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#slcProveedores").append('<option id=' + proveedores[i].rut + '>' + proveedores[i].nombre + '</option>');
        }
    });
}
function ListarContactos(rut) {
    let contactosProv = {
        'proveedor': rut,
        'nombre': $('#txtNombre').val(),
        'telefono': $('#numTelefono').val()
    };
    $.ajax({
        type: 'GET',
        url: '/MenuContacto/ListarContactos',
        data: contactosProv,
        encode: true
    }).done((data) => {
        var contactos = data.data;
        $("#tbyContactos").html("");
        for (i = 0; i < Object.keys(contactos).length; i++) {
            $("#tbyContactos").append('<tr id=' + contactos[i].nombre + '><td>' + contactos[i].nombre + '</td><td>' + contactos[i].telefono + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + contactos[i].nombre + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + contactos[i].nombre + '\')" class="btn btn-default"></td></tr>');
        }
    });
}
function Agregar() {
    let contactosProv = {
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'nombre': $('#txtNombre').val(),
        'telefono': $('#numTelefono').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuContacto/Agregar',
        data: contactosProv,
        encode: true
    }).done((data) => {
        if (data.success) {
            var contacto = data.data;
            $("#lblRes").html("Contacto agregado");
            $("#tbyContactos").append('<tr id=' + contacto.nombre + '><td>' + contacto.nombre + '</td><td>' + contacto.telefono + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + contacto.nombre + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + contacto.nombre + '\')" class="btn btn-default"></td></tr>');
            $('#txtNombre').val("");
            $('#numTelefono').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Borrar(nombre) {
    let contactoProv = {
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'nombre': nombre,
        'telefono': $('#numTelefono').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuContacto/Borrar',
        data: contactoProv,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Contacto eliminado");
            $("#" + contactoProv.nombre).html("");
            $('#txtNombre').val("");
            $('#numTelefono').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuContacto/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Modificar(nombre) {
    let contactoProv = {
        'proveedor': $("#slcProveedores option:selected").attr("id"),
        'nombre': nombre,
        'telefono': $('#numTelefono').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuContacto/Modificar',
        data: contactoProv,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Contacto modificado");
            $("#" + contactoProv.nombre).html('<td>' + contactoProv.nombre + '</td><td>' + contactoProv.telefono + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + contactoProv.nombre + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + contactoProv.nombre + '\')" class="btn btn-default"></td>');
            $('#txtNombre').val("");
            $('#numTelefono').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}