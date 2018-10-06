var colTempDiaMes=[];
$(document).ready(function(){
	$("#btnAgregar").click(Agregar);
	$("#btnBorrar").click(Borrar);
	$("#btnModificar").click(Modificar);
});
function Limpiar(){
	$("#txtTemp").val("");
	$("#txtDia").val("");
	$("#txtMes").val("");
}
function Agregar(){
	var agrego={
		Temperatura:$("#txtTemp").val(),
		Dia:$("#txtDia").val(),
		Mes:document.getElementById("sltMeses").options[document.getElementById("sltMeses").selectedIndex].value,	//javascript
	};
	colTempDiaMes.push(agrego);
	Limpiar();
}
function Borrar(){
	for(var i=0;i<colTempDiaMes.length;i++){
		if(colTempDiaMes[i].Dia==$("#txtDia").val()&&colTempDiaMes[i].Mes==$("#txtMes").val())
			colTempDiaMes.splice(i,1);			//slice primer parametro dice donde empezar, el otro hasta donde borrar, y el otro para agregar, se pueden agregar mas
												//colTempDiaMes.pop() borrar el ultimo elemento
	}
	Limpiar();									//colTempDiaMes.unshift(element) para agregar elemento al principio de el arreglo
}												//colTempDiaMes.shift() para eliminar al comienzo de el arreglo
function Modificar(){
	for(var i=0;i<colTempDiaMes.length;i++){
		if(colTempDiaMes[i].Dia==$("#txtDia").val()&&colTempDiaMes[i].Mes==$("#txtMes").val())
			colTempDiaMes[i].Temperatura=$("#txtTemp").val();
	}
	Limpiar();
}