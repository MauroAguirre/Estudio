$(document).ready(function () {
    ListarProveedores();
});
$("#slcProveedores").change(function () {
    var algo = $("#slcProveedores option:selected").text();
    alert(algo);
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
function Agregar() {
    let contactos = {
        'Proveedor': null,
        'nombre': $('#txtNombre').val(),
        'telefono': $('#numTelefono').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuContacto/Agregar',
        data: contactos,
        encode: true
    }).done((data) => {
        if (data.success) {
            var nuevo = data.data;
            $("#lblRes").html("Contacto Agregado");
            $("#tbyContactos").append('<tr id=' + contactos.nombre + '><td>' + contactos.nombre + '</td><td>' + contactos.telefono + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + contactos.nombre + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + contactos.nombre + '\')" class="btn btn-default"></td></tr>');
            $('#txtNombre').val("");
            $('#numTelefono').val("");
        }
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Borrar(a) {

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
function Modificar(id) {

}