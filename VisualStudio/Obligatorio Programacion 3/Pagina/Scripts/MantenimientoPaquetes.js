function Agregar() {
    let paquete = {
        'Id':"1",
        'Descripcion': $('#txtDescripcion').val(),
        'Cantidad': $('#numCantidad').val(),
        'Tamano': $('#sltPaq').val(),
        'Mail': $("#userMail").val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoPaquetes/Agregar',
        data: paquete,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Paquete agregado");
            $("#tbyPaq").append('<tr><td>' + data.data.Id + '</td><td>' + data.data.Descripcion + '</td><td>' + data.data.Cantidad + '</td><td>' + data.data.Tamano + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + data.data.Id + '\',this)" class="btn btn-default"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + data.data.Id + '\', this)" class="btn btn-default"/></td></tr>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};
function Borrar(id, element) {
    let paquete = {
        'Id': id,
        'Descripcion': $('#txtDescripcion').val(),
        'Cantidad': $('#numCantidad').val(),
        'Tamano': $('#sltPaq').val(),
        'Mail': $("#userMail").val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoPaquetes/Borrar',
        data: paquete,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Paquete borrado");
            $(element).parent().parent().remove();
        }
    });
}
function Modificar(id, element) {
    let paquete = {
        'Id': id,
        'Descripcion': $('#txtDescripcion').val(),
        'Cantidad': $('#numCantidad').val(),
        'Tamano': $('#sltPaq').val(),
        'Mail': $("#userMail").val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoPaquetes/Modificar',
        data: paquete,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Paquete modificada");
            $(element).parent().parent().html('<td>' + paquete.Id + '</td><td>' + paquete.Descripcion + '</td><td>' + paquete.Cantidad + '</td><td>' + paquete.Tamano + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + paquete.Id + '\',this)" class="btn btn-default"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + paquete.Id + '\', this)" class="btn btn-default"/></td>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};