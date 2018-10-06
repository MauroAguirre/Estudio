$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var mayusculas=0;
	var minusculas=0;
	var otro=0;
	texto=$("#txt1").val();
	while(texto.charAt(0)==" "){
		texto=texto.substr(1,texto.lengh);
	}
	for(var i=0;i<texto.length;i++){
		switch(texto.charAt(i)){
		case "a":
		case "b":
		case "c":
		case "d":
		case "e":
		case "f":
		case "g":
		case "h":
		case "i":
		case "j":
		case "k":
		case "l":
		case "m":
		case "n":
		case "o":
		case "p":
		case "q":
		case "r":
		case "s":
		case "t":
		case "u":
		case "v":
		case "w":
		case "x":
		case "y":
		case "z":
			minusculas++;
			break;
		case "A":
		case "B":
		case "C":
		case "D":
		case "E":
		case "F":
		case "G":
		case "H":
		case "I":
		case "J":
		case "K":
		case "L":
		case "M":
		case "N":
		case "O":
		case "P":
		case "Q":
		case "R":
		case "S":
		case "T":
		case "U":
		case "V":
		case "W":
		case "X":
		case "Y":
		case "Z":
			mayusculas++;
			break;
		default:
			otro++;
		}
	}
	$("#Res").html("La cantidad de mayusculas es de: "+mayusculas+'<br>'+"La cantidad de minisculas es de: "+
	minusculas+'<br>'+"La cantidad de otros caracteres es de: "+otro);
}