var col=["Ana","Lucia","Maria"];
col.push("Juan");
$(document).ready(function(){
	$("#res").html(col.length);
	$("#res").append('<br>'+col[0]);
	$("#res").append('<br>'+col[col.length-1]+'<br>');
	for(var i=0;i<col.length;i++)
		$("#res").append(col[i]+" ");
	$("#btn1").click(Verificar);
	$("#btn2").click(Modificar);
});
function Modificar(){
	var texto=$("#txt1").val();
	for(var i=0;i<col.length;i++){
		if(col[i]==texto){
			$("#res2").html("Cambio completado");
			col[i]=$("#txt2").val();
			return;
		}
	}
	$("#res2").html("No esta el texto en el array");
}
function Verificar(){
	var texto=$("#txt1").val();
	for(var i=0;i<col.length;i++){
		if(col[i]==texto){
			$("#res2").html("El texto esta en la posicion "+(i+1));
			return;
		}
	}
	$("#res2").html("No esta el texto en el array");
}