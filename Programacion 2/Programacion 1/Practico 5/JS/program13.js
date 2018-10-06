$(document).ready(function(){
	$("#btn1").click(Remplazar);
});
function Remplazar(){
	var letra=$("#txt2").val();
	var texto=$("#txt1").val();
	for(var t=0;t<texto.length;t++){
		if(texto.charAt(t)==letra)
			texto=texto.substr(0,t)+"*"+texto.substr(t+1,texto.length);
	}
	$("#Res").html(texto);
}