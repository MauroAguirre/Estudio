function Ingresar() {
    let usuario = {
        'mail': $('#txtMail').val(),
        'contra': $('#txtContra').val()
    };
    $.ajax({
        type: 'POST',
        url: '/MenuLogin/Ingresar',
        data: usuario,
        encode: true
    }).done((data) => {
        window.location.href = data;
        if (data.success)
            window.location.href = data;
        else
            $("#lblRes").html("Error en los datos");
    });
}