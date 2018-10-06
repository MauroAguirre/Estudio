$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var texto = $("#txt1").val();
	var mitad;
	for(var t=0;t<texto.length;t++){
		if(texto.charAt(t)==" ")
			texto=texto.substr(0,t)+texto.substr(t+1,texto.length);
	}
	if(texto.charAt(texto.length-1)==" ")
		texto=texto.substr(0,texto.length-1);
	var iguales=true;
	var tex1="";
	var tex2="";
	if(texto.length%2==0)
		mitad = texto.length/2;
	else
		mitad = parseInt(texto.length/2)+1;
	for (var i=0;i<mitad;i++)
		tex1+=texto.charAt(i);
	for(var l=texto.length-1;l>=texto.length-mitad;l--)
		tex2+=texto.charAt(l);
	for(var n=0;n<mitad;n++){
		if(tex1.charAt(n)!=tex2.charAt(n))
			iguales=false;
	}
	if(iguales)
		$("#Res").html("El texto es palindromo");
	else
		$("#Res").html("El texto no es palindromo");
}