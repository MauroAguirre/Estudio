$(document).ready(function(){
	$("#btnResultado").click(Resultado);
});
function Resultado(){
	var veces=0
	for(var i=0;i<$("#txt1").val().length;i++){
		if($("#txt2").val()==$("#txt1").val().charAt(i))
			veces++;
	}
	$("#Resultado").html(veces);
}