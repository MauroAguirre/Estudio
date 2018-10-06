$(document).ready(function(){
	$("#btnResultado").click(Devolver);
});
function Devolver(){
	$("#Resultado").html(AreaTriangulo($("#numBase").val(),$("#numAltura").val()));
}
function AreaTriangulo(base,altura){
	if(base<0||altura<0)
		return -1;
	return (base*altura)/2;
}
