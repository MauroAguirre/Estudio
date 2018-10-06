var numeros=[];
$(document).ready(function(){
	$("#btn1").click(Agregar);
	$("#btn2").click(Verificar);
});
function Verificar(){
	var grande;
	for(var i=0;i<numeros.length;i++){
		if(i==0)
			grande=numeros[i];
		if(grande<numeros[i])
			grande=numeros[i];
	}
	$("#res").html("El mas grande es: "+grande);
}
function Agregar(){
	numeros.push(Number($("#txt1").val()));
	$("#txt1").val("");
	$("#res").html("Ingresado");
}