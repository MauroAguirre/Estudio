$(document).ready(function(){
	$("#btn1").click(Contar);
});
function Contar(){
	var palabras=1;
	var texto=$("#txt1").val();
	while(texto.charAt(0)==" "){
		texto=texto.substr(1,texto.length);
	}
	while(texto.charAt(texto.length-1)==" "){
		texto=texto.substr(0,texto.length-1);
	}
	for(var i=0;i<texto.length;i++){
		if(texto.charAt(i)==" ")
			palabras++;
	}
	if(texto.length==0)
		$("#res").html("No hay palabras");
	else
		$("#res").html("Hay "+palabras+" palabras");
}