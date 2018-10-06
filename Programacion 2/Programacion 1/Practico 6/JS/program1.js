var alias=[];
$(document).ready(function(){
	$("#btn1").click(Agregar);
});
function Agregar(){
	for(var i=0;i<alias.length;i++){
		if(alias[i]==$("#txt1").val()){
			$("#res").html("Ya esta ingresado el alias");
			return;
		}
	}
	$("#res").html("Alias ingresado");
	alias.push($("#txt1").val());
	$("#txt1").val("");
}