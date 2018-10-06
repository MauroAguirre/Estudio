$(document).ready(function(){
	$("#btnResultado").click(Cambio);
});
function Cambio(){
	$("#Resultado").html(CambioAFahrenheit($("#numTemperatura").val()));
}
function CambioAFahrenheit(temperatura){
	return ((1.8*temperatura)+32);
}