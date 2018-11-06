$(document).ready(function () {
    ListarProveedores();
    ListaComunicaciones();
});
$("#slcProveedores").change(function () {
    ListaContactos();
});
function ListarProveedores() {
    $.ajax({
        type: 'GET',
        url: '/MenuComunicacion/ListarProveedores',
        data: null,
        encode: true
    }).done((data) => {
        var proveedores = data.data;
        for (i = 0; i < Object.keys(proveedores).length; i++) {
            $("#slcProveedores").append('<option id=' + proveedores[i].rut + '>' + proveedores[i].nombre + '</option>');
        }
        ListaContactos();
    });
}
function ListaContactos() {
    let proveedor = {
        'rut': $("#slcProveedores option:selected").attr("id"),
        'nombre': null,
        'descripcion': null,
        'activo': null
    };
    $.ajax({
        type: 'GET',
        url: '/MenuComunicacion/ListaContactos',
        data: proveedor,
        encode: true
    }).done((data) => {
        var contactos = data.data;
        $("#slcContactos").html("");
        for (i = 0; i < Object.keys(contactos).length; i++) {
            $("#slcContactos").append('<option id=' + contactos[i].id + '>' + contactos[i].nombre + '</option>');
        }
    });
}
function ListaComunicaciones()
{
    $.ajax({
        type: 'GET',
        url: '/MenuComunicacion/ListaComunicaciones',
        encode: true
    }).done((data) => {
        var comunicaciones = data.data;
        var fechas = data.fechas;
        for (i = 0; i < Object.keys(comunicaciones).length; i++) {
            $("#tbyComunaciones").append('<tr><td>' + comunicaciones[i].id + '</td><td>' + comunicaciones[i].contacto.proveedor.nombre + '</td><td>' + comunicaciones[i].contacto.nombre + '</td><td>' + fechas[i] + '</td><td>' + comunicaciones[i].tipo + '</td><td>' + comunicaciones[i].comentario + '</td></tr>');
        }
    });
}
function Agregar() {
    let comunication = {
        'fecha': null,
        'comentario': $("#txtComentario").val(),
        'contacto': $("#slcContactos option:selected").attr("id"),
        'tipo': $("#slcTipos option:selected").attr("value")
    };
    $.ajax({
        type: 'GET',
        url: '/MenuComunicacion/Agregar',
        data: comunication,
        encode: true
    }).done((data) => {
        var comunicacion = data.data;
        var fecha = data.fecha;
        $("#lblRes").html("Comunicacion agregada");
        $("#tbyComunaciones").append('<tr><td>' + comunicacion.id + '</td><td>' + comunicacion.contacto.proveedor.nombre + '</td><td>' + comunicacion.contacto.nombre + '</td><td>' + fecha + '</td><td>' + comunicacion.tipo + '</td><td>' + comunicacion.comentario + '</td></tr>');
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuComunicacion/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
