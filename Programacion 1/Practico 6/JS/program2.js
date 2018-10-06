var coleccion=[];
$(document).ready(function(){
	$("#btn1").click(Agregar);
	$("#btn2").click(Verificar);
});
function Verificar(){
	var colCantidad=[];
	var respuesta="";
	for(var i=0;i<coleccion.length;i++){
		colCantidad.push(coleccion[i].length);
	}
	$("#res").html("");
	for(var l=0;l<colCantidad.length;l++)
		respuesta+=colCantidad[l]+'<br>';
	$("#res").html(respuesta);
}
function Agregar(){
	$("#res").html("texto ingresado al array");
	coleccion.push($("#txt1").val());
	$("#txt1").val("");
}