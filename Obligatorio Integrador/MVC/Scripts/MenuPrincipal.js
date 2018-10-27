function Salir() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Salir',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Usuarios() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Usuarios',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Articulos() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Articulos',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Proveedores() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Proveedores',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}