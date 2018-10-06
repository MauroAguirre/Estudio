$(document).ready(function(){
	$("#btnResultado").click(Cambio);
});
function Cambio(){
	$("#Resultado").html(Convertir($("#numTemperatura").val(),$("#txtUnidad").val()));
}
function Convertir(temperatura,unidad){
	switch(unidad){
		case "Celsius":
			return ((temperatura-32)/1.8);
		case "Kelvin":
			return ((temperatura+459.67)/1.8);
		case "Rankine":
			return (temperatura+459.67);
		case "Reaumur":
			return ((temperatura-32)/2.25);
	}
}