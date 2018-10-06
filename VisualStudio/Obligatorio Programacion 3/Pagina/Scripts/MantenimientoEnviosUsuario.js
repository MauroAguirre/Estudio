function AgregarPaq()
{
    let IdMail = {
        'Id': $('#sltPaq').val(),
        'Mail': $('#userMail').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoEnviosUsuario/AgregarPaq',
        data: IdMail,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Paquete agregado");
            $("#tbyPaq").append('<tr><td>' + data.data.ID + '</td><td>' + data.data.Descripcion + '</td><td>' + data.data.Cantidad + '</td><td>' + data.data.Tamano + '</td><td><input type="button" value="Borrar" onclick="BorrarPaq(\'' + data.data.ID + '\', this)" class="btn btn-default"/></td></tr>');
        }
        else {
            $("#lblRes").html("El paquete ya esta ingresado");
        }
    });
}
function BorrarPaq(id,element)
{
    let IdMail = {
        'Id': id,
        'Mail': $('#userMail').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoEnviosUsuario/BorrarPaq',
        data: IdMail,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Paquete borrado");
            $(element).parent().parent().remove();
        }
    });
}
function AgregarEnv()
{
    let envio = {
        'Mail': $('#userMail').val(),
        'Envio': $('#dteEnvio').val(),
        'Llegada': $('#dteLlegada').val(),
        'Direccion': $('#txtDir').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoEnviosUsuario/AgregarEnv',
        data: envio,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#tbyPaq").html("");
            for (x in data) {
                $('#'+x.ID+'').remove();
            } 
            $("#lblRes").html("Envio agregado");
        }
        else {
            $("#lblRes").html("Error en el envio");
        }
    });
}