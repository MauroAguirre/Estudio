//Crear una funcion que en base al ingreso de una matricula informe en que departamento del uruguay es
//se debe tener en cuenta que le primer caracter de la matricula indica el departamento
$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var letra=document.getElementById("txt1").value[0];
	letra=letra.toUpperCase();
	switch(letra){
		case "A":
			$("#lbl1").html("El departamento es "+"Canelones");
			break;
		case "B":
			$("#lbl1").html("El departamento es "+"Maldonado");
			break;
		case "C":
			$("#lbl1").html("El departamento es "+"Rocha");
			break;
		case "D":
			$("#lbl1").html("El departamento es "+"33");
			break;
		case "E":
			$("#lbl1").html("El departamento es "+"Cerro Largo");
			break;
		case "F":
			$("#lbl1").html("El departamento es "+"Rivera");
			break;
		case "G":
			$("#lbl1").html("El departamento es "+"Artigas");
			break;
		case "H":
			$("#lbl1").html("El departamento es "+"Salto");
			break;
		case "I":
			$("#lbl1").html("El departamento es "+"Paysandu");
			break;
		case "J":
			$("#lbl1").html("El departamento es "+"Rio Negro");
			break;
		case "K":
			$("#lbl1").html("El departamento es "+"Soriano");
			break;
		case "L":
			$("#lbl1").html("El departamento es "+"Colonia");
			break;
		case "M":
			$("#lbl1").html("El departamento es "+"San Jose");
			break;
		case "N":
			$("#lbl1").html("El departamento es "+"Flores");
			break;
		case "O":
			$("#lbl1").html("El departamento es "+"Florida");
			break;
		case "P":
			$("#lbl1").html("El departamento es "+"Lavaleja");
			break;
		case "I":
			$("#lbl1").html("El departamento es "+"D");
			break;
		case "I":
			$("#lbl1").html("El departamento es "+"Tacuarembo");
			break;
		case "I":
			$("#lbl1").html("El departamento es "+"Montevideo");
			break;
		default:
			$("#lbl1").html("Error en el departamento");
			break;
	}
}