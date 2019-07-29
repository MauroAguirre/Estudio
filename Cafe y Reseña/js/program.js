$( document ).ready(function() {
    console.log( "ready!" );
    $("#Ingreso").hide();
    $("#IrIngresar").click(IrBusqueda);
    $("#IrReseñas").click(IrReseñas);
});
function IrBusqueda(){
    $(".DivPrincipales").hide();
    $("#Ingreso").show();
}
function IrReseñas(){
    $(".DivPrincipales").hide();
    $("#Reseñas").show();
}