$(document).ready(function () {
    Listar();
});
function Listar() {
    $.ajax({
        type: 'GET',
        url: '/MenuImprimir/Listar',
        data: null,
        encode: true
    }).done((data) => {
        var factura = data.data;
        var total = data.total;
        var fecha = data.fecha;
        var lineas = factura.LineaFacturas;
        if (data.compra) {
            $("#lblExtra").html("Proveedor");
            $("#tbyFactura").append('<tr><td>' + factura.id + '</td><td>' + fecha + '</td><td>' + total + '</td><td>' + factura.proveedor.rut + " - " + factura.proveedor.nombre+ '</td></tr>');
        }
        else
        {
            $("#lblExtra").html("Descripcion");
            $("#tbyFactura").append('<tr><td>' + factura.id + '</td><td>' + fecha + '</td><td>' + total + '</td><td>' + factura.descripcion + '</td></tr>');
        }
        for (i = 0; i < Object.keys(lineas).length; i++) {
            $("#tbyLineas").append('<tr><td>' + lineas[i].id + '</td><td>' + lineas[i].articulo.id + " - " + lineas[i].articulo.descripcion+ '</td><td>' + lineas[i].cantidad + '</td><td>' + lineas[i].precio + '</td></tr>');
        }
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuImprimir/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}