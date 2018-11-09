$(document).ready(function () {
    ListaArticulos();
});
function ListaArticulos() {
    $.ajax({
        type: 'GET',
        url: '/MenuListadoArticuloBajos/ListaArticulos',
        data: null,
        encode: true
    }).done((data) => {
        var ArticuloStocks = data.data;
        for (i = 0; i < Object.keys(ArticuloStocks).length; i++) {
            $("#tbyArticulos").append('<tr><td>' + ArticuloStocks[i].articulo.id + '</td><td>' + ArticuloStocks[i].articulo.descripcion + '</td><td>' + ArticuloStocks[i].articulo.precioVenta + '</td><td>' + ArticuloStocks[i].articulo.miniStock + '</td><td>' + ArticuloStocks[i].stock + '</td></tr>');
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuListadoArticuloBajos/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}