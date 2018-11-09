$(document).ready(function () {
    ListarArticulos40();
});
function ListarArticulos40() {
    $.ajax({
        type: 'GET',
        url: '/MenuListadoArticulos40/ListarArticulos40',
        data: null,
        encode: true
    }).done((data) => {
        var articulosStocks = data.data;
        for (i = 0; i < Object.keys(articulosStocks).length; i++) {
            $("#tbyArticulos").append('<tr><td>' + articulosStocks[i].articulo.id + '</td><td>' + articulosStocks[i].articulo.descripcion + '</td><td>' + articulosStocks[i].articulo.iva + '</td><td>' + articulosStocks[i].articulo.miniStock + '</td><td>' + articulosStocks[i].articulo.precioVenta + '</td><td>' + articulosStocks[i].stock +'</td></tr>');
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuListadoArticulos40/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}