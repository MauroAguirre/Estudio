$(document).ready(function () {
    Listar();
});
function Listar() {
    $.ajax({
        type: 'GET',
        url: '/MenuUsuario/ListaUsuarios',
        data: null,
        encode: true
    }).done((data) => {
        var usuarios = data.data;
        for (i = 0; i < Object.keys(usuarios).length; i++) {
            $("#tbyUsuarios").append('<tr id=' + usuarios[i].mail.replace("@", "a").replace(".","a") + '><td>' + usuarios[i].mail + '</td><td>' + usuarios[i].contra + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + usuarios[i].mail + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + usuarios[i].mail + '\')" class="btn btn-default"></td></tr>');
        }
    });
}
function Agregar() {
    let usuario = {
        'mail': $('#txtMail').val(),
        'contra': $('#txtContra').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuUsuario/AgregarUsuario',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario Agregado");
            $("#tbyUsuarios").append('<tr id=' + usuario.mail.replace("@", "a").replace(".", "a") + '><td>' + usuario.mail + '</td><td>' + usuario.contra + '</td><td><input type="button" value="Modificar" onclick="Modificar(\'' + usuario.mail + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + usuario.mail + '\')" class="btn btn-default"></td></tr>');
            $('#txtContra').val("");
            $('#txtMail').val("");
        }    
        else
            $("#lblRes").html("Error en los datos");
    });
}
function Modificar(mail) {
    let usuario = {
        'mail': mail,
        'contra': $('#txtContra').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuUsuario/Modificar',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario modificado");
            mail = mail.replace("@", "a").replace(".", "a");
            $("#"+mail).html('<td>' + usuario.mail + '</td> <td>' + usuario.contra + '</td> <td><input type="button" value="Modificar" onclick="Modificar(\'' + usuario.mail + '\')" class="btn btn-default"></td><td><input type="button" value="Borrar" onclick="Borrar(\'' + usuario.mail + '\')" class="btn btn-default" ></td>');
            $('#txtContra').val("");
            $('#txtMail').val("");
        }
        else {
            $("#lblRes").html("Error en los datos al modificar");
        }
    });
}
function Borrar(u) {
    let usuario = {
        'mail': u,
        'contra': "0"
    };
    $.ajax({
        type: 'POST',
        url: '/MenuUsuario/Borrar',
        data: usuario,
        encode: true
    }).done((data) => {
        if (data.success) {
            $("#lblRes").html("Usuario eliminado");
            u = u.replace("@", "a").replace(".", "a");
            $("#"+u).remove();
        }
        else {
            $("#lblRes").html("Error en los datos");
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