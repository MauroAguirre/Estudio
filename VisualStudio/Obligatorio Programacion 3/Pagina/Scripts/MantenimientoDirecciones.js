function Agregar() {
    let direccion = {
        'Nombre': $('#txtNomDir').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoDirecciones/Agregar',
        data: direccion,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblDirRes").html("Direccion agregada");
            $("#tbyDir").append('<tr><td>' + data.data.Nombre + '</td><td><input type="button" value="Borrar" onclick="Borrar(\'' + data.data.Nombre + '\', this)" class="btn btn-default"/></td></tr>');
        }
        else {
            $("#lblDirRes").html("Error en los datos");
        }
    });
};
function Borrar(nombre,element){
    let direccion = {
        'Nombre': nombre,
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoDirecciones/Borrar',
        data: direccion,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblDirRes").html("Direccion Borrada");
            $(element).parent().parent().remove();
        }
    });
}