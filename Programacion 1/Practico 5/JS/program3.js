$(document).ready(function(){
	$("#btnResultado").click(Resultado);
});
function Resultado(){
	var veces=0;
	var frase=$("#txt1").val();
	for(var i=0;i<frase.length;i++){
		if(frase.charAt(i)=="a"||frase.charAt(i)=="e"||frase.charAt(i)=="i"||frase.charAt(i)=="o"||frase.charAt(i)=="u"
		||frase.charAt(i)=="A"||frase.charAt(i)=="E"||frase.charAt(i)=="I"||frase.charAt(i)=="O"||frase.charAt(i)=="U")
			veces++;
	}
	$("#Resultado").html(veces);
}