var dia=prompt("Ingrese el dia");
var temperatura=prompt("Ingrese la temperatura");
document.write("Levantarse"+'<br>');
if(temperatura>10){
	if(temperatura>20)
		document.write("Ponerse ropa comoda"+'<br>');
	else
		document.write("Abrigo moderado"+'<br>');
}
else
	document.write("Abrigarse mucho"+'<br>');
if(dia=="domingo")
	document.write("Quedarse en casa, hoy no trabaja");
else
	document.write("Ir al trabajo");