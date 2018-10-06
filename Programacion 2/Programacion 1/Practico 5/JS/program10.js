$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	switch($("#txt1").val().charAt(0).toUpperCase()){
		case "A":
			$("#res").html("El departamento es Canelones");
			break;
		case "B":
			$("#res").html("El departamento es Maldonado");
			break;
		case "C":
			$("#res").html("El departamento es Rocha");
			break;
		case "D":
			$("#res").html("El departamento es Treinta y Tres");
			break;
		case "E":
			$("#res").html("El departamento es Cerro Largo");
			break;
		case "F":
			$("#res").html("El departamento es Rivera");
			break;
		case "G":
			$("#res").html("El departamento es Artigas");
			break;
		case "H":
			$("#res").html("El departamento es Salto");
			break;
		case "I":
			$("#res").html("El departamento es Paysandu");
			break;
		case "J":
			$("#res").html("El departamento es Rio Negro");
			break;
		case "K":
			$("#res").html("El departamento es Soriano");
			break;
		case "L":
			$("#res").html("El departamento es Colonia");
			break;
		case "M":
			$("#res").html("El departamento es San Jose");
			break;
		case "N":
			$("#res").html("El departamento es Flores");
			break;
		case "O":
			$("#res").html("El departamento es Florida");
			break;
		case "P":
			$("#res").html("El departamento es Lavalleja");
			break;
		case "Q":
			$("#res").html("El departamento es Durazno");
			break;
		case "R":
			$("#res").html("El departamento es Tacuarembo");
			break;
		case "S":
			$("#res").html("El departamento es Montevideo");
			break;
		default :
			$("#res").html("No existe el departamento");
	}
}