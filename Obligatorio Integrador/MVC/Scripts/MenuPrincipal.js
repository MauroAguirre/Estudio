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
function Comunicaciones() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Comunicaciones',
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
function Ventas() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/Ventas',
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
function MenuListadoArticuloBajos() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/MenuListadoArticuloBajos',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function ArticulosDebajo40(){
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/ArticulosDebajo40',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}
function PrecioArticuloProveedor() {
    $.ajax({
        type: 'POST',
        url: '/MenuPrincipal/PrecioArticuloProveedor',
        data: null,
        encode: true
    }).done((data) => {
        window.location.href = data;
    });
}