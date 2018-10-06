var personas=[];
$(document).ready(function(){
	$("#Tablas").hide();
	$("#btnAgregar").click(Agregar);
	$("#btnDatos").click(Datos);
	$("#btnMayores").click(Mayores);
});
function Agregar(){
	persona={
		Nombre:$("#txtNombre").val(),
		Edad:$("#numEdad").val(),
		Nacionalidad:$("#txtNacionalidad").val(),
	};
	personas.push(persona);
	$("#txtNombre").val("");
	$("#numEdad").val("");
	$("#txtNacionalidad").val("");
}
function Datos(){
	if(personas.length>0){
		$("#Tablas").show();
		$("#TablasBody").html("");
		for(var i=0;i<personas.length;i++)
			$("#TablasBody").append('<tr><td>'+personas[i].Nombre+'</td><td>'+personas[i].Edad+'</td><td>'+personas[i].Nacionalidad+'</td></tr>');
	}
}
function Mayores(){
	if(personas.length>0){
		$("#Tablas").show();
		$("#TablasBody").html("");
		var ordenado=[];
		for(var i=0;i<personas.length;i++){
			var producto={
				Nombre:personas[i].Nombre,
				Edad:personas[i].Edad,
				Nacionalidad:personas[i].Nacionalidad,
			};
			ordenado.push(producto);
		}
		ordenado.sort(Ordenar);
		for(var i=0;i<ordenado.length;i++)
			$("#TablasBody").append('<tr><td>'+ordenado[i].Nombre+'</td><td>'+ordenado[i].Edad+'</td><td>'+ordenado[i].Nacionalidad+'</td></tr>');
	}
}
function Ordenar(a,b){
	return a.Edad-b.Edad;
}