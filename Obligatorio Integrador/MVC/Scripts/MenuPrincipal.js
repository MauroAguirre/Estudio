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
function Contactos() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Contactos',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function ArticulosProveedor() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/ArticulosProveedor',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Compras() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Compras',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function Registros() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Registros',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}