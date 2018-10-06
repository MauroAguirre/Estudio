var colTempDiaMes=[];
window.onload=Load;
function Load(){
//	Tres formas
//	var objeto = document.createElement("option");
//	objeto.text="Enero"
//	document.getElementById("sltDias").options[document.getElementById("sltDias").options.length]=objeto;
	
//	document.getElementById("sltDias").innerHTML='<option>Enero</option>';

	var objeto = document.createElement("h1");
	objeto.innerText="Titulo";
	document.getElementById("Titulo").appendChild(objeto);
//	$("#Titulo").html('<h2>Titulo</h2>');
}
$(document).ready(function(){
	$("#btnAgregar").click(Agregar);
	$("#btnBorrar").click(Borrar);
	$("#btnModificar").click(Modificar);
	$("#sltMeses").change(Cambio);
});
function Cambio(){
	var meses = document.getElementById("sltMeses");
	var dias = document.getElementById("sltDias");
	switch(meses.options[meses.selectedIndex].text){
		case "Enero":
		case "Marzo":
		case "Mayo":
		case "Julio":
		case "Agosto":
		case "Octubre":
		case "Diciembre":
			dias.innerHTML="";
			for(var i=1;i<32;i++){
				dias.innerHTML+='<option>'+i+'</option>';
			}
			break;
		case "Febrero":
			dias.innerHTML="";
			for(var i=1;i<29;i++){
				dias.innerHTML+='<option>'+i+'</option>';
			}
			break;
		default:
			dias.innerHTML="";
			for(var i=1;i<31;i++){
				dias.innerHTML+='<option>'+i+'</option>';
			}
			break;
	}
}
function Limpiar(){
	$("#txtTemp").val("");
	$("#txtDia").val("");
	$("#txtMes").val("");
}
function Agregar(){
	var agrego={
		Temperatura:$("#txtTemp").val(),
		Dia:$("#txtDia").val(),
		Mes:document.getElementById("sltMeses").options[document.getElementById("sltMeses").selectedIndex].text,	//javascript
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