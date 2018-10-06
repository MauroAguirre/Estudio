$(document).ready(function(){
	$("#btnConvertir").click(Resultado);
});
function Resultado(){
	if($("#rad1").is(":checked"))
		$("#Resultado").html($("#txt1").val().toUpperCase());
	else
		$("#Resultado").html($("#txt1").val().toLowerCase());
}