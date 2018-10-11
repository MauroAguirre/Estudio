function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MainMenu/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
};
function Usuarios() {
    $.ajax({
        type: 'POST',
        url: '/MainMenu/Usuarios',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
};