function Agregar() {
    let usuario = {
        'Nombre': $('#txtNombre').val(),
        'Mail': $('#txtMail').val(),
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoUsuarios/Agregar',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario agregado");
            $("#tbyDir").append('<tr><td>' + data.data.Nombre + '</td><td>' + data.data.Mail + '</td><td>' + data.data.Contra + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + data.data.Mail + '\',this)" class="btn btn-default"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + data.data.Mail + '\', this)" class="btn btn-default"/></td></tr>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};
function Borrar(mail, element) {
    let usuario = {
        'Nombre': $('#txtNombre').val(),
        'Mail': mail,
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoUsuarios/Borrar',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario borrado");
            $(element).parent().parent().remove();
        }
    });
}
function Modificar(mail, element) {
    let usuario = {
        'Nombre': $('#txtNombre').val(),
        'Mail': mail,
        'Contra': $('#pwdContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/MantenimientoUsuarios/Modificar',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario modificada");
            $(element).parent().parent().html('<td>' + usuario.Nombre + '</td><td>' + usuario.Mail + '</td><td>' + usuario.Contra + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + usuario.Mail + '\',this)" class="btn btn-default"/></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + usuario.Mail + '\', this)" class="btn btn-default"/></td>');
        }
        else {
            $("#lblRes").html("Error en los datos");
        }
    });
};