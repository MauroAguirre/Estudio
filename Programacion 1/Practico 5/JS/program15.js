$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var texto=$("#txt1").val();
	var letra=texto.charAt(0);
	var veces=0;
	for(var i=0;i<texto.length;i++){
		if(texto.charAt(i)==letra)
			veces++;
	}
	$("#Res").html("La cantidad que veces que se encuentra es de: "+veces);
}