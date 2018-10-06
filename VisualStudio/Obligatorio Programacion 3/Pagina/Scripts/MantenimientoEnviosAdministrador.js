function CambiarEnvio(id)
{
    let env = {
        'Estado': $('#sltEst').val(),
        'Direccion': $('#sltDir').val(),
        'Id': id,
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoEnviosAdm/CambiarEnvio',
        data: env,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblDirRes").html("Envio Modificado");
        }
        else {
            $("#lblDirRes").html("Error en los datos");
        }
    });
}