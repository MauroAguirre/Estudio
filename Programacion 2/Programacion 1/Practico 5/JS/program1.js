$(document).ready(function(){
	$("#btn1").click(Resultado);
});
function Resultado(){
	var texto=$("#txt1").val();
	var palabra="";
	for(var i=texto.length;i>=0;i--)
		palabra+=texto.charAt(i);
		document.write(palabra);
}