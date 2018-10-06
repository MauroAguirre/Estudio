$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	if($("#txt1").val().charAt(0)==$("#txt1").val().charAt($("#txt1").val().length-1))
		$("#res").html("Empieza y termina con la misma letra");
	else
		$("#res").html("No empieza y termina con la misma letra");
}