$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var resultado=Lugar();
	if(resultado==-1)
		$("#Res").html("La letra no se encuentra mas de una vez");
	else
		$("#Res").html("La letra se encuentra en: "+resultado);
}
function Lugar(){
	var veces=0
	var texto=$("#txt1").val();
	var letra=$("#txt2").val();
	for (var i=texto.length-1;i>=0;i--){
		if(texto.charAt(i)==letra)
			veces++
		if(veces==2)
			return i+1;
	}
	return -1;
}