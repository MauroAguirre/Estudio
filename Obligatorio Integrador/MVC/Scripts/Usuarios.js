function AgregarUsuario() {
    let usuario = {
        'mail': $('#txtMail').val(),
        'contra': $('#txtContra').val(),
    };
    $.ajax({
        type: 'POST',
        url: '/Users/AgregarUsuario',
        data: usuario,
        encode: true
    }).done((data) => {
        
    });
}
function Salir() {
    $.ajax({
        type: 'POST',
        url: '/Users/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
};