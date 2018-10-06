var textos=[];
$(document).ready(function(){
	$("#btn1").click(Agregar);
	$("#btn2").click(Verificar);
});
function Verificar(){
	var respuesta="";
	for(var i=0;i<textos.length;i++)
		respuesta+=textos[i]+" ";
	$("#res").html(respuesta);
}
function Agregar(){
	textos.push($("#txt1").val());
	$("#txt1").val("");
	$("#res").html("Ingresado");
}