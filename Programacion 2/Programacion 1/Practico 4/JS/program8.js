$(document).ready(function(){
	$("#btnResultado").click(Resultado);
});
function Resultado(){
	$("#Resultado").html(Potencia($("#numBase").val(),$("#numExponente").val()));
}
function Potencia(base,exponente){
	var resultado = 1;
	for(var i=0;i<exponente;i++)
		resultado*=base;
	return resultado;
}