$(document).ready(function(){
	$("#btnResultado").click(Devolver);
});
function Devolver(){
	$("#Resultado").html(AreaRectangulo($("#numAncho").val(),$("#numAltura").val()));
}
function AreaRectangulo(ancho,altura){
	if(ancho<0||altura<0)
		return -1;
	return ancho*altura;
}
