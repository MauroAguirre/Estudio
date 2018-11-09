$(document).ready(function () {
    ListaRegistro();
    ListaArticulosStock();
});
function ListaRegistro() {
    $.ajax({
        type: 'GET',
        url: '/MenuRegistro/ListaRegistro',
        data: null,
        encode: true
    }).done((data) => {
        var registros = data.data;
        var fechas = data.fechas;
        for (i = 0; i < Object.keys(registros).length; i++) {
            $("#tbyRegistros").append('<tr><td>' + registros[i].id + '</td><td>' + registros[i].articulo.id + " - " + registros[i].articulo.descripcion + '</td><td>' + fechas[i] + '</td><td>' + registros[i].cambio + '</td></tr>');
        }
    });
}
function ListaArticulosStock() {
    $.ajax({
        type: 'GET',
        url: '/MenuRegistro/ListaArticulosStock',
        data: null,
        encode: true
    }).done((data) => {
        var listado = data.data;
        for (i = 0; i < Object.keys(listado).length; i++) {
            $("#tbyStock").append('<tr><td>' + listado[i].articulo.id + '</td><td>' + listado[i].articulo.descripcion + '</td><td>' + listado[i].stock + '</td><td>' + listado[i].estado + '</td></tr>');
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