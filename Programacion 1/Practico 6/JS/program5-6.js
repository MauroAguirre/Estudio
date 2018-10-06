var numeros=[];
$(document).ready(function(){
	$("#btn1").click(Agregar);
	$("#btn2").click(Promedio);
	$("#btn3").click(Mayores_a_20);
});
function Mayores_a_20(){
	var respuesta="";
	for(var i=0;i<numeros.length;i++){
		if(numeros[i]>20)
			respuesta+=numeros[i]+" ";
	}
	$("#res").html(respuesta);
}
function Promedio(){
	var suma=0;
	for(var i=0;i<numeros.length;i++)
		suma+=parseInt(numeros[i]);
	$("#res").html(suma/numeros.length);
}
function Agregar(){
	numeros.push($("#num1").val());
	$("#num1").val("");
	$("#res").html("Ingresado");
}