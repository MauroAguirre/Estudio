$(document).ready(function(){
	$("#btn1").click(Agregar);
});
function Agregar(){
	var texto = $("#txt1").val().toLowerCase();
	texto = texto.charAt(0).toUpperCase() + texto.substr(1,texto.length);
	$("#res").html(texto);
}