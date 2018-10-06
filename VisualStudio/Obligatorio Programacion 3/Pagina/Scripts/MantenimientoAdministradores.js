function Agregar() {
    let administrador = {
        'Nombre': $('#txtNombre').val(),
        'Mail': $('#txtMail').val(),
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoAdministradores/Agregar',
        data: administrador,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Administrador agregado");
            $("#tbyDir").append('<tr><td>' + data.data.Nombre + '</td><td>' + data.data.Mail + '</td><td>' + data.data.Contra + '</td><td><input type="button" value="Modificar" class="btn btn-default" onclick="Modificar(\'' + data.data.Mail + '\',this)"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + data.data.Mail + '\', this)" class="btn btn-default"/></td></tr>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};
function Borrar(mail, element) {
    let administrador = {
        'Nombre': $('#txtNombre').val(),
        'Mail': mail,
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoAdministradores/Borrar',
        data: administrador,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Administrador borrado");
            $(element).parent().parent().remove();
        }
    });
}
function Modificar(mail, element) {
    let administrador = {
        'Nombre': $('#txtNombre').val(),
        'Mail': mail,
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoAdministradores/Modificar',
        data: administrador,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Administrador modificada");
            $(element).parent().parent().html('<td>' + administrador.Nombre + '</td><td>' + administrador.Mail + '</td><td>' + administrador.Contra + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + administrador.Mail + '\',this)" class="btn btn-default"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + administrador.Mail + '\', this)" class="btn btn-default"/></td>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};