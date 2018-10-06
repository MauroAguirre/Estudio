$(document).ready(function(){
	$("#btnResultado").click(Resultado);
});
function Resultado(){
	if(!Verificar($("#numHoras").val(),$("#numDias").val()))
		$("#Resultado").html("Error en los datos");
	else{
		var dinero;
		if($("#Electricista").is(":checked"))
			dinero=Costo(0,$("#numHoras").val(),$("#numDias").val());
		
		else
			dinero=Costo(1,$("#numHoras").val(),$("#numDias").val());
		$("#Resultado").html(ConMateriales(dinero));
	}
}
function ConMateriales(costo){
	return costo+(costo*0.10);
}
function Costo(trabajador,horas,dias){
	if(trabajador==0)
		return (horas*200)*dias;
	return (horas*150)*dias;
}
function Verificar(horas,dias){
	if(horas<=0||dias<=0)
		return false;
	return true;
}