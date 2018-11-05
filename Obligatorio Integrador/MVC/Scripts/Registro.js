$(document).ready(function () {
    ListaRegistro();
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